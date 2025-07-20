using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public class AttackByKeyState : State, IUpdatableState
	{
		private const int LeftMouseButton = 0;

		private ReactiveEvent _attackRequest;

		private ReactiveVariable<bool> _isAttackKeyPressed;

		public AttackByKeyState(Entity entity)
		{
			_attackRequest = entity.StartAttackRequest;
			_isAttackKeyPressed = entity.IsAttackKeyPressed;
		}		

		public void Update(float deltaTime)
		{
			if (_isAttackKeyPressed.Value == false)
				_isAttackKeyPressed.Value = Input.GetMouseButtonDown(LeftMouseButton);

			if (_isAttackKeyPressed.Value)
			{
				_attackRequest.Invoke();
				_isAttackKeyPressed.Value = false;
			}
		}

		public override void Exit()
		{
			base.Exit();

			_isAttackKeyPressed.Value = false;
		}
	}
}
