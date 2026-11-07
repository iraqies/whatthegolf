using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200039B")]
public class HighJumperAudio : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200039C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F6CC", Offset = "0x3F6CC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__6_0;

		[Token(Token = "0x6001119")]
		[Address(RVA = "0x17BA958", Offset = "0x17BA958", VA = "0x17BA958")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600111A")]
		[Address(RVA = "0x17BA960", Offset = "0x17BA960", VA = "0x17BA960")]
		internal void _003CPlaySpringBoardSound_003Eb__6_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x40013E7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip boardClip;

	[Token(Token = "0x40013E8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float basePitch;

	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float incrementPitch;

	[Token(Token = "0x40013EA")]
	[FieldOffset(Offset = "0x28")]
	private HighJumper jumper;

	[Token(Token = "0x40013EB")]
	[FieldOffset(Offset = "0x30")]
	private int verdictIndex;

	[Token(Token = "0x6001115")]
	[Address(RVA = "0x14C96DC", Offset = "0x14C96DC", VA = "0x14C96DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001116")]
	[Address(RVA = "0x14C97C8", Offset = "0x14C97C8", VA = "0x14C97C8")]
	private void PlaySpringBoardSound()
	{
	}

	[Token(Token = "0x6001117")]
	[Address(RVA = "0x14C9914", Offset = "0x14C9914", VA = "0x14C9914")]
	public HighJumperAudio()
	{
	}
}
