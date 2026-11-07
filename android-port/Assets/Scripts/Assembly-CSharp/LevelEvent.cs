using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004CC")]
public class LevelEvent : ScriptableObject
{
	[Token(Token = "0x400190B")]
	[FieldOffset(Offset = "0x18")]
	public string serializationId;

	[Token(Token = "0x400190C")]
	[FieldOffset(Offset = "0x20")]
	public Sprite icon;

	[Token(Token = "0x6001610")]
	[Address(RVA = "0x152D528", Offset = "0x152D528", VA = "0x152D528")]
	public LevelEvent()
	{
	}
}
