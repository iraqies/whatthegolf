using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001344")]
	public class PlayAudioClipsByFrequency : MonoBehaviour
	{
		[Token(Token = "0x400671B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClipSettingsCollection clips;

		[Token(Token = "0x400671C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource customAudioSource;

		[Token(Token = "0x400671D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float startFrequency;

		[Token(Token = "0x400671E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool startOnAwake;

		[Token(Token = "0x400671F")]
		[FieldOffset(Offset = "0x30")]
		private float nextPlayTime;

		[Token(Token = "0x4006720")]
		[FieldOffset(Offset = "0x34")]
		private float volumeModifier;

		[Token(Token = "0x4006721")]
		[FieldOffset(Offset = "0x38")]
		private float pitchModifier;

		[Token(Token = "0x4006722")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59DDC", Offset = "0x59DDC")]
		private float Frequency__BackingField;

		[Token(Token = "0x4006723")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59DEC", Offset = "0x59DEC")]
		private float Delay__BackingField;

		[Token(Token = "0x4006724")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59DFC", Offset = "0x59DFC")]
		private bool IsPlaying__BackingField;

		[Token(Token = "0x17000A22")]
		public float Frequency
		{
			[Token(Token = "0x60059EA")]
			[Address(RVA = "0x15E952C", Offset = "0x15E952C", VA = "0x15E952C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72188", Offset = "0x72188")]
			get
			{
				return default;
			}
			[Token(Token = "0x60059EB")]
			[Address(RVA = "0x15E9534", Offset = "0x15E9534", VA = "0x15E9534")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72198", Offset = "0x72198")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A23")]
		public float Delay
		{
			[Token(Token = "0x60059EC")]
			[Address(RVA = "0x15E953C", Offset = "0x15E953C", VA = "0x15E953C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x721A8", Offset = "0x721A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60059ED")]
			[Address(RVA = "0x15E9544", Offset = "0x15E9544", VA = "0x15E9544")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x721B8", Offset = "0x721B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A24")]
		public bool IsPlaying
		{
			[Token(Token = "0x60059EE")]
			[Address(RVA = "0x15E954C", Offset = "0x15E954C", VA = "0x15E954C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x721C8", Offset = "0x721C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60059EF")]
			[Address(RVA = "0x15E9554", Offset = "0x15E9554", VA = "0x15E9554")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x721D8", Offset = "0x721D8")]
			private set
			{
			}
		}

		[Token(Token = "0x60059F0")]
		[Address(RVA = "0x15E955C", Offset = "0x15E955C", VA = "0x15E955C")]
		public void Play()
		{
		}

		[Token(Token = "0x60059F1")]
		[Address(RVA = "0x15E958C", Offset = "0x15E958C", VA = "0x15E958C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60059F2")]
		[Address(RVA = "0x15E9594", Offset = "0x15E9594", VA = "0x15E9594")]
		public void SetModifiers(float vol, float pitch)
		{
		}

		[Token(Token = "0x60059F3")]
		[Address(RVA = "0x15E959C", Offset = "0x15E959C", VA = "0x15E959C")]
		public void SetFrequency(float freq)
		{
		}

		[Token(Token = "0x60059F4")]
		[Address(RVA = "0x15E95B4", Offset = "0x15E95B4", VA = "0x15E95B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x15E95E0", Offset = "0x15E95E0", VA = "0x15E95E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x15E973C", Offset = "0x15E973C", VA = "0x15E973C")]
		public PlayAudioClipsByFrequency()
		{
		}
	}
}
