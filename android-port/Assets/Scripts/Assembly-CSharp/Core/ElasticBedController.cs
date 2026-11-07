using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200141C")]
	public class ElasticBedController : GolfBallShooterBase
	{
		[Token(Token = "0x4006C11")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006C12")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006C13")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006C14")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006C15")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006C16")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006C17")]
		[FieldOffset(Offset = "0x7D")]
		public bool lookInAimDirection;

		[Token(Token = "0x4006C18")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x4006C19")]
		[FieldOffset(Offset = "0x80")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006C1A")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x4006C1B")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006C1C")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006C1D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public PuppetMaster puppet;

		[Token(Token = "0x4006C1E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public Animator puppetAnimator;

		[Token(Token = "0x4006C1F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		public float poseUpwardsVelocityThreshold;

		[Token(Token = "0x4006C20")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		public float poseHoldTime;

		[Token(Token = "0x4006C21")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public float pinWeightChangeSpeed;

		[Token(Token = "0x4006C22")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		public float pinWeightMax;

		[Token(Token = "0x4006C23")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public float JumpFromMattressExtraForce;

		[Token(Token = "0x4006C24")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 lastVel;

		[Token(Token = "0x4006C25")]
		[FieldOffset(Offset = "0xB8")]
		private float poseTimer;

		[Token(Token = "0x4006C26")]
		private const int POSES = 5;

		[Token(Token = "0x4006C27")]
		[FieldOffset(Offset = "0xBC")]
		private float pinWeightTarget;

		[Token(Token = "0x4006C28")]
		[FieldOffset(Offset = "0xC0")]
		public float distToGroundExtraLength;

		[Token(Token = "0x4006C29")]
		[FieldOffset(Offset = "0xC4")]
		public LayerMask groundLayer;

		[Token(Token = "0x4006C2A")]
		[FieldOffset(Offset = "0xC8")]
		private float distToGround;

		[Token(Token = "0x4006C2B")]
		[FieldOffset(Offset = "0xCC")]
		private float curStillTime;

		[Token(Token = "0x4006C2C")]
		[FieldOffset(Offset = "0xD0")]
		private float stillThreshold;

		[Token(Token = "0x6005D77")]
		[Address(RVA = "0x143BD00", Offset = "0x143BD00", VA = "0x143BD00", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005D78")]
		[Address(RVA = "0x143BD08", Offset = "0x143BD08", VA = "0x143BD08")]
		private void Start()
		{
		}

		[Token(Token = "0x6005D79")]
		[Address(RVA = "0x143BDA4", Offset = "0x143BDA4", VA = "0x143BDA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005D7A")]
		[Address(RVA = "0x143BE50", Offset = "0x143BE50", VA = "0x143BE50")]
		private new void FixedUpdate()
		{
		}

		[Token(Token = "0x6005D7B")]
		[Address(RVA = "0x143C194", Offset = "0x143C194", VA = "0x143C194", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005D7C")]
		[Address(RVA = "0x143C1CC", Offset = "0x143C1CC", VA = "0x143C1CC", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005D7D")]
		[Address(RVA = "0x143C39C", Offset = "0x143C39C", VA = "0x143C39C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005D7E")]
		[Address(RVA = "0x143BEC8", Offset = "0x143BEC8", VA = "0x143BEC8")]
		private bool IsGrounded()
		{
			return default;
		}

		[Token(Token = "0x6005D7F")]
		[Address(RVA = "0x143C6AC", Offset = "0x143C6AC", VA = "0x143C6AC", Slot = "13")]
		protected override bool IsBlocking()
		{
			return default;
		}

		[Token(Token = "0x6005D80")]
		[Address(RVA = "0x143C780", Offset = "0x143C780", VA = "0x143C780", Slot = "14")]
		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6005D81")]
		[Address(RVA = "0x143C8E4", Offset = "0x143C8E4", VA = "0x143C8E4")]
		public ElasticBedController()
		{
		}
	}
}
