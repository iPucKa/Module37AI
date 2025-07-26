using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.InputFeature
{
	public class DesktopInput : IInputService
	{
		private const string HorizontalAxisName = "Horizontal";
		private const string VerticalAxisName = "Vertical";
		private const int LeftMouseButton = 0;

		private readonly Camera _camera;

		public DesktopInput(Camera camera)
		{
			_camera = camera;
		}

		private Vector3 _mousePosition;

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

		public Vector3 PointerPosition
		{
			get
			{
				// Получаю луч от камеры через позицию мыши
				Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

				// Создаю плоскость на уровне объекта
				Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

				// Определяю точку пересечения луча с плоскостью
				if (groundPlane.Raycast(ray, out float point))
					_mousePosition = ray.GetPoint(point);

				return _mousePosition;
			}
		}

		public bool IsAttackButtonPressed => Input.GetMouseButtonDown(LeftMouseButton);
	}
}
