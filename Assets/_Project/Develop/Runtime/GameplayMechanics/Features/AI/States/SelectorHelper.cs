using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage;
using Assets._Project.Develop.Runtime.Utilities.Conditions;
using System.Collections.Generic;
using System.Linq;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public class SelectorHelper
	{
		public static IEnumerable<Entity> InitialFilteredTargetsFrom(IEnumerable<Entity> targets, Entity source)
		{
			IEnumerable<Entity> selectedTargets = targets.Where(target =>
			{
				bool result = target.HasComponent<TakeDamageRequest>();
				if (target.TryGetCanApplyDamage(out ICompositCondition canApplyDamage))
				{
					result = result && canApplyDamage.Evaluate();
				}

				result = result && (target != source);
				return result;
			});

			if (selectedTargets.Any() == false)
				return null;			

			return selectedTargets;
		}
	}
}
