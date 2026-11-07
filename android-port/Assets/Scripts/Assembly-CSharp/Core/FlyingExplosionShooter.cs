using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200144A")]
	public class FlyingExplosionShooter : GolfBallShooterBase
	{
		[Token(Token = "0x200144B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x490FC", Offset = "0x490FC")]
		private sealed class _003CBoom_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006E5A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006E5B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006E5C")]
			[FieldOffset(Offset = "0x20")]
			public FlyingExplosionShooter _003C_003E4__this;

			[Token(Token = "0x4006E5D")]
			[FieldOffset(Offset = "0x28")]
			public GameObject hitObject;

			[Token(Token = "0x17000ACA")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005F02")]
				[Address(RVA = "0x17A9260", Offset = "0x17A9260", VA = "0x17A9260", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000ACB")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005F04")]
				[Address(RVA = "0x17A92A8", Offset = "0x17A92A8", VA = "0x17A92A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005EFF")]
			[Address(RVA = "0x17A8F60", Offset = "0x17A8F60", VA = "0x17A8F60")]
			[DebuggerHidden]
			public _003CBoom_003Ed__31(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005F00")]
			[Address(RVA = "0x17A8F8C", Offset = "0x17A8F8C", VA = "0x17A8F8C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005F01")]
			[Address(RVA = "0x17A8F90", Offset = "0x17A8F90", VA = "0x17A8F90", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005F02")]
			[Address(RVA = "0x17A9260", Offset = "0x17A9260", VA = "0x17A9260", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005F03")]
			[Address(RVA = "0x17A9268", Offset = "0x17A9268", VA = "0x17A9268", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005F04")]
			[Address(RVA = "0x17A92A8", Offset = "0x17A92A8", VA = "0x17A92A8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006E44")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006E45")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006E46")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float targetHeight;

		[Token(Token = "0x4006E47")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4006E48")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006E49")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ParticleSystem thrusterParticles;

		[Token(Token = "0x4006E4A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[Token(Token = "0x4006E4B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool useGravity;

		[Token(Token = "0x4006E4C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform upOverride;

		[Token(Token = "0x4006E4D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioSource rocketAudioSource;

		[Token(Token = "0x4006E4E")]
		[FieldOffset(Offset = "0x98")]
		private GolfBallController controller;

		[Token(Token = "0x4006E4F")]
		[FieldOffset(Offset = "0xA0")]
		private bool didExplode;

		[Token(Token = "0x4006E50")]
		[FieldOffset(Offset = "0xA8")]
		public GolfBallController ballController;

		[Token(Token = "0x4006E51")]
		[FieldOffset(Offset = "0xB0")]
		private ExplosionBarrel barrel;

		[Token(Token = "0x4006E52")]
		[FieldOffset(Offset = "0xB8")]
		private bool wasBlocked;

		[Token(Token = "0x4006E53")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006E54")]
		[FieldOffset(Offset = "0xC8")]
		private bool isAiming;

		[Token(Token = "0x4006E55")]
		[FieldOffset(Offset = "0xC9")]
		private bool didAim;

		[Token(Token = "0x4006E56")]
		[FieldOffset(Offset = "0xCC")]
		private float firstAimTime;

		[Token(Token = "0x4006E57")]
		[FieldOffset(Offset = "0xD0")]
		private float warmup;

		[Token(Token = "0x4006E58")]
		[FieldOffset(Offset = "0xD4")]
		public bool failLevelOnExplode;

		[Token(Token = "0x4006E59")]
		[FieldOffset(Offset = "0xD8")]
		public Action<GameObject> onExplode;

		[Token(Token = "0x6005EF4")]
		[Address(RVA = "0x146D900", Offset = "0x146D900", VA = "0x146D900", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005EF5")]
		[Address(RVA = "0x146D938", Offset = "0x146D938", VA = "0x146D938")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005EF6")]
		[Address(RVA = "0x146D9F0", Offset = "0x146D9F0", VA = "0x146D9F0", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005EF7")]
		[Address(RVA = "0x146DAF4", Offset = "0x146DAF4", VA = "0x146DAF4", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005EF8")]
		[Address(RVA = "0x146DBF4", Offset = "0x146DBF4", VA = "0x146DBF4", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005EF9")]
		[Address(RVA = "0x146DCDC", Offset = "0x146DCDC", VA = "0x146DCDC")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6005EFA")]
		[Address(RVA = "0x146DDF8", Offset = "0x146DDF8", VA = "0x146DDF8", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005EFB")]
		[Address(RVA = "0x146DFB8", Offset = "0x146DFB8", VA = "0x146DFB8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005EFC")]
		[Address(RVA = "0x146E1B8", Offset = "0x146E1B8", VA = "0x146E1B8", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005EFD")]
		[Address(RVA = "0x146E140", Offset = "0x146E140", VA = "0x146E140")]
		private IEnumerator Boom(GameObject hitObject)
		{
			return null;
		}

		[Token(Token = "0x6005EFE")]
		[Address(RVA = "0x146E570", Offset = "0x146E570", VA = "0x146E570")]
		public FlyingExplosionShooter()
		{
		}
	}
}
