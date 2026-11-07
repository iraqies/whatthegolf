using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfGames.Pinball
{
	[Token(Token = "0x20010B4")]
	public class PinballShooter : GolfBall2DShooterBase
	{
		[Token(Token = "0x40057F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float shootVelocity;

		[Token(Token = "0x40057F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource startShotAudio;

		[Token(Token = "0x40057F7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioSource flipperAudio;

		[Token(Token = "0x40057F8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ParticleSystem winParticles;

		[Token(Token = "0x40057F9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PinballStartShooter pinballStartShooter;

		[Token(Token = "0x40057FA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PinballFlipper[] flippers;

		[Token(Token = "0x40057FB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Pinball ball;

		[Token(Token = "0x40057FC")]
		[FieldOffset(Offset = "0x80")]
		private float shootTimer;

		[Token(Token = "0x40057FD")]
		[FieldOffset(Offset = "0x84")]
		private float startMotorSpeed;

		[Token(Token = "0x40057FE")]
		[FieldOffset(Offset = "0x88")]
		private List<Pinball> balls;

		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x15E2C6C", Offset = "0x15E2C6C", VA = "0x15E2C6C", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x15E2D0C", Offset = "0x15E2D0C", VA = "0x15E2D0C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x15E2F80", Offset = "0x15E2F80", VA = "0x15E2F80")]
		private void Update()
		{
		}

		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x15E306C", Offset = "0x15E306C", VA = "0x15E306C")]
		public void AddBall(Pinball ball)
		{
		}

		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x15E30D0", Offset = "0x15E30D0", VA = "0x15E30D0")]
		public PinballShooter()
		{
		}
	}
}
