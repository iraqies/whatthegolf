using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001386")]
	public abstract class BaseAudioModifier : MonoBehaviour
	{
		[Token(Token = "0x40068CB")]
		[FieldOffset(Offset = "0x18")]
		public float value;

		[Token(Token = "0x40068CC")]
		[FieldOffset(Offset = "0x1C")]
		public float highestValue;

		[Token(Token = "0x40068CD")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x40068CE")]
		[FieldOffset(Offset = "0x28")]
		public BaseAudioValue modifier;

		[Token(Token = "0x40068CF")]
		[FieldOffset(Offset = "0x30")]
		public float fadeSpeed;

		[Token(Token = "0x40068D0")]
		[FieldOffset(Offset = "0x34")]
		public float minModifierValue;

		[Token(Token = "0x40068D1")]
		[FieldOffset(Offset = "0x38")]
		public float maxModifierValue;

		[Token(Token = "0x40068D2")]
		[FieldOffset(Offset = "0x3C")]
		public float minSoundValue;

		[Token(Token = "0x40068D3")]
		[FieldOffset(Offset = "0x40")]
		public float maxSoundValue;

		[Token(Token = "0x6005B2E")]
		[Address(RVA = "0x150B0F8", Offset = "0x150B0F8", VA = "0x150B0F8")]
		protected void Initialize()
		{
		}

		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0x151B2CC", Offset = "0x151B2CC", VA = "0x151B2CC", Slot = "4")]
		protected virtual void OnValueChange(float _value)
		{
		}

		[Token(Token = "0x6005B30")]
		[Address(RVA = "0x150B4D0", Offset = "0x150B4D0", VA = "0x150B4D0")]
		protected BaseAudioModifier()
		{
		}
	}
}
