using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001459")]
	public class RollingCowShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006F0C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006F0D")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006F0E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float jumpForce;

		[Token(Token = "0x4006F0F")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		public float dashForce;

		[Token(Token = "0x4006F10")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public bool doJumpOnShoot;

		[Token(Token = "0x4006F11")]
		[FieldOffset(Offset = "0x71")]
		[SerializeField]
		public bool doDashOnShoot;

		[Token(Token = "0x4006F12")]
		[FieldOffset(Offset = "0x72")]
		[SerializeField]
		public bool onlyPushSpecificTag;

		[Token(Token = "0x4006F13")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public string specifiedTag;

		[Token(Token = "0x4006F14")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool onlyAddTorqueWhenGrounded;

		[Token(Token = "0x4006F15")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private LayerMask groundLayer;

		[Token(Token = "0x4006F16")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006F17")]
		[FieldOffset(Offset = "0x94")]
		private bool isAiming;

		[Token(Token = "0x4006F18")]
		[FieldOffset(Offset = "0x95")]
		private bool _remoteControlled;

		[Token(Token = "0x4006F19")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 _remoteControlDirection;

		[Token(Token = "0x4006F1A")]
		[FieldOffset(Offset = "0xA4")]
		private bool didAim;

		[Token(Token = "0x4006F1B")]
		[FieldOffset(Offset = "0xA8")]
		public float impactForceMultiplier;

		[Token(Token = "0x4006F1C")]
		[FieldOffset(Offset = "0xB0")]
		private Collider[] _childColliders;

		[Token(Token = "0x4006F1D")]
		[FieldOffset(Offset = "0xB8")]
		private bool grounded;

		[Token(Token = "0x4006F1E")]
		[FieldOffset(Offset = "0xBC")]
		private float _lastPush;

		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x165D278", Offset = "0x165D278", VA = "0x165D278", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x165D3C4", Offset = "0x165D3C4", VA = "0x165D3C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x165D554", Offset = "0x165D554", VA = "0x165D554", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x165D5F4", Offset = "0x165D5F4", VA = "0x165D5F4", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x165D620", Offset = "0x165D620", VA = "0x165D620", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x165D648", Offset = "0x165D648", VA = "0x165D648", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x165D810", Offset = "0x165D810", VA = "0x165D810")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005F94")]
		[Address(RVA = "0x165DB40", Offset = "0x165DB40", VA = "0x165DB40")]
		private void OnCollisionStay(Collision other)
		{
		}

		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x165DB9C", Offset = "0x165DB9C", VA = "0x165DB9C", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x165C6C0", Offset = "0x165C6C0", VA = "0x165C6C0")]
		public void RemoteControl(Vector3 aimDirection)
		{
		}

		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x165DCB8", Offset = "0x165DCB8", VA = "0x165DCB8")]
		public RollingCowShooter()
		{
		}
	}
}
