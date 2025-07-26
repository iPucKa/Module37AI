using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.InputFeature
{
	public interface IInputService
	{
		bool IsEnabled { get; set; }

		Vector3 Direction { get; }

		Vector3 PointerPosition { get; }

		bool IsAttackButtonPressed { get; }
	}
}
