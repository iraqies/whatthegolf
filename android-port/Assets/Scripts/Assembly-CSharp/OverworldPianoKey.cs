using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ABF")]
public class OverworldPianoKey : MonoBehaviour
{
	[Token(Token = "0x2000AC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x430D4", Offset = "0x430D4")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4003BEA")]
		[FieldOffset(Offset = "0x10")]
		public float pitch;

		[Token(Token = "0x4003BEB")]
		[FieldOffset(Offset = "0x18")]
		public OverworldPianoKey _003C_003E4__this;

		[Token(Token = "0x600336F")]
		[Address(RVA = "0x181CB30", Offset = "0x181CB30", VA = "0x181CB30")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6003370")]
		[Address(RVA = "0x181CB38", Offset = "0x181CB38", VA = "0x181CB38")]
		internal void _003COnTriggerEnter2D_003Eb__0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x4003BE3")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x4003BE4")]
	[FieldOffset(Offset = "0x20")]
	public int note;

	[Token(Token = "0x4003BE5")]
	[FieldOffset(Offset = "0x28")]
	private SpriteRenderer sprite;

	[Token(Token = "0x4003BE6")]
	[FieldOffset(Offset = "0x30")]
	private Color downColor;

	[Token(Token = "0x4003BE7")]
	[FieldOffset(Offset = "0x40")]
	private Color upColor;

	[Token(Token = "0x4003BE8")]
	[FieldOffset(Offset = "0x50")]
	private float upTime;

	[Token(Token = "0x4003BE9")]
	[FieldOffset(Offset = "0x54")]
	private float volume;

	[Token(Token = "0x600336B")]
	[Address(RVA = "0x15C89C8", Offset = "0x15C89C8", VA = "0x15C89C8")]
	public void Init(AudioClip clip, int midiNote, float volume)
	{
	}

	[Token(Token = "0x600336C")]
	[Address(RVA = "0x15C8AEC", Offset = "0x15C8AEC", VA = "0x15C8AEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600336D")]
	[Address(RVA = "0x15C8BD0", Offset = "0x15C8BD0", VA = "0x15C8BD0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x600336E")]
	[Address(RVA = "0x15C8D78", Offset = "0x15C8D78", VA = "0x15C8D78")]
	public OverworldPianoKey()
	{
	}
}
