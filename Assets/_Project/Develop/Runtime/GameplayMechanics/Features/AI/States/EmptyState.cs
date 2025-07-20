using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public class EmptyState : State, IUpdatableState
	{
		public void Update(float deltaTime)
		{

		}

		public override void Enter()
		{
			base.Enter();
			Debug.Log("Ничего не делаю");
		}
	}
}
