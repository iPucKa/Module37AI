using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Mono;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Common
{
	public class TransformEntityRegistrator : MonoEntityRegistrator
	{
		public override void Register(Entity entity)
		{
			entity.AddTransform(transform);
		}
	}
}
