using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001446")]
	public class Bike2DShooter : GolfBall2DShooterBase
	{
		[Token(Token = "0x4006DFA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006DFB")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006DFC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public LayerMask groundLayers;

		[Token(Token = "0x4006DFD")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float motorSpeed;

		[Token(Token = "0x4006DFE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float motorTorque;

		[Token(Token = "0x4006DFF")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float airControlForce;

		[Token(Token = "0x4006E00")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float flipAngleCorrectionForce;

		[Token(Token = "0x4006E01")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float airCorrectForce;

		[Token(Token = "0x4006E02")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<WheelJoint2D> wheels;

		[Token(Token = "0x4006E03")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float groundDistance;

		[Token(Token = "0x4006E04")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float isGroundedInAirThreshold;

		[Token(Token = "0x4006E05")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClipSettingsCollection sfxOnJump;

		[Token(Token = "0x4006E06")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RotateAxis2D pedals;

		[Token(Token = "0x4006E07")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float pedalsSpeedMod;

		[Token(Token = "0x4006E08")]
		[FieldOffset(Offset = "0x8C")]
		private float dir;

		[Token(Token = "0x4006E09")]
		[FieldOffset(Offset = "0x90")]
		private float currentDir;

		[Token(Token = "0x4006E0A")]
		[FieldOffset(Offset = "0x94")]
		private float up;

		[Token(Token = "0x4006E0B")]
		[FieldOffset(Offset = "0x98")]
		private JointMotor2D motor;

		[Token(Token = "0x4006E0C")]
		[FieldOffset(Offset = "0xA0")]
		private bool isGrounded;

		[Token(Token = "0x4006E0D")]
		[FieldOffset(Offset = "0xA4")]
		private float lastIsGroundedTime;

		[Token(Token = "0x6005ECA")]
		[Address(RVA = "0x160DFCC", Offset = "0x160DFCC", VA = "0x160DFCC", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005ECB")]
		[Address(RVA = "0x160E004", Offset = "0x160E004", VA = "0x160E004")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005ECC")]
		[Address(RVA = "0x160E00C", Offset = "0x160E00C", VA = "0x160E00C", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005ECD")]
		[Address(RVA = "0x160E47C", Offset = "0x160E47C", VA = "0x160E47C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005ECE")]
		[Address(RVA = "0x160E4B4", Offset = "0x160E4B4", VA = "0x160E4B4", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005ECF")]
		[Address(RVA = "0x160E9BC", Offset = "0x160E9BC", VA = "0x160E9BC", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005ED0")]
		[Address(RVA = "0x160E9C8", Offset = "0x160E9C8", VA = "0x160E9C8", Slot = "13")]
		protected override bool IsBlocking()
		{
			return default;
		}

		[Token(Token = "0x6005ED1")]
		[Address(RVA = "0x160EA00", Offset = "0x160EA00", VA = "0x160EA00", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005ED2")]
		[Address(RVA = "0x160EBA8", Offset = "0x160EBA8", VA = "0x160EBA8")]
		public Bike2DShooter()
		{
		}
	}
}
