using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x20000FD")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public enum State
		{
			[Token(Token = "0x40005A9")]
			Puppet = 0,
			[Token(Token = "0x40005AA")]
			Unpinned = 1,
			[Token(Token = "0x40005AB")]
			GetUp = 2
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public enum NormalMode
		{
			[Token(Token = "0x40005AD")]
			Active = 0,
			[Token(Token = "0x40005AE")]
			Unmapped = 1,
			[Token(Token = "0x40005AF")]
			Kinematic = 2
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class MasterProps
		{
			[Token(Token = "0x40005B0")]
			[FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x40005B1")]
			[FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x40005B2")]
			[FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x40005B3")]
			[FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1338B00", Offset = "0x1338B00", VA = "0x1338B00")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000101")]
		public struct MuscleProps
		{
			[Token(Token = "0x40005B4")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35514", Offset = "0x35514")]
			public float unpinParents;

			[Token(Token = "0x40005B5")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3552C", Offset = "0x3552C")]
			public float unpinChildren;

			[Token(Token = "0x40005B6")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35544", Offset = "0x35544")]
			public float unpinGroup;

			[Token(Token = "0x40005B7")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3555C", Offset = "0x3555C")]
			public float minMappingWeight;

			[Token(Token = "0x40005B8")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35574", Offset = "0x35574")]
			public float maxMappingWeight;

			[Token(Token = "0x40005B9")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3558C", Offset = "0x3558C")]
			public float minPinWeight;

			[Token(Token = "0x40005BA")]
			[FieldOffset(Offset = "0x18")]
			public bool disableColliders;

			[Token(Token = "0x40005BB")]
			[FieldOffset(Offset = "0x1C")]
			public float regainPinSpeed;

			[Token(Token = "0x40005BC")]
			[FieldOffset(Offset = "0x20")]
			public float collisionResistance;

			[Token(Token = "0x40005BD")]
			[FieldOffset(Offset = "0x24")]
			public float knockOutDistance;

			[Token(Token = "0x40005BE")]
			[FieldOffset(Offset = "0x28")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x40005BF")]
			[FieldOffset(Offset = "0x30")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x40005C0")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40005C1")]
			[FieldOffset(Offset = "0x8")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40005C2")]
			[FieldOffset(Offset = "0x10")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x2000103")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x40005C3")]
			[FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x40005C4")]
			[FieldOffset(Offset = "0x4")]
			public float multiplier;

			[Token(Token = "0x40005C5")]
			[FieldOffset(Offset = "0x8")]
			public float collisionThreshold;
		}

		[Token(Token = "0x2000104")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0xF8")]
		public MasterProps masterProps;

		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x104")]
		public LayerMask collisionLayers;

		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x108")]
		public float collisionThreshold;

		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x118")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3547C", Offset = "0x3547C")]
		public int maxCollisions;

		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35494", Offset = "0x35494")]
		public float regainPinSpeed;

		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x128")]
		public float boostFalloff;

		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x130")]
		public MuscleProps defaults;

		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x168")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x354B4", Offset = "0x354B4")]
		public float knockOutDistance;

		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x354D4", Offset = "0x354D4")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x178")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x354EC", Offset = "0x354EC")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x180")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x181")]
		public bool dropProps;

		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x182")]
		public bool canGetUp;

		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x184")]
		public float getUpDelay;

		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x188")]
		public float blendToAnimationTime;

		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x18C")]
		public float maxGetUpVelocity;

		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x190")]
		public float minGetUpDuration;

		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x194")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x198")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x19C")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x1A0")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x1AC")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x1B8")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x1D0")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x1E8")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x200")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x218")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x230")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x248")]
		public CollisionDelegate OnCollision;

		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x250")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35504", Offset = "0x35504")]
		private State state__BackingField;

		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x25C")]
		public bool canMoveTarget;

		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x260")]
		private float unpinnedTimer;

		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x264")]
		private float getUpTimer;

		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x268")]
		private Vector3 hipsForward;

		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x274")]
		private Vector3 hipsUp;

		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x280")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x284")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x288")]
		private bool getUpTargetFixed;

		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x28C")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x290")]
		private int collisions;

		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x294")]
		private bool eventsEnabled;

		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x298")]
		private float lastKnockOutDistance;

		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x29C")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x2A0")]
		private bool getupDisabled;

		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x2A1")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x2A2")]
		private bool hasBoosted;

		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x2A8")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x2B0")]
		private Vector3 getUpPosition;

		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x2BC")]
		private bool dropPropFlag;

		[Token(Token = "0x170000DB")]
		public State state
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x12FCE6C", Offset = "0x12FCE6C", VA = "0x12FCE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38474", Offset = "0x38474")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x12FCE74", Offset = "0x12FCE74", VA = "0x12FCE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38484", Offset = "0x38484")]
			private set
			{
			}
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x12FCDDC", Offset = "0x12FCDDC", VA = "0x12FCDDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38404", Offset = "0x38404")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x12FCE24", Offset = "0x12FCE24", VA = "0x12FCE24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3843C", Offset = "0x3843C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x12FCE7C", Offset = "0x12FCE7C", VA = "0x12FCE7C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x12FD160", Offset = "0x12FD160", VA = "0x12FD160")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x12FD1D4", Offset = "0x12FD1D4", VA = "0x12FD1D4", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x12FD26C", Offset = "0x12FD26C", VA = "0x12FD26C", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x12FD4B4", Offset = "0x12FD4B4", VA = "0x12FD4B4", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x12FDC60", Offset = "0x12FDC60", VA = "0x12FDC60", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x12FDD10", Offset = "0x12FDD10", VA = "0x12FDD10", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x12FDD18", Offset = "0x12FDD18", VA = "0x12FDD18", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x12FDD9C", Offset = "0x12FDD9C", VA = "0x12FDD9C", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x12FDDA8", Offset = "0x12FDDA8", VA = "0x12FDDA8", Slot = "18")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x12FE514", Offset = "0x12FE514", VA = "0x12FE514", Slot = "20")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x12FE7F4", Offset = "0x12FE7F4", VA = "0x12FE7F4")]
		private bool SetKinematic()
		{
			return default;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x12FE8E0", Offset = "0x12FE8E0", VA = "0x12FE8E0", Slot = "23")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x12FE6A0", Offset = "0x12FE6A0", VA = "0x12FE6A0")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x12FEC18", Offset = "0x12FEC18", VA = "0x12FEC18", Slot = "13")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x12FEC60", Offset = "0x12FEC60", VA = "0x12FEC60", Slot = "14")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x12FEBDC", Offset = "0x12FEBDC", VA = "0x12FEBDC")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x12FECA0", Offset = "0x12FECA0", VA = "0x12FECA0")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x12FECDC", Offset = "0x12FECDC", VA = "0x12FECDC", Slot = "29")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x12FECF4", Offset = "0x12FECF4", VA = "0x12FECF4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x12FEEF0", Offset = "0x12FEEF0", VA = "0x12FEEF0")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x12FEF80", Offset = "0x12FEF80", VA = "0x12FEF80")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x12FF098", Offset = "0x12FF098", VA = "0x12FF098")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x12FF258", Offset = "0x12FF258", VA = "0x12FF258")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x12FEFC4", Offset = "0x12FEFC4", VA = "0x12FEFC4")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x12FF2D0", Offset = "0x12FF2D0", VA = "0x12FF2D0")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x12FF374", Offset = "0x12FF374", VA = "0x12FF374")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x12FF030", Offset = "0x12FF030", VA = "0x12FF030")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x12FF3E4", Offset = "0x12FF3E4", VA = "0x12FF3E4")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x12FF488", Offset = "0x12FF488", VA = "0x12FF488")]
		public void Unpin()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x12FF514", Offset = "0x12FF514", VA = "0x12FF514", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x12FF6EC", Offset = "0x12FF6EC", VA = "0x12FF6EC", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x12FFAF8", Offset = "0x12FFAF8", VA = "0x12FFAF8")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x12FF5F0", Offset = "0x12FF5F0", VA = "0x12FF5F0")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x12FFDE0", Offset = "0x12FFDE0", VA = "0x12FFDE0")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x12FFC70", Offset = "0x12FFC70", VA = "0x12FFC70")]
		private bool Activate(Collision collision, float impulse)
		{
			return default;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x12FFFC4", Offset = "0x12FFFC4", VA = "0x12FFFC4")]
		public bool IsProne()
		{
			return default;
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x12FF1B4", Offset = "0x12FF1B4", VA = "0x12FF1B4")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x12FFD04", Offset = "0x12FFD04", VA = "0x12FFD04")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1300084", Offset = "0x1300084", VA = "0x1300084")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x12FE44C", Offset = "0x12FE44C", VA = "0x12FE44C")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default;
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x12FD564", Offset = "0x12FD564", VA = "0x12FD564")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1300170", Offset = "0x1300170", VA = "0x1300170")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x12FCF48", Offset = "0x12FCF48", VA = "0x12FCF48")]
		public void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1300200", Offset = "0x1300200", VA = "0x1300200", Slot = "11")]
		public override void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1300208", Offset = "0x1300208", VA = "0x1300208", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x13002A0", Offset = "0x13002A0", VA = "0x13002A0")]
		public BehaviourPuppet()
		{
		}
	}
}
