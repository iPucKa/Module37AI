using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using Assets._Project.Develop.Runtime.Utilities.StateMachineCore;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public class MouseRotationState : State, IUpdatableState
	{
		private Camera _camera;
		private Transform _transform;
		private ReactiveVariable<Vector3> _rotationDirection;

		public MouseRotationState(
			Entity entity,
			Camera camera)
		{
			_rotationDirection = entity.RotationDirection;
			_transform = entity.Transform;
			_camera = camera;
		}		

		public void Update(float deltaTime)
		{
			// Получаю луч от камеры через позицию мыши
			Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

			// Создаю плоскость на уровне объекта
			Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

			// Определяю точку пересечения луча с плоскостью
			if (groundPlane.Raycast(ray, out float point))
			{
				Vector3 targetPoint = ray.GetPoint(point);
				
				GetRotationDirection(targetPoint);
			}
		}

		private void GetRotationDirection(Vector3 mousePosition)
		{
			_rotationDirection.Value = (mousePosition - _transform.position).normalized;
		}
	}
}
