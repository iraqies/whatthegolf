using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001458")]
	public class MoonRoverShooter : GolfBall2DShooterBase
	{
		[Token(Token = "0x4006EFB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006EFC")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006EFD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public LayerMask groundLayers;

		[Token(Token = "0x4006EFE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float motorSpeed;

		[Token(Token = "0x4006EFF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float motorTorque;

		[Token(Token = "0x4006F00")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float airControlForce;

		[Token(Token = "0x4006F01")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float flipAngleCorrectionForce;

		[Token(Token = "0x4006F02")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float airCorrectForce;

		[Token(Token = "0x4006F03")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float catchupToMinSpeedForce;

		[Token(Token = "0x4006F04")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<WheelJoint2D> wheels;

		[Token(Token = "0x4006F05")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float groundDistance;

		[Token(Token = "0x4006F06")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float minimumSpeed;

		[Token(Token = "0x4006F07")]
		[FieldOffset(Offset = "0x80")]
		private float dir;

		[Token(Token = "0x4006F08")]
		[FieldOffset(Offset = "0x84")]
		private float currentDir;

		[Token(Token = "0x4006F09")]
		[FieldOffset(Offset = "0x88")]
		private float up;

		[Token(Token = "0x4006F0A")]
		[FieldOffset(Offset = "0x8C")]
		private JointMotor2D motor;

		[Token(Token = "0x4006F0B")]
		[FieldOffset(Offset = "0x94")]
		private bool isGrounded;

		[Token(Token = "0x6005F84")]
		[Address(RVA = "0x156DB00", Offset = "0x156DB00", VA = "0x156DB00", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F85")]
		[Address(RVA = "0x156DB38", Offset = "0x156DB38", VA = "0x156DB38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005F86")]
		[Address(RVA = "0x156DB40", Offset = "0x156DB40", VA = "0x156DB40", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F87")]
		[Address(RVA = "0x156DF50", Offset = "0x156DF50", VA = "0x156DF50")]
		private void Update()
		{
		}

		[Token(Token = "0x6005F88")]
		[Address(RVA = "0x156DF88", Offset = "0x156DF88", VA = "0x156DF88", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F89")]
		[Address(RVA = "0x156E524", Offset = "0x156E524", VA = "0x156E524", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x156E530", Offset = "0x156E530", VA = "0x156E530", Slot = "13")]
		protected override bool IsBlocking()
		{
			return default;
		}

		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x156E540", Offset = "0x156E540", VA = "0x156E540", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x156E604", Offset = "0x156E604", VA = "0x156E604")]
		public MoonRoverShooter()
		{
		}
	}
}
