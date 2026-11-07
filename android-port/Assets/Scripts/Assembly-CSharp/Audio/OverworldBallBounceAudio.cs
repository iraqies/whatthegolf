using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001391")]
	public class OverworldBallBounceAudio : MonoBehaviour
	{
		[Token(Token = "0x4006906")]
		[FieldOffset(Offset = "0x18")]
		public AudioMaterial audioMaterial;

		[Token(Token = "0x4006907")]
		[FieldOffset(Offset = "0x20")]
		public float cooldown;

		[Token(Token = "0x4006908")]
		[FieldOffset(Offset = "0x28")]
		public List<AudioClipFromVelocity> clipGroups;

		[Token(Token = "0x4006909")]
		[FieldOffset(Offset = "0x30")]
		private float nextSoundTime;

		[Token(Token = "0x6005B50")]
		[Address(RVA = "0x15A3464", Offset = "0x15A3464", VA = "0x15A3464")]
		private void OnCollisionEnter2D(Collision2D col)
		{
		}

		[Token(Token = "0x6005B51")]
		[Address(RVA = "0x15A3740", Offset = "0x15A3740", VA = "0x15A3740")]
		public OverworldBallBounceAudio()
		{
		}

		[Token(Token = "0x6005B52")]
		[Address(RVA = "0x15A3754", Offset = "0x15A3754", VA = "0x15A3754")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x725C8", Offset = "0x725C8")]
		private void _003COnCollisionEnter2D_003Eb__4_0(AudioSource s)
		{
		}
	}
}
