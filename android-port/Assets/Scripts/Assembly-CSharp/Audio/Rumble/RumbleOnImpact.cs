using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x2001401")]
	public class RumbleOnImpact : MonoBehaviour
	{
		[Token(Token = "0x4006B61")]
		[FieldOffset(Offset = "0x18")]
		public float minVelocity;

		[Token(Token = "0x4006B62")]
		[FieldOffset(Offset = "0x1C")]
		public float maxVelocity;

		[Token(Token = "0x4006B63")]
		[FieldOffset(Offset = "0x20")]
		public float cooldown;

		[Token(Token = "0x4006B64")]
		[FieldOffset(Offset = "0x28")]
		public VelocityRumble[] velocityRumble;

		[Token(Token = "0x4006B65")]
		[FieldOffset(Offset = "0x30")]
		public LayerMask layerMask;

		[Token(Token = "0x4006B66")]
		[FieldOffset(Offset = "0x38")]
		private GolfBallController ballController;

		[Token(Token = "0x4006B67")]
		[FieldOffset(Offset = "0x40")]
		private float nextPlayTime;

		[Token(Token = "0x6005D22")]
		[Address(RVA = "0x16622DC", Offset = "0x16622DC", VA = "0x16622DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005D23")]
		[Address(RVA = "0x16622E0", Offset = "0x16622E0", VA = "0x16622E0")]
		public void OnCollisionRemote(HitInfo hitInfo)
		{
		}

		[Token(Token = "0x6005D24")]
		[Address(RVA = "0x16622E4", Offset = "0x16622E4", VA = "0x16622E4")]
		private void HandleHit(float velocityMagnitude)
		{
		}

		[Token(Token = "0x6005D25")]
		[Address(RVA = "0x16622E8", Offset = "0x16622E8", VA = "0x16622E8")]
		public RumbleOnImpact()
		{
		}
	}
}
