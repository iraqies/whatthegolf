using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001354")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x48C30", Offset = "0x48C30")]
	public class AudioClipFromSurface : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2001355")]
		public class SurfaceAudio
		{
			[Token(Token = "0x4006775")]
			[FieldOffset(Offset = "0x10")]
			public AudioClip clip;

			[Token(Token = "0x4006776")]
			[FieldOffset(Offset = "0x18")]
			public AudioMaterial material;

			[Token(Token = "0x6005A38")]
			[Address(RVA = "0x176F87C", Offset = "0x176F87C", VA = "0x176F87C")]
			public SurfaceAudio()
			{
			}
		}

		[Token(Token = "0x4006772")]
		[FieldOffset(Offset = "0x18")]
		public SurfaceAudio[] surfaceClips;

		[Token(Token = "0x4006773")]
		[FieldOffset(Offset = "0x20")]
		private AudioSource source;

		[Token(Token = "0x4006774")]
		[FieldOffset(Offset = "0x28")]
		private AudioFromSurfaceModifier surfaceModifier;

		[Token(Token = "0x6005A33")]
		[Address(RVA = "0x142C4A8", Offset = "0x142C4A8", VA = "0x142C4A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A34")]
		[Address(RVA = "0x142C528", Offset = "0x142C528", VA = "0x142C528")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005A35")]
		[Address(RVA = "0x142C60C", Offset = "0x142C60C", VA = "0x142C60C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005A36")]
		[Address(RVA = "0x142C6F0", Offset = "0x142C6F0", VA = "0x142C6F0")]
		private void OnSurfaceChange(AudioMaterial material)
		{
		}

		[Token(Token = "0x6005A37")]
		[Address(RVA = "0x142C840", Offset = "0x142C840", VA = "0x142C840")]
		public AudioClipFromSurface()
		{
		}
	}
}
