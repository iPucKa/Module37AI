using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Mono;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.Shoot
{
	public class ShootPointEntityRegistrator : MonoEntityRegistrator
	{
		[SerializeField] private Transform _shootPoint;

		public override void Register(Entity entity)
		{
			entity.AddShootPoint(_shootPoint);
		}
	}
}
