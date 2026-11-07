using Il2CppDummyDll;

[Token(Token = "0x2000CF1")]
public struct TriCloudResult
{
	[Token(Token = "0x4004658")]
	[FieldOffset(Offset = "0x0")]
	public bool success;

	[Token(Token = "0x4004659")]
	[FieldOffset(Offset = "0x8")]
	public string error;

	[Token(Token = "0x400465A")]
	[FieldOffset(Offset = "0x10")]
	public byte[] resultData;
}
