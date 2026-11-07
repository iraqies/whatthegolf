using Il2CppDummyDll;

[Token(Token = "0x2000C7B")]
public class SaveFileInfo
{
	[Token(Token = "0x4004456")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4004457")]
	[FieldOffset(Offset = "0x18")]
	public long modifiedTimestamp;

	[Token(Token = "0x6003B2F")]
	[Address(RVA = "0x166BA0C", Offset = "0x166BA0C", VA = "0x166BA0C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003B30")]
	[Address(RVA = "0x166BA9C", Offset = "0x166BA9C", VA = "0x166BA9C")]
	public SaveFileInfo()
	{
	}
}
