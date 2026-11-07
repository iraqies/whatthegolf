using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace TennisGolf
{
	[Token(Token = "0x200109F")]
	public class TennisBombBall : TennisBall
	{
		[Token(Token = "0x4005779")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject explosionPrefab;

		[Token(Token = "0x400577A")]
		[FieldOffset(Offset = "0xB8")]
		private ParticleSystem _explosion;

		[Token(Token = "0x400577B")]
		[FieldOffset(Offset = "0xC0")]
		public TennisOpponent tennisOpponent;

		[Token(Token = "0x400577C")]
		[FieldOffset(Offset = "0xC8")]
		public TennisPlayer tennisPlayer;

		[Token(Token = "0x400577D")]
		[FieldOffset(Offset = "0xD0")]
		public AudioEventAsset explosionSFX;

		[Token(Token = "0x400577E")]
		[FieldOffset(Offset = "0xD8")]
		public float explosionRange;

		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x16F9088", Offset = "0x16F9088", VA = "0x16F9088")]
		public void Start()
		{
		}

		[Token(Token = "0x6004A82")]
		[Address(RVA = "0x16F9140", Offset = "0x16F9140", VA = "0x16F9140", Slot = "4")]
		public override void CheckCollision(string collidingTag, GameObject hit)
		{
		}

		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x16F92F8", Offset = "0x16F92F8", VA = "0x16F92F8")]
		public void CheckPlayerDistance(Vector3 explosionPosition)
		{
		}

		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x16F93D4", Offset = "0x16F93D4", VA = "0x16F93D4")]
		public TennisBombBall()
		{
		}
	}
}
