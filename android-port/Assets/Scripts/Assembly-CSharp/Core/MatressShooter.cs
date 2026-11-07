using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001420")]
	public class MatressShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006C5B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006C5C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006C5D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006C5E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006C5F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006C60")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006C61")]
		[FieldOffset(Offset = "0x7D")]
		public bool lookInAimDirection;

		[Token(Token = "0x4006C62")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x4006C63")]
		[FieldOffset(Offset = "0x80")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006C64")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x4006C65")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006C66")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006C67")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public Animator anim;

		[Token(Token = "0x4006C68")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public float bendSpeed;

		[Token(Token = "0x4006C69")]
		[FieldOffset(Offset = "0x98")]
		private string bendParam;

		[Token(Token = "0x4006C6A")]
		[FieldOffset(Offset = "0xA0")]
		private float targetBend;

		[Token(Token = "0x4006C6B")]
		[FieldOffset(Offset = "0xA4")]
		private float currentBend;

		[Token(Token = "0x4006C6C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x5B2E4", Offset = "0x5B2E4")]
		private float currentSqueeze;

		[Token(Token = "0x4006C6D")]
		[FieldOffset(Offset = "0xB0")]
		private string squeezeParam;

		[Token(Token = "0x4006C6E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public float squeezeSpeed;

		[Token(Token = "0x4006C6F")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float disableSqueezeStartupTime;

		[Token(Token = "0x4006C70")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CBFollow camera;

		[Token(Token = "0x4006C71")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Vector2 cameraFramingAfterFirstShot;

		[Token(Token = "0x4006C72")]
		[FieldOffset(Offset = "0xD0")]
		private float awakeTime;

		[Token(Token = "0x4006C73")]
		[FieldOffset(Offset = "0xD4")]
		private bool isAiming;

		[Token(Token = "0x4006C74")]
		[FieldOffset(Offset = "0xD5")]
		private bool isFirstShot;

		[Token(Token = "0x4006C75")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AnimationCurve squeezeDecay;

		[Token(Token = "0x4006C76")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float squeezeForceNormalizer;

		[Token(Token = "0x4006C77")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private float squeezeMinDuration;

		[Token(Token = "0x4006C78")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float squeezeMaxDuration;

		[Token(Token = "0x4006C79")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private float oscillationSpeed;

		[Token(Token = "0x4006C7A")]
		[FieldOffset(Offset = "0xF0")]
		private float squeezeStrength;

		[Token(Token = "0x4006C7B")]
		[FieldOffset(Offset = "0xF4")]
		private float collisionTime;

		[Token(Token = "0x6005D95")]
		[Address(RVA = "0x155EF88", Offset = "0x155EF88", VA = "0x155EF88", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005D96")]
		[Address(RVA = "0x155EFB8", Offset = "0x155EFB8", VA = "0x155EFB8", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005D97")]
		[Address(RVA = "0x155EFF0", Offset = "0x155EFF0", VA = "0x155EFF0", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005D98")]
		[Address(RVA = "0x155F270", Offset = "0x155F270", VA = "0x155F270", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005D99")]
		[Address(RVA = "0x155F298", Offset = "0x155F298", VA = "0x155F298", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6005D9A")]
		[Address(RVA = "0x155F2C0", Offset = "0x155F2C0", VA = "0x155F2C0", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005D9B")]
		[Address(RVA = "0x155F560", Offset = "0x155F560", VA = "0x155F560")]
		private void Update()
		{
		}

		[Token(Token = "0x6005D9C")]
		[Address(RVA = "0x155F644", Offset = "0x155F644", VA = "0x155F644")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0x155F724", Offset = "0x155F724", VA = "0x155F724")]
		public MatressShooter()
		{
		}
	}
}
