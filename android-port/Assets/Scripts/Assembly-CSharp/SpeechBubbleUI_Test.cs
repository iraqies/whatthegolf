using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200053A")]
public class SpeechBubbleUI_Test : MonoBehaviour
{
	[Token(Token = "0x4001AEF")]
	[FieldOffset(Offset = "0x18")]
	public SpeechBubbleUI speechBubble;

	[Token(Token = "0x4001AF0")]
	[FieldOffset(Offset = "0x20")]
	public Transform preferredCenter;

	[Token(Token = "0x4001AF1")]
	[FieldOffset(Offset = "0x28")]
	public Transform arrowPosition;

	[Token(Token = "0x4001AF2")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<KeyCode, Vector2> shortcuts;

	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x16D02C4", Offset = "0x16D02C4", VA = "0x16D02C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x16D0560", Offset = "0x16D0560", VA = "0x16D0560")]
	public SpeechBubbleUI_Test()
	{
	}
}
