namespace Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore
{
	public partial class Entity
	{
		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportPosition TeleportPositionC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportPosition>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> TeleportPosition => TeleportPositionC.Value;

		public bool TryGetTeleportPosition(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportPosition component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportPosition()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportPosition() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportPosition(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportPosition() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportRadius TeleportRadiusC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportRadius>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> TeleportRadius => TeleportRadiusC.Value;

		public bool TryGetTeleportRadius(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportRadius component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportRadius()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportRadius() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportRadius(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportRadius() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.CanTeleport CanTeleportC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.CanTeleport>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanTeleport => CanTeleportC.Value;

		public bool TryGetCanTeleport(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.CanTeleport component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCanTeleport(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.CanTeleport() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingRequest TeleportingRequestC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingRequest>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent TeleportingRequest => TeleportingRequestC.Value;

		public bool TryGetTeleportingRequest(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingRequest component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportingRequest()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingRequest() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportingRequest(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingRequest() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingEvent TeleportingEventC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent TeleportingEvent => TeleportingEventC.Value;

		public bool TryGetTeleportingEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportingEvent()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportingEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportingEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownInitialTime TeleportCooldownInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> TeleportCooldownInitialTime => TeleportCooldownInitialTimeC.Value;

		public bool TryGetTeleportCooldownInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportCooldownInitialTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportCooldownInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownCurrentTime TeleportCooldownCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> TeleportCooldownCurrentTime => TeleportCooldownCurrentTimeC.Value;

		public bool TryGetTeleportCooldownCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportCooldownCurrentTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportCooldownCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.TeleportCooldownCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.InTeleportCooldown InTeleportCooldownC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.InTeleportCooldown>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InTeleportCooldown => InTeleportCooldownC.Value;

		public bool TryGetInTeleportCooldown(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.InTeleportCooldown component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInTeleportCooldown()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.InTeleportCooldown() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInTeleportCooldown(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.TeleportationFeature.InTeleportCooldown() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.BodyCollider BodyColliderC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.BodyCollider>();

		public UnityEngine.CapsuleCollider BodyCollider => BodyColliderC.Value;

		public bool TryGetBodyCollider(out UnityEngine.CapsuleCollider value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.BodyCollider component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.CapsuleCollider);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddBodyCollider(UnityEngine.CapsuleCollider value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.BodyCollider() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactsDetectingMask ContactsDetectingMaskC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactsDetectingMask>();

		public UnityEngine.LayerMask ContactsDetectingMask => ContactsDetectingMaskC.Value;

		public bool TryGetContactsDetectingMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactsDetectingMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddContactsDetectingMask(UnityEngine.LayerMask value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactsDetectingMask() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactCollidersBuffer ContactCollidersBufferC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactCollidersBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> ContactCollidersBuffer => ContactCollidersBufferC.Value;

		public bool TryGetContactCollidersBuffer(out Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactCollidersBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddContactCollidersBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactCollidersBuffer() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactCollidersBuffer AreaContactCollidersBufferC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactCollidersBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> AreaContactCollidersBuffer => AreaContactCollidersBufferC.Value;

		public bool TryGetAreaContactCollidersBuffer(out Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactCollidersBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAreaContactCollidersBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<UnityEngine.Collider> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactCollidersBuffer() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactEntitiesBuffer ContactEntitiesBufferC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactEntitiesBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> ContactEntitiesBuffer => ContactEntitiesBufferC.Value;

		public bool TryGetContactEntitiesBuffer(out Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactEntitiesBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddContactEntitiesBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.ContactEntitiesBuffer() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactEntitiesBuffer AreaContactEntitiesBufferC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactEntitiesBuffer>();

		public Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> AreaContactEntitiesBuffer => AreaContactEntitiesBufferC.Value;

		public bool TryGetAreaContactEntitiesBuffer(out Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactEntitiesBuffer component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAreaContactEntitiesBuffer(Assets._Project.Develop.Runtime.Utilities.Buffer<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.AreaContactEntitiesBuffer() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.DeathMask DeathMaskC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.DeathMask>();

		public UnityEngine.LayerMask DeathMask => DeathMaskC.Value;

		public bool TryGetDeathMask(out UnityEngine.LayerMask value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.DeathMask component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.LayerMask);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddDeathMask(UnityEngine.LayerMask value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.DeathMask() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.IsTouchDeathMask IsTouchDeathMaskC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.IsTouchDeathMask>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsTouchDeathMask => IsTouchDeathMaskC.Value;

		public bool TryGetIsTouchDeathMask(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.IsTouchDeathMask component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsTouchDeathMask()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.IsTouchDeathMask() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsTouchDeathMask(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Sensors.IsTouchDeathMask() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveDirection MoveDirectionC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveDirection>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> MoveDirection => MoveDirectionC.Value;

		public bool TryGetMoveDirection(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveDirection component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMoveDirection()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveDirection() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMoveDirection(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveDirection() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveSpeed MoveSpeedC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveSpeed>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MoveSpeed => MoveSpeedC.Value;

		public bool TryGetMoveSpeed(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMoveSpeed()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveSpeed() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMoveSpeed(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.MoveSpeed() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.IsMoving IsMovingC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.IsMoving>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsMoving => IsMovingC.Value;

		public bool TryGetIsMoving(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.IsMoving component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsMoving()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.IsMoving() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsMoving(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.IsMoving() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanMove CanMoveC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanMove>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanMove => CanMoveC.Value;

		public bool TryGetCanMove(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanMove component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCanMove(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanMove() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationSpeed RotationSpeedC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationSpeed>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> RotationSpeed => RotationSpeedC.Value;

		public bool TryGetRotationSpeed(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationSpeed component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddRotationSpeed()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationSpeed() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddRotationSpeed(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationSpeed() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationDirection RotationDirectionC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationDirection>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> RotationDirection => RotationDirectionC.Value;

		public bool TryGetRotationDirection(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationDirection component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddRotationDirection()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationDirection() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddRotationDirection(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<UnityEngine.Vector3> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.RotationDirection() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanRotate CanRotateC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanRotate>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanRotate => CanRotateC.Value;

		public bool TryGetCanRotate(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanRotate component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCanRotate(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.MovementFeature.CanRotate() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.CurrentHealth CurrentHealthC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.CurrentHealth>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> CurrentHealth => CurrentHealthC.Value;

		public bool TryGetCurrentHealth(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.CurrentHealth component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCurrentHealth()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.CurrentHealth() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCurrentHealth(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.CurrentHealth() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MaxHealth MaxHealthC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MaxHealth>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MaxHealth => MaxHealthC.Value;

		public bool TryGetMaxHealth(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MaxHealth component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMaxHealth()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MaxHealth() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMaxHealth(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MaxHealth() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.IsDead IsDeadC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.IsDead>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsDead => IsDeadC.Value;

		public bool TryGetIsDead(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.IsDead component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsDead()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.IsDead() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsDead(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.IsDead() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustDie MustDieC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustDie>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition MustDie => MustDieC.Value;

		public bool TryGetMustDie(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustDie component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMustDie(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustDie() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustSelfRelease MustSelfReleaseC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustSelfRelease>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition MustSelfRelease => MustSelfReleaseC.Value;

		public bool TryGetMustSelfRelease(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustSelfRelease component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMustSelfRelease(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.MustSelfRelease() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessInitialTime DeathProcessInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> DeathProcessInitialTime => DeathProcessInitialTimeC.Value;

		public bool TryGetDeathProcessInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddDeathProcessInitialTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddDeathProcessInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessCurrentTime DeathProcessCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> DeathProcessCurrentTime => DeathProcessCurrentTimeC.Value;

		public bool TryGetDeathProcessCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddDeathProcessCurrentTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddDeathProcessCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DeathProcessCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.InDeathProcess InDeathProcessC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.InDeathProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InDeathProcess => InDeathProcessC.Value;

		public bool TryGetInDeathProcess(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.InDeathProcess component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInDeathProcess()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.InDeathProcess() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInDeathProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.InDeathProcess() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DisableCollidersOnDeath DisableCollidersOnDeathC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DisableCollidersOnDeath>();

		public System.Collections.Generic.List<UnityEngine.Collider> DisableCollidersOnDeath => DisableCollidersOnDeathC.Value;

		public bool TryGetDisableCollidersOnDeath(out System.Collections.Generic.List<UnityEngine.Collider> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DisableCollidersOnDeath component);
			if(result)
				value = component.Value;
			else
				value = default(System.Collections.Generic.List<UnityEngine.Collider>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddDisableCollidersOnDeath()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DisableCollidersOnDeath() {Value = new System.Collections.Generic.List<UnityEngine.Collider>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddDisableCollidersOnDeath(System.Collections.Generic.List<UnityEngine.Collider> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.LifeCycle.DisableCollidersOnDeath() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CurrentEnergy CurrentEnergyC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CurrentEnergy>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> CurrentEnergy => CurrentEnergyC.Value;

		public bool TryGetCurrentEnergy(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CurrentEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCurrentEnergy()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CurrentEnergy() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCurrentEnergy(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CurrentEnergy() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.MaxEnergy MaxEnergyC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.MaxEnergy>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> MaxEnergy => MaxEnergyC.Value;

		public bool TryGetMaxEnergy(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.MaxEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMaxEnergy()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.MaxEnergy() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMaxEnergy(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.MaxEnergy() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.TeleportByEnergyValue TeleportByEnergyValueC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.TeleportByEnergyValue>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> TeleportByEnergyValue => TeleportByEnergyValueC.Value;

		public bool TryGetTeleportByEnergyValue(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.TeleportByEnergyValue component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportByEnergyValue()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.TeleportByEnergyValue() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTeleportByEnergyValue(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.TeleportByEnergyValue() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryInitialTime EnergyRecoveryInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> EnergyRecoveryInitialTime => EnergyRecoveryInitialTimeC.Value;

		public bool TryGetEnergyRecoveryInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddEnergyRecoveryInitialTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddEnergyRecoveryInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryCurrentTime EnergyRecoveryCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> EnergyRecoveryCurrentTime => EnergyRecoveryCurrentTimeC.Value;

		public bool TryGetEnergyRecoveryCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddEnergyRecoveryCurrentTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddEnergyRecoveryCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.EnergyRecoveryCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.InRestoreEnergyProcess InRestoreEnergyProcessC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.InRestoreEnergyProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InRestoreEnergyProcess => InRestoreEnergyProcessC.Value;

		public bool TryGetInRestoreEnergyProcess(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.InRestoreEnergyProcess component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInRestoreEnergyProcess()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.InRestoreEnergyProcess() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInRestoreEnergyProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.InRestoreEnergyProcess() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CanRestoreEnergy CanRestoreEnergyC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CanRestoreEnergy>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanRestoreEnergy => CanRestoreEnergyC.Value;

		public bool TryGetCanRestoreEnergy(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CanRestoreEnergy component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCanRestoreEnergy(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.EnergyCycle.CanRestoreEnergy() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.BodyContactDamage BodyContactDamageC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.BodyContactDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> BodyContactDamage => BodyContactDamageC.Value;

		public bool TryGetBodyContactDamage(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.BodyContactDamage component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddBodyContactDamage()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.BodyContactDamage() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddBodyContactDamage(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.BodyContactDamage() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactDamage AreaContactDamageC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AreaContactDamage => AreaContactDamageC.Value;

		public bool TryGetAreaContactDamage(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactDamage component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAreaContactDamage()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactDamage() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAreaContactDamage(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactDamage() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactRadius AreaContactRadiusC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactRadius>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AreaContactRadius => AreaContactRadiusC.Value;

		public bool TryGetAreaContactRadius(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactRadius component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAreaContactRadius()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactRadius() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAreaContactRadius(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ContactTakeDamage.AreaContactRadius() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackRequest StartAttackRequestC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackRequest>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackRequest => StartAttackRequestC.Value;

		public bool TryGetStartAttackRequest(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackRequest component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddStartAttackRequest()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackRequest() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddStartAttackRequest(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackRequest() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackEvent StartAttackEventC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent StartAttackEvent => StartAttackEventC.Value;

		public bool TryGetStartAttackEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddStartAttackEvent()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddStartAttackEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.StartAttackEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.CanStartAttack CanStartAttackC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.CanStartAttack>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanStartAttack => CanStartAttackC.Value;

		public bool TryGetCanStartAttack(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.CanStartAttack component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCanStartAttack(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.CanStartAttack() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.EndAttackEvent EndAttackEventC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.EndAttackEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent EndAttackEvent => EndAttackEventC.Value;

		public bool TryGetEndAttackEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.EndAttackEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddEndAttackEvent()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.EndAttackEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddEndAttackEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.EndAttackEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessInitialTime AttackProcessInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackProcessInitialTime => AttackProcessInitialTimeC.Value;

		public bool TryGetAttackProcessInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackProcessInitialTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackProcessInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessCurrentTime AttackProcessCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackProcessCurrentTime => AttackProcessCurrentTimeC.Value;

		public bool TryGetAttackProcessCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackProcessCurrentTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackProcessCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackProcessCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackProcess InAttackProcessC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackProcess>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InAttackProcess => InAttackProcessC.Value;

		public bool TryGetInAttackProcess(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackProcess component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInAttackProcess()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackProcess() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInAttackProcess(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackProcess() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayTime AttackDelayTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackDelayTime => AttackDelayTimeC.Value;

		public bool TryGetAttackDelayTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackDelayTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackDelayTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayEndEvent AttackDelayEndEventC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayEndEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackDelayEndEvent => AttackDelayEndEventC.Value;

		public bool TryGetAttackDelayEndEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayEndEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackDelayEndEvent()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayEndEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackDelayEndEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackDelayEndEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InstantAttackDamage InstantAttackDamageC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InstantAttackDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> InstantAttackDamage => InstantAttackDamageC.Value;

		public bool TryGetInstantAttackDamage(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InstantAttackDamage component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInstantAttackDamage()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InstantAttackDamage() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInstantAttackDamage(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InstantAttackDamage() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.ShootPoint ShootPointC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.ShootPoint>();

		public UnityEngine.Transform ShootPoint => ShootPointC.Value;

		public bool TryGetShootPoint(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.ShootPoint component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddShootPoint(UnityEngine.Transform value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.ShootPoint() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.MustCancelAttack MustCancelAttackC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.MustCancelAttack>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition MustCancelAttack => MustCancelAttackC.Value;

		public bool TryGetMustCancelAttack(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.MustCancelAttack component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddMustCancelAttack(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.MustCancelAttack() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCanceledEvent AttackCanceledEventC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCanceledEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent AttackCanceledEvent => AttackCanceledEventC.Value;

		public bool TryGetAttackCanceledEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCanceledEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackCanceledEvent()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCanceledEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackCanceledEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCanceledEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownInitialTime AttackCooldownInitialTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownInitialTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackCooldownInitialTime => AttackCooldownInitialTimeC.Value;

		public bool TryGetAttackCooldownInitialTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownInitialTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackCooldownInitialTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownInitialTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackCooldownInitialTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownInitialTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownCurrentTime AttackCooldownCurrentTimeC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownCurrentTime>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> AttackCooldownCurrentTime => AttackCooldownCurrentTimeC.Value;

		public bool TryGetAttackCooldownCurrentTime(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownCurrentTime component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackCooldownCurrentTime()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownCurrentTime() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddAttackCooldownCurrentTime(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.AttackCooldownCurrentTime() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackCooldown InAttackCooldownC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackCooldown>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> InAttackCooldown => InAttackCooldownC.Value;

		public bool TryGetInAttackCooldown(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackCooldown component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInAttackCooldown()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackCooldown() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddInAttackCooldown(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.InAttackCooldown() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.IsAttackKeyPressed IsAttackKeyPressedC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.IsAttackKeyPressed>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> IsAttackKeyPressed => IsAttackKeyPressedC.Value;

		public bool TryGetIsAttackKeyPressed(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.IsAttackKeyPressed component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsAttackKeyPressed()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.IsAttackKeyPressed() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddIsAttackKeyPressed(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<System.Boolean> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.Attack.IsAttackKeyPressed() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageRequest TakeDamageRequestC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageRequest>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> TakeDamageRequest => TakeDamageRequestC.Value;

		public bool TryGetTakeDamageRequest(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageRequest component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTakeDamageRequest()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageRequest() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTakeDamageRequest(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageRequest() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageEvent TakeDamageEventC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageEvent>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> TakeDamageEvent => TakeDamageEventC.Value;

		public bool TryGetTakeDamageEvent(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageEvent component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTakeDamageEvent()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageEvent() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTakeDamageEvent(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveEvent<System.Single> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.TakeDamageEvent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.CanApplyDamage CanApplyDamageC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.CanApplyDamage>();

		public Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition CanApplyDamage => CanApplyDamageC.Value;

		public bool TryGetCanApplyDamage(out Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.CanApplyDamage component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCanApplyDamage(Assets._Project.Develop.Runtime.Utilities.Conditions.ICompositCondition value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.ApplyDamage.CanApplyDamage() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.CurrentTarget CurrentTargetC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.CurrentTarget>();

		public Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> CurrentTarget => CurrentTargetC.Value;

		public bool TryGetCurrentTarget(out Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.CurrentTarget component);
			if(result)
				value = component.Value;
			else
				value = default(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity>);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCurrentTarget()
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.CurrentTarget() {Value = new Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity>() }); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCurrentTarget(Assets._Project.Develop.Runtime.Utilities.Reactive.ReactiveVariable<Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity> value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Features.AI.CurrentTarget() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Common.RigidbodyComponent RigidbodyC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Common.RigidbodyComponent>();

		public UnityEngine.Rigidbody Rigidbody => RigidbodyC.Value;

		public bool TryGetRigidbody(out UnityEngine.Rigidbody value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Common.RigidbodyComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Rigidbody);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddRigidbody(UnityEngine.Rigidbody value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Common.RigidbodyComponent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Common.CharacterControllerComponent CharacterControllerC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Common.CharacterControllerComponent>();

		public UnityEngine.CharacterController CharacterController => CharacterControllerC.Value;

		public bool TryGetCharacterController(out UnityEngine.CharacterController value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Common.CharacterControllerComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.CharacterController);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddCharacterController(UnityEngine.CharacterController value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Common.CharacterControllerComponent() {Value = value}); 
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.Common.TransformComponent TransformC => GetComponent<Assets._Project.Develop.Runtime.GameplayMechanics.Common.TransformComponent>();

		public UnityEngine.Transform Transform => TransformC.Value;

		public bool TryGetTransform(out UnityEngine.Transform value)
		{
			bool result = TryGetComponent(out Assets._Project.Develop.Runtime.GameplayMechanics.Common.TransformComponent component);
			if(result)
				value = component.Value;
			else
				value = default(UnityEngine.Transform);
			return result;
		}

		public Assets._Project.Develop.Runtime.GameplayMechanics.EntitiesCore.Entity AddTransform(UnityEngine.Transform value)
		{
		return AddComponent(new Assets._Project.Develop.Runtime.GameplayMechanics.Common.TransformComponent() {Value = value}); 
		}

	}
}
