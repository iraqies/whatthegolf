using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003E6")]
public class UISound : MonoBehaviour
{
	[Token(Token = "0x4001546")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip uiClip;

	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float volume;

	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float pitch;

	[Token(Token = "0x6001252")]
	[Address(RVA = "0x173844C", Offset = "0x173844C", VA = "0x173844C")]
	public void Play()
	{
	}

	[Token(Token = "0x6001253")]
	[Address(RVA = "0x1738518", Offset = "0x1738518", VA = "0x1738518")]
	public UISound()
	{
	}

	[Token(Token = "0x6001254")]
	[Address(RVA = "0x1738528", Offset = "0x1738528", VA = "0x1738528")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C6C", Offset = "0x61C6C")]
	private void _003CPlay_003Eb__3_0(AudioSource s)
	{
	}
}
