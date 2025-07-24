using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.InputFeature
{
	public class DesktopInput : IInputService
	{
		private const string HorizontalAxisName = "Horizontal";
		private const string VerticalAxisName = "Vertical";

		public bool IsEnabled { get; set; } = true;

		public Vector3 Direction
		{
			get
			{
				if (IsEnabled == false)
					return Vector3.zero;

				return new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));
			}
		}
	
		public bool IsAttackButtonPressed => Input.GetKeyDown(KeyCode.V);		
	}
}
