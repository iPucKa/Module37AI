﻿using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Systems;
using Assets._Project.Develop.Runtime.Utilities.Reactive;
using System;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.Shoot
{
	public class InstantShootSystem : IInitializableSystem, IDisposableSystem
	{
		private readonly EntitiesFactory _entitiesFactory;

		public InstantShootSystem(EntitiesFactory entitiesFactory)
		{
			_entitiesFactory = entitiesFactory;
		}

		private ReactiveEvent _attackDelayEndEvent;
		private ReactiveVariable<float> _damage;
		private Transform _shootPoint;

		private IDisposable _attackDelayEndDisposable;

		public void OnInit(Entity entity)
		{
			_attackDelayEndEvent = entity.AttackDelayEndEvent;
			_damage = entity.InstantAttackDamage;
			_shootPoint = entity.ShootPoint;

			_attackDelayEndDisposable = _attackDelayEndEvent.Subscribe(OnAttackDelayEnd);
		}

		private void OnAttackDelayEnd()
		{
			//Debug.Log($"Выстрел, урон: {_damage.Value}, точка выстрела: {_shootPoint.position}");
			_entitiesFactory.CreateProjectile(_shootPoint.position, _shootPoint.forward, _damage.Value);
		}

		public void OnDispose()
		{
			_attackDelayEndDisposable.Dispose();
		}
	}
}
