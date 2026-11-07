using Buoyancy;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfCourse
{
	[Token(Token = "0x2001201")]
	public class HighDiverShooter : ShooterBase
	{
		[Token(Token = "0x40060E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float velocityPreDive;

		[Token(Token = "0x40060EA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float velocityPostDive;

		[Token(Token = "0x40060EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float spinPreDive;

		[Token(Token = "0x40060EC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float spinPostDive;

		[Token(Token = "0x40060ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float pitchPreDive;

		[Token(Token = "0x40060EE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pitchPostDive;

		[Token(Token = "0x40060EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float maxForceTowardTarget;

		[Token(Token = "0x40060F0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform goTowardTargetOnDive;

		[Token(Token = "0x40060F1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Collider diveTrigger;

		[Token(Token = "0x40060F2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x40060F3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuoyancyTarget buoyancyTarget;

		[Token(Token = "0x40060F4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SphereCastGroundCheck groundCheck;

		[Token(Token = "0x40060F5")]
		[FieldOffset(Offset = "0x68")]
		public bool debugAddTorque;

		[Token(Token = "0x40060F6")]
		[FieldOffset(Offset = "0x70")]
		private Rigidbody hips;

		[Token(Token = "0x40060F7")]
		[FieldOffset(Offset = "0x78")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x40060F8")]
		[FieldOffset(Offset = "0x80")]
		private bool didDive;

		[Token(Token = "0x40060F9")]
		[FieldOffset(Offset = "0x81")]
		private bool isCollapsed;

		[Token(Token = "0x40060FA")]
		[FieldOffset(Offset = "0x82")]
		private bool hasLeftWater;

		[Token(Token = "0x40060FB")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 lastboost;

		[Token(Token = "0x17000918")]
		private float currentMaxVelocity
		{
			[Token(Token = "0x60052B8")]
			[Address(RVA = "0x14C7238", Offset = "0x14C7238", VA = "0x14C7238")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000919")]
		private float currentSpin
		{
			[Token(Token = "0x60052B9")]
			[Address(RVA = "0x14C7254", Offset = "0x14C7254", VA = "0x14C7254")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700091A")]
		private float currentPitch
		{
			[Token(Token = "0x60052BA")]
			[Address(RVA = "0x14C7270", Offset = "0x14C7270", VA = "0x14C7270")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60052BB")]
		[Address(RVA = "0x14C728C", Offset = "0x14C728C", VA = "0x14C728C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60052BC")]
		[Address(RVA = "0x14C7410", Offset = "0x14C7410", VA = "0x14C7410")]
		public bool CanShoot()
		{
			return default;
		}

		[Token(Token = "0x60052BD")]
		[Address(RVA = "0x14C74D8", Offset = "0x14C74D8", VA = "0x14C74D8", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x60052BE")]
		[Address(RVA = "0x14C7910", Offset = "0x14C7910", VA = "0x14C7910")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60052BF")]
		[Address(RVA = "0x14C7A44", Offset = "0x14C7A44", VA = "0x14C7A44")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60052C0")]
		[Address(RVA = "0x14C7848", Offset = "0x14C7848", VA = "0x14C7848")]
		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}

		[Token(Token = "0x60052C1")]
		[Address(RVA = "0x14C7B10", Offset = "0x14C7B10", VA = "0x14C7B10")]
		public HighDiverShooter()
		{
		}

		[Token(Token = "0x60052C2")]
		[Address(RVA = "0x14C7B6C", Offset = "0x14C7B6C", VA = "0x14C7B6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70BF8", Offset = "0x70BF8")]
		private void _003CAwake_003Eb__24_0()
		{
		}
	}
}
