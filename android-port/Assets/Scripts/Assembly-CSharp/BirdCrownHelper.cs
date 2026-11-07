using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A4E")]
public class BirdCrownHelper : MonoBehaviour
{
	[Token(Token = "0x40038F4")]
	[FieldOffset(Offset = "0x18")]
	public SpeechbubbleList speechOnMissing;

	[Token(Token = "0x40038F5")]
	[FieldOffset(Offset = "0x20")]
	public SpeechbubbleList speechOnDone;

	[Token(Token = "0x40038F6")]
	[FieldOffset(Offset = "0x28")]
	public SpeechbubbleList speechIsOpen;

	[Token(Token = "0x40038F7")]
	[FieldOffset(Offset = "0x30")]
	public OverworldButton2D crowndoor;

	[Token(Token = "0x40038F8")]
	[FieldOffset(Offset = "0x38")]
	public ShowSpeechbubbleOnHit speechbubble;

	[Token(Token = "0x600311D")]
	[Address(RVA = "0x1611650", Offset = "0x1611650", VA = "0x1611650")]
	private void Start()
	{
	}

	[Token(Token = "0x600311E")]
	[Address(RVA = "0x161166C", Offset = "0x161166C", VA = "0x161166C")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x600311F")]
	[Address(RVA = "0x161192C", Offset = "0x161192C", VA = "0x161192C")]
	private string ProcessSpeechText(string input)
	{
		return null;
	}

	[Token(Token = "0x6003120")]
	[Address(RVA = "0x16119E4", Offset = "0x16119E4", VA = "0x16119E4")]
	public BirdCrownHelper()
	{
	}
}
