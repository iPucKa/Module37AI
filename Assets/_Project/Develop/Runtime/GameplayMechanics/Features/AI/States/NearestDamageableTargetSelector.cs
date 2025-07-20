﻿using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public class NearestDamageableTargetSelector : ITargetSelector
	{
		private Entity _source;
		private Transform _sourceTransform;

		public NearestDamageableTargetSelector(Entity entity)
		{
			_source = entity;
			_sourceTransform = entity.Transform;
		}

		public Entity SelectTargetFrom(IEnumerable<Entity> targets)
		{
			IEnumerable<Entity> selectedTargets = targets.Where(target =>
			{
				bool result = target.HasComponent<TakeDamageRequest>();
				if (target.TryGetCanApplyDamage(out ICompositCondition canApplyDamage))
				{
					result = result && canApplyDamage.Evaluate();
				}

				result = result && (target != _source);
				return result;
			});

			if (selectedTargets.Any() == false)
				return null;

			Entity closestTarget = selectedTargets.First();
			float minDistance = GetDistanceTo(closestTarget);

			foreach (Entity target in selectedTargets)
			{
				float distance = GetDistanceTo(target);

				if (distance < minDistance)
				{
					minDistance = distance;
					closestTarget = target;
				}
			}

			return closestTarget;
		}

		private float GetDistanceTo(Entity target) => (_sourceTransform.position - target.Transform.position).magnitude;
	}
}
