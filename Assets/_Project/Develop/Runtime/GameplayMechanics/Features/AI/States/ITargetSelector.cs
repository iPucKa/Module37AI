using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using System.Collections.Generic;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States
{
	public interface ITargetSelector
	{
		Entity SelectTargetFrom(IEnumerable<Entity> targets);
	}
}
