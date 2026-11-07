using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200145B")]
	public class UfoShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006F20")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006F21")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006F22")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float targetHeight;

		[Token(Token = "0x4006F23")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4006F24")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006F25")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[Token(Token = "0x4006F26")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool useGravity;

		[Token(Token = "0x4006F27")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform upOverride;

		[Token(Token = "0x4006F28")]
		[FieldOffset(Offset = "0x88")]
		private GolfBallController controller;

		[Token(Token = "0x4006F29")]
		[FieldOffset(Offset = "0x90")]
		public GolfBallController ballController;

		[Token(Token = "0x4006F2A")]
		[FieldOffset(Offset = "0x98")]
		private ExplosionBarrel barrel;

		[Token(Token = "0x4006F2B")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006F2C")]
		[FieldOffset(Offset = "0xAC")]
		private bool isAiming;

		[Token(Token = "0x4006F2D")]
		[FieldOffset(Offset = "0xAD")]
		private bool didAim;

		[Token(Token = "0x4006F2E")]
		[FieldOffset(Offset = "0xB0")]
		private float firstAimTime;

		[Token(Token = "0x4006F2F")]
		[FieldOffset(Offset = "0xB4")]
		private float warmup;

		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x1738CDC", Offset = "0x1738CDC", VA = "0x1738CDC", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x1738D14", Offset = "0x1738D14", VA = "0x1738D14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x1738DCC", Offset = "0x1738DCC", VA = "0x1738DCC", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0x1738E6C", Offset = "0x1738E6C", VA = "0x1738E6C", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x1738EC8", Offset = "0x1738EC8", VA = "0x1738EC8", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x1738F04", Offset = "0x1738F04", VA = "0x1738F04")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x1738FFC", Offset = "0x1738FFC", VA = "0x1738FFC", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x173905C", Offset = "0x173905C", VA = "0x173905C", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x1739360", Offset = "0x1739360", VA = "0x1739360")]
		public UfoShooter()
		{
		}
	}
}
