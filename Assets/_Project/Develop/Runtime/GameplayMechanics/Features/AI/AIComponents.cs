using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.Utilities.Reactive;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI
{
	public class CurrentTarget : IEntityComponent
	{
		public ReactiveVariable<Entity> Value;
	}
}
