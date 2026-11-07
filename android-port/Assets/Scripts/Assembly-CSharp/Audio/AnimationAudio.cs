using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200134F")]
	public class AnimationAudio : MonoBehaviour, IAudioCullable
	{
		[Token(Token = "0x400675F")]
		[FieldOffset(Offset = "0x18")]
		public List<ClipSettingsCollection> SFX_Oneshots;

		[Token(Token = "0x4006760")]
		[FieldOffset(Offset = "0x20")]
		public Transform emitterTransform;

		[Token(Token = "0x4006761")]
		[FieldOffset(Offset = "0x28")]
		public AudioSource audioSource;

		[Token(Token = "0x4006762")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59EAC", Offset = "0x59EAC")]
		private bool IsVisible__BackingField;

		[Token(Token = "0x17000A2C")]
		public bool IsVisible
		{
			[Token(Token = "0x6005A22")]
			[Address(RVA = "0x1418040", Offset = "0x1418040", VA = "0x1418040", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x722E8", Offset = "0x722E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A23")]
			[Address(RVA = "0x1418048", Offset = "0x1418048", VA = "0x1418048", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x722F8", Offset = "0x722F8")]
			set
			{
			}
		}

		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x1418050", Offset = "0x1418050", VA = "0x1418050")]
		public void AnimationAudioOneshot(int index)
		{
		}

		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x141829C", Offset = "0x141829C", VA = "0x141829C")]
		public AnimationAudio()
		{
		}
	}
}
