using Il2CppDummyDll;
using SpaceGolf;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200135A")]
	public class BouncyPlanetsAudio : MonoBehaviour
	{
		[Token(Token = "0x4006793")]
		[FieldOffset(Offset = "0x18")]
		public RandomAudioClips planetToBoundsClips;

		[Token(Token = "0x4006794")]
		[FieldOffset(Offset = "0x20")]
		public RandomAudioClips planetToPlanetClips;

		[Token(Token = "0x4006795")]
		[FieldOffset(Offset = "0x28")]
		public float minVelocity;

		[Token(Token = "0x4006796")]
		[FieldOffset(Offset = "0x2C")]
		public float maxVelocity;

		[Token(Token = "0x4006797")]
		[FieldOffset(Offset = "0x30")]
		public float minPlanetSize;

		[Token(Token = "0x4006798")]
		[FieldOffset(Offset = "0x34")]
		public float maxPlanetSize;

		[Token(Token = "0x4006799")]
		[FieldOffset(Offset = "0x38")]
		public float cooldown;

		[Token(Token = "0x400679A")]
		[FieldOffset(Offset = "0x40")]
		private Planet[] planets;

		[Token(Token = "0x400679B")]
		[FieldOffset(Offset = "0x48")]
		private float nextSoundTime;

		[Token(Token = "0x6005A47")]
		[Address(RVA = "0x1702064", Offset = "0x1702064", VA = "0x1702064")]
		private void Start()
		{
		}

		[Token(Token = "0x6005A48")]
		[Address(RVA = "0x1702278", Offset = "0x1702278", VA = "0x1702278")]
		private void OnPlanetCollision(HitInfo info)
		{
		}

		[Token(Token = "0x6005A49")]
		[Address(RVA = "0x1702374", Offset = "0x1702374", VA = "0x1702374")]
		public BouncyPlanetsAudio()
		{
		}
	}
}
