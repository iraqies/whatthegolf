using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Challenges.ChallengeCompletors
{
	[Token(Token = "0x20010FD")]
	public class Par2DChallenge : Challenge
	{
		[Token(Token = "0x400598F")]
		[FieldOffset(Offset = "0xA4")]
		public int ScoreToBeat;

		[Token(Token = "0x4005990")]
		[FieldOffset(Offset = "0xA8")]
		public bool AutoFail;

		[Token(Token = "0x4005991")]
		[FieldOffset(Offset = "0xAC")]
		public float AutoFailThreshold;

		[Token(Token = "0x4005992")]
		[FieldOffset(Offset = "0xB0")]
		public float AutoFailTimer;

		[Token(Token = "0x4005993")]
		[FieldOffset(Offset = "0xB8")]
		private GolfBallController controller;

		[Token(Token = "0x4005994")]
		[FieldOffset(Offset = "0xC0")]
		public Rigidbody2D controllerRigid;

		[Token(Token = "0x4005995")]
		[FieldOffset(Offset = "0xC8")]
		private bool checkVelocity;

		[Token(Token = "0x4005996")]
		[FieldOffset(Offset = "0xCC")]
		private float m_failTimer;

		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x15D8F34", Offset = "0x15D8F34", VA = "0x15D8F34", Slot = "8")]
		protected override void Activate()
		{
		}

		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x15D9164", Offset = "0x15D9164", VA = "0x15D9164", Slot = "5")]
		public override string GetDescription()
		{
			return null;
		}

		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x15D92A8", Offset = "0x15D92A8", VA = "0x15D92A8", Slot = "6")]
		public override string GetWinMessageID()
		{
			return null;
		}

		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x15D930C", Offset = "0x15D930C", VA = "0x15D930C")]
		private void OnHasShot(GolfBallController controller, int strokes)
		{
		}

		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x15D9380", Offset = "0x15D9380", VA = "0x15D9380")]
		private void OnShoot(Vector3 v)
		{
		}

		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x15D93C0", Offset = "0x15D93C0", VA = "0x15D93C0", Slot = "9")]
		protected override void ChallengeUpdate()
		{
		}

		[Token(Token = "0x6004C0A")]
		[Address(RVA = "0x15D94CC", Offset = "0x15D94CC", VA = "0x15D94CC", Slot = "10")]
		public override void OnLevelComplete(Level.CompletedState completedState)
		{
		}

		[Token(Token = "0x6004C0B")]
		[Address(RVA = "0x15D956C", Offset = "0x15D956C", VA = "0x15D956C")]
		public Par2DChallenge()
		{
		}
	}
}
