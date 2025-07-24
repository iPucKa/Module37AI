using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.InputFeature
{
	public class MouseInput : IInputService
	{
		private readonly Camera _camera;

		private Vector3 _mousePosition;

		public MouseInput(Camera camera)
		{
			_camera = camera;
		}

		private const int LeftMouseButton = 0;

		public bool IsEnabled { get; set; } = true;

		public Vector3 Direction
		{
			get
			{
				if (IsEnabled == false)
					return Vector3.zero;

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
