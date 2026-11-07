using System.Collections.Generic;
using Core;
using Il2CppDummyDll;

namespace Challenges.ChallengeCompletors
{
	[Token(Token = "0x20010FE")]
	public class UfoChallenge : Challenge
	{
		[Token(Token = "0x4005997")]
		[FieldOffset(Offset = "0xA8")]
		public List<BeamableObject> objectsToBeam;

		[Token(Token = "0x4005998")]
		[FieldOffset(Offset = "0xB0")]
		private GolfBallController controller;

		[Token(Token = "0x4005999")]
		[FieldOffset(Offset = "0xB8")]
		private List<BeamableObject> _beamedObjects;

		[Token(Token = "0x6004C0C")]
		[Address(RVA = "0x173856C", Offset = "0x173856C", VA = "0x173856C", Slot = "8")]
		protected override void Activate()
		{
		}

		[Token(Token = "0x6004C0D")]
		[Address(RVA = "0x1738818", Offset = "0x1738818", VA = "0x1738818")]
		private void OnBeamed(BeamableObject obj)
		{
		}

		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0x1738904", Offset = "0x1738904", VA = "0x1738904")]
		public UfoChallenge()
		{
		}
	}
}
