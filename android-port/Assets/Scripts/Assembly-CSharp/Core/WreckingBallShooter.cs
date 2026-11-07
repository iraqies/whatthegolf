using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200145D")]
	public class WreckingBallShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006F3B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006F3C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float AngleDampenLimit;

		[Token(Token = "0x4006F3D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform Extendable;

		[Token(Token = "0x4006F3E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector2 ExtendableRange;

		[Token(Token = "0x4006F3F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float ExtendableMoveSpeed;

		[Token(Token = "0x4006F40")]
		[FieldOffset(Offset = "0x7C")]
		private bool isAiming;

		[Token(Token = "0x4006F41")]
		[FieldOffset(Offset = "0x80")]
		private float rotationStartupTimer;

		[Token(Token = "0x4006F42")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 currentBoost;

		[Token(Token = "0x4006F43")]
		[FieldOffset(Offset = "0x90")]
		private Joint joint;

		[Token(Token = "0x4006F44")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 startJointAnchor;

		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0x175AE58", Offset = "0x175AE58", VA = "0x175AE58", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0x175AED8", Offset = "0x175AED8", VA = "0x175AED8", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0x175AFB4", Offset = "0x175AFB4", VA = "0x175AFB4", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0x175AFDC", Offset = "0x175AFDC", VA = "0x175AFDC", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0x175B004", Offset = "0x175B004", VA = "0x175B004")]
		private void AdjustRotation(Vector3 dir)
		{
		}

		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0x175B0EC", Offset = "0x175B0EC", VA = "0x175B0EC", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x175B258", Offset = "0x175B258", VA = "0x175B258")]
		public WreckingBallShooter()
		{
		}
	}
}
