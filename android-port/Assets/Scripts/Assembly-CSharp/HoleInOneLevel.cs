using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200077C")]
public class HoleInOneLevel : MonoBehaviour
{
	[Token(Token = "0x4002792")]
	[FieldOffset(Offset = "0x18")]
	public int personalityState;

	[Token(Token = "0x4002793")]
	[FieldOffset(Offset = "0x1C")]
	public bool isScanlines;

	[Token(Token = "0x4002794")]
	[FieldOffset(Offset = "0x20")]
	public float extraRetryTimeout;

	[Token(Token = "0x4002795")]
	[FieldOffset(Offset = "0x24")]
	public bool isCustom;

	[Token(Token = "0x4002796")]
	[FieldOffset(Offset = "0x28")]
	public SpeechbubbleList dialogLose;

	[Token(Token = "0x4002797")]
	[FieldOffset(Offset = "0x30")]
	public SpeechbubbleList dialogStart;

	[Token(Token = "0x600226A")]
	[Address(RVA = "0x14CEBC8", Offset = "0x14CEBC8", VA = "0x14CEBC8")]
	public HoleInOneLevel()
	{
	}
}
