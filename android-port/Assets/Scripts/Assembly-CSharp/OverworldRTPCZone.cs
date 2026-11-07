using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BE")]
public class OverworldRTPCZone : MonoBehaviour
{
	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0x18")]
	public uint RTPC;

	[Token(Token = "0x40014A0")]
	[FieldOffset(Offset = "0x1C")]
	public float ValueOnEnter;

	[Token(Token = "0x40014A1")]
	[FieldOffset(Offset = "0x20")]
	public float ValueOnExit;

	[Token(Token = "0x40014A2")]
	[FieldOffset(Offset = "0x24")]
	public float timeToSet;

	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x15CA8E8", Offset = "0x15CA8E8", VA = "0x15CA8E8")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x15CA9E8", Offset = "0x15CA9E8", VA = "0x15CA9E8")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x15CAAE4", Offset = "0x15CAAE4", VA = "0x15CAAE4")]
	public OverworldRTPCZone()
	{
	}
}
