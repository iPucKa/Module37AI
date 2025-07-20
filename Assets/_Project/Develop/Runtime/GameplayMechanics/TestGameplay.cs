using Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore;
using Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI;
using Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.States;
using Assets._Project.Develop.Runtime.Infrastructure.DI;
using UnityEngine;

namespace Assets._Project.Develop.Runtime.GameplayMechanics
{
	public class TestGameplay : MonoBehaviour
	{
		private DIContainer _container;
		private EntitiesFactory _entitiesFactory;
		private BrainsFactory _brainsFactory;

		private Entity _entityNewHero;
		private Entity _ghost;

		private bool _isRunning;

		public void Initialize(DIContainer container)
		{
			_container = container;
			_entitiesFactory = _container.Resolve<EntitiesFactory>();
			_brainsFactory = _container.Resolve<BrainsFactory>();
		}

		public void Run()
		{
			_ghost = _entitiesFactory.CreateGhost(Vector3.zero + Vector3.forward * 3);
			//_brainsFactory.CreateGhostBrain(_ghost);

			_entityNewHero = _entitiesFactory.CreateNewHero(Vector3.zero);
			//добавить мозг Герою

			_isRunning = true;
		}

		private void Update()
		{
			if (_isRunning == false)
				return;

			if (Input.GetKeyDown(KeyCode.I))
			{
				Debug.Log("РЕЖИМ СВОБОДНОЙ ТЕЛЕПОРТАЦИИ");

				_brainsFactory.CreateMainHeroRandomTeleportingBrain(_entityNewHero);
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				Debug.Log("РЕЖИМ ТЕЛЕПОРТАЦИИ К ЦЕЛИ");

				_brainsFactory.CreateMainHeroToTargetTeleportingBrain(_entityNewHero, new MinHealthDamageableTargetSelector(_entityNewHero));
			}

			//if(Input.GetKeyDown(KeyCode.F))
			//	_entityNewHero.TakeDamageRequest.Invoke(50);
		}
	}
}
