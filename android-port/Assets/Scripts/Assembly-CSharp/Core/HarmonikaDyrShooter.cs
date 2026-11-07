using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001457")]
	public class HarmonikaDyrShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006EE1")]
		[FieldOffset(Offset = "0x60")]
		public Rigidbody frontPart;

		[Token(Token = "0x4006EE2")]
		[FieldOffset(Offset = "0x68")]
		public CapsuleCollider frontCapsuleCollider;

		[Token(Token = "0x4006EE3")]
		[FieldOffset(Offset = "0x70")]
		public Rigidbody backPart;

		[Token(Token = "0x4006EE4")]
		[FieldOffset(Offset = "0x78")]
		public CapsuleCollider backCapsuleCollider;

		[Token(Token = "0x4006EE5")]
		[FieldOffset(Offset = "0x80")]
		public Rigidbody midPart;

		[Token(Token = "0x4006EE6")]
		[FieldOffset(Offset = "0x88")]
		public List<Transform> firstSegmentParts;

		[Token(Token = "0x4006EE7")]
		[FieldOffset(Offset = "0x90")]
		public List<Transform> lastSegmentParts;

		[Token(Token = "0x4006EE8")]
		[FieldOffset(Offset = "0x98")]
		public LayerMask groundLayer;

		[Token(Token = "0x4006EE9")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float walkSpeed;

		[Token(Token = "0x4006EEA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float retractSpeed;

		[Token(Token = "0x4006EEB")]
		[FieldOffset(Offset = "0xA4")]
		public float maxExtendDistance;

		[Token(Token = "0x4006EEC")]
		[FieldOffset(Offset = "0xA8")]
		public float minExtendDistance;

		[Token(Token = "0x4006EED")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float raycastDist;

		[Token(Token = "0x4006EEE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<LaserSentryTarget> laserTargets;

		[Token(Token = "0x4006EEF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RandomAudioClips explodeClips;

		[Token(Token = "0x4006EF0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool restartOnOutOfBounds;

		[Token(Token = "0x4006EF1")]
		[FieldOffset(Offset = "0xC8")]
		public GolfBallController ballController;

		[Token(Token = "0x4006EF2")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4AC", Offset = "0x5C4AC")]
		private bool IsRetracting__BackingField;

		[Token(Token = "0x4006EF3")]
		[FieldOffset(Offset = "0xD1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C4BC", Offset = "0x5C4BC")]
		private bool IsPlacing__BackingField;

		[Token(Token = "0x4006EF4")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 currentBoost;

		[Token(Token = "0x4006EF5")]
		[FieldOffset(Offset = "0xE0")]
		private bool isAiming;

		[Token(Token = "0x4006EF6")]
		[FieldOffset(Offset = "0xE1")]
		private bool isGrounded;

		[Token(Token = "0x4006EF7")]
		[FieldOffset(Offset = "0xE4")]
		private float shotDisableTime;

		[Token(Token = "0x4006EF8")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 lastShootBoost;

		[Token(Token = "0x4006EF9")]
		[FieldOffset(Offset = "0xF8")]
		private Joint[] joints;

		[Token(Token = "0x4006EFA")]
		[FieldOffset(Offset = "0x100")]
		private bool hasShot;

		[Token(Token = "0x17000ADF")]
		public bool IsRetracting
		{
			[Token(Token = "0x6005F76")]
			[Address(RVA = "0x14C4E10", Offset = "0x14C4E10", VA = "0x14C4E10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72E14", Offset = "0x72E14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F77")]
			[Address(RVA = "0x14C4E18", Offset = "0x14C4E18", VA = "0x14C4E18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72E24", Offset = "0x72E24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000AE0")]
		public bool IsPlacing
		{
			[Token(Token = "0x6005F78")]
			[Address(RVA = "0x14C4E20", Offset = "0x14C4E20", VA = "0x14C4E20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72E34", Offset = "0x72E34")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F79")]
			[Address(RVA = "0x14C4E28", Offset = "0x14C4E28", VA = "0x14C4E28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72E44", Offset = "0x72E44")]
			private set
			{
			}
		}

		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x14C4E30", Offset = "0x14C4E30", VA = "0x14C4E30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x14C50F0", Offset = "0x14C50F0", VA = "0x14C50F0")]
		private void HarmonikaDyrShooter_OnOutOfBounds(OutOfBoundsTrigger obj)
		{
		}

		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x14C5114", Offset = "0x14C5114", VA = "0x14C5114")]
		private void HandleOnLasered()
		{
		}

		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x14C56D0", Offset = "0x14C56D0", VA = "0x14C56D0")]
		private bool isShot()
		{
			return default;
		}

		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0x14C5700", Offset = "0x14C5700", VA = "0x14C5700", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x14C57B4", Offset = "0x14C57B4", VA = "0x14C57B4", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x14C5820", Offset = "0x14C5820", VA = "0x14C5820", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F81")]
		[Address(RVA = "0x14C5878", Offset = "0x14C5878", VA = "0x14C5878")]
		private void Update()
		{
		}

		[Token(Token = "0x6005F82")]
		[Address(RVA = "0x14C5964", Offset = "0x14C5964", VA = "0x14C5964", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x14C64D8", Offset = "0x14C64D8", VA = "0x14C64D8")]
		public HarmonikaDyrShooter()
		{
		}
	}
}
