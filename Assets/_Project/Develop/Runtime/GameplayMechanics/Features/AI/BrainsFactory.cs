using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States;
using Assets._Project.Develop.Runtime.GameplayMechanics.Features.InputFeature;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities.Timer;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI
{
	public class BrainsFactory
	{
		private readonly DIContainer _container;
		private readonly TimerServiceFactory _timerServiceFactory;
		private readonly AIBrainsContext _brainsContext;
		private readonly IInputService _inputService;
		private readonly EntitiesLifeContext _entitiesLifeContext;

		public BrainsFactory(DIContainer container)
		{
			_container = container;
			_timerServiceFactory = _container.Resolve<TimerServiceFactory>();
			_brainsContext = _container.Resolve<AIBrainsContext>();
			_inputService = _container.Resolve<IInputService>();
			_entitiesLifeContext = _container.Resolve<EntitiesLifeContext>();
		}

		public StateMachineBrain CreateSimpleHeroBrain(Entity entity, Camera camera)
		{
			AIStateMachine combatState = CreatePlayerAttackStateMachine(entity, camera);

			PlayerInputMovementState movementState = new PlayerInputMovementState(entity, _inputService);			

			ICompositCondition fromMovementToCombatStateCondition = new CompositCondition()
				.Add(entity.CanStartAttack)
				.Add(new FuncCondition(() => _inputService.Direction == Vector3.zero));

			ICompositCondition fromCombatToMovemenStateCondition = new CompositCondition()
				.Add(entity.CanMove)
				.Add(new FuncCondition(() => _inputService.Direction != Vector3.zero));

			AIStateMachine behaviour = new AIStateMachine();
			behaviour.AddState(combatState);
			behaviour.AddState(movementState);

			behaviour.AddTransition(combatState, movementState, fromCombatToMovemenStateCondition);
			behaviour.AddTransition(movementState, combatState, fromMovementToCombatStateCondition);

			StateMachineBrain brain = new StateMachineBrain(behaviour);

			_brainsContext.SetFor(entity, brain);

			return brain;
		}

		public StateMachineBrain CreateMainHeroRandomTeleportingBrain(Entity entity)
		{
			AIStateMachine stateMachine = CreateRandomTeleportStateMachine(entity);
			StateMachineBrain brain = new StateMachineBrain(stateMachine);

			_brainsContext.SetFor(entity, brain);

			return brain;
		}

		public StateMachineBrain CreateMainHeroToTargetTeleportingBrain(Entity entity, ITargetSelector targetSelector)
		{
			AIStateMachine stateMachine = CreateTeleportToTargetStateMachine(entity, targetSelector);
			StateMachineBrain brain = new StateMachineBrain(stateMachine);

			_brainsContext.SetFor(entity, brain);

			return brain;
		}

		public StateMachineBrain CreateGhostBrain(Entity entity)
		{
			AIStateMachine stateMachine = CreateRandomMovementStateMachine(entity);
			StateMachineBrain brain = new StateMachineBrain(stateMachine);

			_brainsContext.SetFor(entity, brain);

			return brain;
		}

		private AIStateMachine CreateRandomMovementStateMachine(Entity entity)
		{
			List<IDisposable> disposables = new List<IDisposable>();

			RandomMovementState randomMovementState = new RandomMovementState(entity, 0.5f);

			EmptyState emptyState = new EmptyState();

			TimerService movementTimer = _timerServiceFactory.Create(2f);
			disposables.Add(movementTimer);
			disposables.Add(randomMovementState.Entered.Subscribe(movementTimer.Restart));

			TimerService idleTimer = _timerServiceFactory.Create(3f);
			disposables.Add(idleTimer);
			disposables.Add(emptyState.Entered.Subscribe(idleTimer.Restart));

			FuncCondition movementTimerEndedCondition = new FuncCondition(() => movementTimer.IsOver);
			FuncCondition idleTimerEndedCondition = new FuncCondition(() => idleTimer.IsOver);

			AIStateMachine stateMachine = new AIStateMachine(disposables);

			stateMachine.AddState(randomMovementState);
			stateMachine.AddState(emptyState);

			stateMachine.AddTransition(randomMovementState, emptyState, movementTimerEndedCondition);
			stateMachine.AddTransition(emptyState, randomMovementState, idleTimerEndedCondition);

			return stateMachine;
		}

		private AIStateMachine CreateRandomTeleportStateMachine(Entity entity)
		{
			RandomTeleportingState randomTeleportingState = new RandomTeleportingState(entity, entity.TeleportCooldownInitialTime.Value);

			EmptyState emptyState = new EmptyState();

			ICondition canTeleport = entity.CanTeleport;

			ICompositCondition fromEmptyToTeleportingStateCondition = new CompositCondition()
				.Add(canTeleport);

			ICompositCondition fromTeleportingToEmptyStateCondition = new CompositCondition(LogicOperations.Or)
				//.Add(new FuncCondition(() => canTeleport.Evaluate()==false));
				.Add(new FuncCondition(() => entity.IsDead.Value == true))
				.Add(new FuncCondition(() => entity.InTeleportCooldown.Value == true))
				.Add(new FuncCondition(() => entity.CurrentEnergy.Value < entity.TeleportByEnergyValue.Value));

			AIStateMachine stateMachine = new AIStateMachine();

			stateMachine.AddState(randomTeleportingState);
			stateMachine.AddState(emptyState);

			stateMachine.AddTransition(emptyState, randomTeleportingState, fromEmptyToTeleportingStateCondition);
			stateMachine.AddTransition(randomTeleportingState, emptyState, fromTeleportingToEmptyStateCondition);

			return stateMachine;
		}

		private AIStateMachine CreateTeleportToTargetStateMachine(Entity entity, ITargetSelector targetSelector)
		{
			TeleportToTargetState teleportToTargetState = new TeleportToTargetState(entity, entity.TeleportCooldownInitialTime.Value);

			EmptyState emptyState = new EmptyState();

			ICondition canTeleport = entity.CanTeleport;

			float energyEconomyValue = 0.4f * entity.MaxEnergy.Value;

			ICompositCondition fromEmptyToTeleportingStateCondition = new CompositCondition()
				.Add(canTeleport)
				.Add(new FuncCondition(() => entity.CurrentEnergy.Value >= energyEconomyValue));

			ICompositCondition fromTeleportingToEmptyStateCondition = new CompositCondition(LogicOperations.Or)
				.Add(new FuncCondition(() => entity.IsDead.Value == true))
				.Add(new FuncCondition(() => entity.InTeleportCooldown.Value == true))
				.Add(new FuncCondition(() => entity.CurrentEnergy.Value < energyEconomyValue));

			AIStateMachine stateMachine = new AIStateMachine();

			stateMachine.AddState(teleportToTargetState);
			stateMachine.AddState(emptyState);

			stateMachine.AddTransition(emptyState, teleportToTargetState, fromEmptyToTeleportingStateCondition);
			stateMachine.AddTransition(teleportToTargetState, emptyState, fromTeleportingToEmptyStateCondition);

			FindTargetState findTargetState = new FindTargetState(targetSelector, _entitiesLifeContext, entity);
			AIParallelState parallelState = new AIParallelState(findTargetState, stateMachine);

			AIStateMachine rootStateMachine = new AIStateMachine();
			rootStateMachine.AddState(parallelState);

			return rootStateMachine;
		}

		private AIStateMachine CreatePlayerAttackStateMachine(Entity entity, Camera camera)
		{
			MouseTrackService mouseTrackService = new MouseTrackService(camera, _inputService);
			
			MouseRotationState mouseRotationState = new MouseRotationState(entity, _inputService, mouseTrackService);

			AttackByKeyState attackByKeyState = new AttackByKeyState(entity);

			ReactiveVariable<bool> inAttackProcess = entity.InAttackProcess;

			ICompositCondition fromAttackToMouseRotationStateCondition = new CompositCondition()
				.Add(entity.CanRotate)
				.Add(new FuncCondition(() => inAttackProcess.Value == false));
			
			ICompositCondition fromMouseRotationToAttackStateCondition = new CompositCondition()
				.Add(entity.CanStartAttack)
				.Add(new FuncCondition(() => entity.IsAttackKeyPressed.Value == true));

			AIStateMachine stateMachine = new AIStateMachine();

			stateMachine.AddState(attackByKeyState);
			stateMachine.AddState(mouseRotationState);

			stateMachine.AddTransition(attackByKeyState, mouseRotationState, fromAttackToMouseRotationStateCondition);
			stateMachine.AddTransition(mouseRotationState, attackByKeyState, fromMouseRotationToAttackStateCondition);	

			return stateMachine;
		}		
	}
}
