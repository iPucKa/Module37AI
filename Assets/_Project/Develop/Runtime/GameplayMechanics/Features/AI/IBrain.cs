using System;

namespace Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI
{
	public interface IBrain : IDisposable
	{
		void Enable();
		void Disable();
		void Update(float deltaTime);
	}
}
