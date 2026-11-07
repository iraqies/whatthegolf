using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200146D")]
	public class ToyCanonShooter : GolfBallShooterBase
	{
		[Token(Token = "0x200146E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4916C", Offset = "0x4916C")]
		private sealed class _003CDeactivateAllCollidersOnShoot_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4007016")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4007017")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4007018")]
			[FieldOffset(Offset = "0x20")]
			public ToyCanonShooter _003C_003E4__this;

			[Token(Token = "0x17000AED")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6006038")]
				[Address(RVA = "0x1869B7C", Offset = "0x1869B7C", VA = "0x1869B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000AEE")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600603A")]
				[Address(RVA = "0x1869BC4", Offset = "0x1869BC4", VA = "0x1869BC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6006035")]
			[Address(RVA = "0x1869A80", Offset = "0x1869A80", VA = "0x1869A80")]
			[DebuggerHidden]
			public _003CDeactivateAllCollidersOnShoot_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006036")]
			[Address(RVA = "0x1869AAC", Offset = "0x1869AAC", VA = "0x1869AAC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6006037")]
			[Address(RVA = "0x1869AB0", Offset = "0x1869AB0", VA = "0x1869AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6006038")]
			[Address(RVA = "0x1869B7C", Offset = "0x1869B7C", VA = "0x1869B7C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6006039")]
			[Address(RVA = "0x1869B84", Offset = "0x1869B84", VA = "0x1869B84", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600603A")]
			[Address(RVA = "0x1869BC4", Offset = "0x1869BC4", VA = "0x1869BC4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4007001")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Transform controllerShootPosition;

		[Token(Token = "0x4007002")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public ParticleSystem insideCanonParticles;

		[Token(Token = "0x4007003")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public ParticleSystem shootParticles;

		[Token(Token = "0x4007004")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4007005")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4007006")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4007007")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4007008")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4007009")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x400700A")]
		[FieldOffset(Offset = "0x95")]
		public bool lookInAimDirection;

		[Token(Token = "0x400700B")]
		[FieldOffset(Offset = "0x96")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x400700C")]
		[FieldOffset(Offset = "0x98")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x400700D")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x400700E")]
		[FieldOffset(Offset = "0x9D")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x400700F")]
		[FieldOffset(Offset = "0x9E")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4007010")]
		[FieldOffset(Offset = "0xA0")]
		private GolfBallController canonController;

		[Token(Token = "0x4007011")]
		[FieldOffset(Offset = "0xA8")]
		private Animator canonAnimator;

		[Token(Token = "0x4007012")]
		[FieldOffset(Offset = "0xB0")]
		private List<Collider> canonColliders;

		[Token(Token = "0x4007013")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject controllerGO;

		[Token(Token = "0x4007014")]
		[FieldOffset(Offset = "0xC0")]
		private Rigidbody rigidBodyControllerToShoot;

		[Token(Token = "0x4007015")]
		[FieldOffset(Offset = "0xC8")]
		private GolfBallController golfBallControllerToShoot;

		[Token(Token = "0x6006029")]
		[Address(RVA = "0x171FDE8", Offset = "0x171FDE8", VA = "0x171FDE8", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600602A")]
		[Address(RVA = "0x171FDF0", Offset = "0x171FDF0", VA = "0x171FDF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600602B")]
		[Address(RVA = "0x171FEEC", Offset = "0x171FEEC", VA = "0x171FEEC", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x600602C")]
		[Address(RVA = "0x171FEF4", Offset = "0x171FEF4", VA = "0x171FEF4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600602D")]
		[Address(RVA = "0x1720070", Offset = "0x1720070", VA = "0x1720070")]
		private void PutControllerInsideCanon(GameObject controllerInCanon)
		{
		}

		[Token(Token = "0x600602E")]
		[Address(RVA = "0x1720290", Offset = "0x1720290", VA = "0x1720290")]
		private void EnableControllerInsideTheCanon()
		{
		}

		[Token(Token = "0x600602F")]
		[Address(RVA = "0x1720368", Offset = "0x1720368", VA = "0x1720368", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6006030")]
		[Address(RVA = "0x17205B8", Offset = "0x17205B8", VA = "0x17205B8", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6006031")]
		[Address(RVA = "0x17207D0", Offset = "0x17207D0", VA = "0x17207D0", Slot = "14")]
		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6006032")]
		[Address(RVA = "0x17209E4", Offset = "0x17209E4", VA = "0x17209E4")]
		private IEnumerator DeactivateAllCollidersOnShoot()
		{
			return null;
		}

		[Token(Token = "0x6006033")]
		[Address(RVA = "0x1720A58", Offset = "0x1720A58", VA = "0x1720A58")]
		private void EnableColliders(bool enable)
		{
		}

		[Token(Token = "0x6006034")]
		[Address(RVA = "0x1720AFC", Offset = "0x1720AFC", VA = "0x1720AFC")]
		public ToyCanonShooter()
		{
		}
	}
}
