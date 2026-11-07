using Buoyancy;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfCourse
{
	[Token(Token = "0x2001202")]
	public class HighDiverShooter2 : ShooterBase
	{
		[Token(Token = "0x2001203")]
		public enum DiverState
		{
			[Token(Token = "0x4006111")]
			PreDive = 0,
			[Token(Token = "0x4006112")]
			Diving = 1,
			[Token(Token = "0x4006113")]
			Bounce = 2,
			[Token(Token = "0x4006114")]
			OnGround = 3
		}

		[Token(Token = "0x40060FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float velocityPreDive;

		[Token(Token = "0x40060FD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float velocityPostDive;

		[Token(Token = "0x40060FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float spinPreDive;

		[Token(Token = "0x40060FF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float spinPostDive;

		[Token(Token = "0x4006100")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float pitchPreDive;

		[Token(Token = "0x4006101")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pitchPostDive;

		[Token(Token = "0x4006102")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float maxForceTowardTarget;

		[Token(Token = "0x4006103")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform goTowardTargetOnDive;

		[Token(Token = "0x4006104")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform bounceTowardTarget;

		[Token(Token = "0x4006105")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Collider diveTrigger;

		[Token(Token = "0x4006106")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x4006107")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject buoyancyContainer;

		[Token(Token = "0x4006108")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SphereCastGroundCheck groundCheck;

		[Token(Token = "0x4006109")]
		[FieldOffset(Offset = "0x70")]
		private DiverState diverState;

		[Token(Token = "0x400610A")]
		[FieldOffset(Offset = "0x78")]
		private IBuoyant buoy;

		[Token(Token = "0x400610B")]
		[FieldOffset(Offset = "0x80")]
		private Rigidbody hips;

		[Token(Token = "0x400610C")]
		[FieldOffset(Offset = "0x88")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x400610D")]
		[FieldOffset(Offset = "0x90")]
		private bool didDive;

		[Token(Token = "0x400610E")]
		[FieldOffset(Offset = "0x91")]
		private bool isCollapsed;

		[Token(Token = "0x400610F")]
		[FieldOffset(Offset = "0x92")]
		private bool hasLeftWater;

		[Token(Token = "0x1700091B")]
		private float currentMaxVelocity
		{
			[Token(Token = "0x60052C3")]
			[Address(RVA = "0x14C7B78", Offset = "0x14C7B78", VA = "0x14C7B78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700091C")]
		private float currentSpin
		{
			[Token(Token = "0x60052C4")]
			[Address(RVA = "0x14C7B94", Offset = "0x14C7B94", VA = "0x14C7B94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700091D")]
		private float currentPitch
		{
			[Token(Token = "0x60052C5")]
			[Address(RVA = "0x14C7BB0", Offset = "0x14C7BB0", VA = "0x14C7BB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x14C7BCC", Offset = "0x14C7BCC", VA = "0x14C7BCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60052C7")]
		[Address(RVA = "0x14C7ED4", Offset = "0x14C7ED4", VA = "0x14C7ED4")]
		public bool CanShoot()
		{
			return default;
		}

		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x14C8058", Offset = "0x14C8058", VA = "0x14C8058")]
		public bool IsGrounded()
		{
			return default;
		}

		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x14C80FC", Offset = "0x14C80FC", VA = "0x14C80FC")]
		public bool CanRotateInAir()
		{
			return default;
		}

		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x14C8104", Offset = "0x14C8104", VA = "0x14C8104", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x14C8510", Offset = "0x14C8510", VA = "0x14C8510")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x14C87A4", Offset = "0x14C87A4", VA = "0x14C87A4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x14C8448", Offset = "0x14C8448", VA = "0x14C8448")]
		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}

		[Token(Token = "0x60052CE")]
		[Address(RVA = "0x14C8874", Offset = "0x14C8874", VA = "0x14C8874")]
		public HighDiverShooter2()
		{
		}

		[Token(Token = "0x60052CF")]
		[Address(RVA = "0x14C88A4", Offset = "0x14C88A4", VA = "0x14C88A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70C08", Offset = "0x70C08")]
		private void _003CAwake_003Eb__27_0()
		{
		}
	}
}
