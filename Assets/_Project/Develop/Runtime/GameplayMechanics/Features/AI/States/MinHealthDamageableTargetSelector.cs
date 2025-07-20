using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using System.Collections.Generic;
using System.Linq;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public class MinHealthDamageableTargetSelector : ITargetSelector
	{
		private Entity _source;

		public MinHealthDamageableTargetSelector(Entity entity)
		{
			_source = entity;
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

			Entity minHealthTarget = selectedTargets.First();
			float minHealth = GetHealth(minHealthTarget);

			foreach (Entity target in selectedTargets)
			{
				float currentHealth = GetHealth(target);

				if (currentHealth < minHealth)
				{
					minHealth = currentHealth;
					minHealthTarget = target;
				}
			}

			return minHealthTarget;
		}

		private float GetHealth(Entity target) => target.CurrentHealth.Value;
	}
}
