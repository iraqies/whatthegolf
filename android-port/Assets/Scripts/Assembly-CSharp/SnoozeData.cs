using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000488")]
public class SnoozeData
{
	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x10")]
	public int Index;

	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0x18")]
	public DateTime LastShownTime;

	[Token(Token = "0x600150A")]
	[Address(RVA = "0x16BAE0C", Offset = "0x16BAE0C", VA = "0x16BAE0C")]
	public SnoozeData(int index, DateTime lastShownTime)
	{
	}

	[Token(Token = "0x600150B")]
	[Address(RVA = "0x16BAE48", Offset = "0x16BAE48", VA = "0x16BAE48", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600150C")]
	[Address(RVA = "0x16BAFC8", Offset = "0x16BAFC8", VA = "0x16BAFC8")]
	public static SnoozeData FromString(string str)
	{
		return null;
	}
}
