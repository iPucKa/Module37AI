using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public class AttackTriggerState : State, IUpdatableState
	{
		private ReactiveEvent _attackRequest;

		public AttackTriggerState(Entity entity)
		{
			_attackRequest = entity.StartAttackRequest;
		}

		public override void Enter()
		{
			base.Enter();

			_attackRequest.Invoke();
		}

		public void Update(float deltaTime)
		{
		}
	}
}
