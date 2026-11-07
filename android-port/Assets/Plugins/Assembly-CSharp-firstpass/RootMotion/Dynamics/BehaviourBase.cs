using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x20000F5")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x20000F6")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x20000F7")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x20000F8")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x20000F9")]
		public struct PuppetEvent
		{
			[Token(Token = "0x4000554")]
			[FieldOffset(Offset = "0x0")]
			public string switchToBehaviour;

			[Token(Token = "0x4000555")]
			[FieldOffset(Offset = "0x8")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000556")]
			[FieldOffset(Offset = "0x10")]
			public UnityEvent unityEvent;

			[Token(Token = "0x4000557")]
			private const string empty = "";

			[Token(Token = "0x170000D8")]
			public bool switchBehaviour
			{
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x13380F0", Offset = "0x13380F0", VA = "0x13380F0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1338188", Offset = "0x1338188", VA = "0x1338188")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000558")]
			[FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x4000559")]
			[FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x400055A")]
			[FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x400055B")]
			[FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400055C")]
			private const string empty = "";

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1337348", Offset = "0x1337348", VA = "0x1337348")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1337424", Offset = "0x1337424", VA = "0x1337424")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1337544", Offset = "0x1337544", VA = "0x1337544")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1337620", Offset = "0x1337620", VA = "0x1337620")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0xF0")]
		public bool deactivated;

		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3546C", Offset = "0x3546C")]
		private bool forceActive__BackingField;

		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x170000D7")]
		public bool forceActive
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x12FB840", Offset = "0x12FB840", VA = "0x12FB840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38324", Offset = "0x38324")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x12FB848", Offset = "0x12FB848", VA = "0x12FB848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38334", Offset = "0x38334")]
			protected set
			{
			}
		}

		[Token(Token = "0x600062B")]
		public abstract void OnReactivate();

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x12FB7C4", Offset = "0x12FB7C4", VA = "0x12FB7C4", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x12FB7C8", Offset = "0x12FB7C8", VA = "0x12FB7C8", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x12FB7CC", Offset = "0x12FB7CC", VA = "0x12FB7CC", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x12FB7D0", Offset = "0x12FB7D0", VA = "0x12FB7D0", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x12FB7D4", Offset = "0x12FB7D4", VA = "0x12FB7D4", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x12FB7D8", Offset = "0x12FB7D8", VA = "0x12FB7D8", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x12FB7DC", Offset = "0x12FB7DC", VA = "0x12FB7DC", Slot = "11")]
		public virtual void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x12FB7E0", Offset = "0x12FB7E0", VA = "0x12FB7E0", Slot = "12")]
		public virtual void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x12FB7E4", Offset = "0x12FB7E4", VA = "0x12FB7E4", Slot = "13")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x12FB7F8", Offset = "0x12FB7F8", VA = "0x12FB7F8", Slot = "14")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x12FB80C", Offset = "0x12FB80C", VA = "0x12FB80C", Slot = "15")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x12FB810", Offset = "0x12FB810", VA = "0x12FB810", Slot = "16")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x12FB814", Offset = "0x12FB814", VA = "0x12FB814", Slot = "17")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x12FB818", Offset = "0x12FB818", VA = "0x12FB818", Slot = "18")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x12FB81C", Offset = "0x12FB81C", VA = "0x12FB81C", Slot = "19")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x12FB820", Offset = "0x12FB820", VA = "0x12FB820", Slot = "20")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x12FB824", Offset = "0x12FB824", VA = "0x12FB824", Slot = "21")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x12FB828", Offset = "0x12FB828", VA = "0x12FB828", Slot = "22")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x12FB82C", Offset = "0x12FB82C", VA = "0x12FB82C", Slot = "23")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x12FB830", Offset = "0x12FB830", VA = "0x12FB830", Slot = "24")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x12FB834", Offset = "0x12FB834", VA = "0x12FB834", Slot = "25")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x12FB838", Offset = "0x12FB838", VA = "0x12FB838", Slot = "26")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x12FB83C", Offset = "0x12FB83C", VA = "0x12FB83C", Slot = "27")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x12FB850", Offset = "0x12FB850", VA = "0x12FB850")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x12FB8B0", Offset = "0x12FB8B0", VA = "0x12FB8B0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x12FB920", Offset = "0x12FB920", VA = "0x12FB920")]
		public void OnRead()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x12FB990", Offset = "0x12FB990", VA = "0x12FB990")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x12FBA00", Offset = "0x12FBA00", VA = "0x12FBA00")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x12FBA8C", Offset = "0x12FBA8C", VA = "0x12FBA8C")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x12FBB30", Offset = "0x12FBB30", VA = "0x12FBB30")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x12FBBD4", Offset = "0x12FBBD4", VA = "0x12FBBD4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x12FBBE8", Offset = "0x12FBBE8", VA = "0x12FBBE8")]
		public void Activate()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x12FBD0C", Offset = "0x12FBD0C", VA = "0x12FBD0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x12FBD68", Offset = "0x12FBD68", VA = "0x12FBD68")]
		public void FixedUpdateB()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x12FBE24", Offset = "0x12FBE24", VA = "0x12FBE24")]
		public void UpdateB()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x12FBEE0", Offset = "0x12FBEE0", VA = "0x12FBEE0")]
		public void LateUpdateB()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x12FBF9C", Offset = "0x12FBF9C", VA = "0x12FBF9C", Slot = "28")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x12FBFE4", Offset = "0x12FBFE4", VA = "0x12FBFE4")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x12FC118", Offset = "0x12FC118", VA = "0x12FC118")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x12FC24C", Offset = "0x12FC24C", VA = "0x12FC24C")]
		protected void RemovePropMuscles()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x12FC3A4", Offset = "0x12FC3A4", VA = "0x12FC3A4", Slot = "29")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x12FC30C", Offset = "0x12FC30C", VA = "0x12FC30C")]
		protected bool ContainsRemovablePropMuscle()
		{
			return default;
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x12FC5A8", Offset = "0x12FC5A8", VA = "0x12FC5A8")]
		protected BehaviourBase()
		{
		}
	}
}
