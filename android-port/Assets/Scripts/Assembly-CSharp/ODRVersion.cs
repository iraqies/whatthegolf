using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003AA")]
public class ODRVersion
{
	[Token(Token = "0x4001446")]
	[FieldOffset(Offset = "0x10")]
	public string ResourceName;

	[Token(Token = "0x4001447")]
	[FieldOffset(Offset = "0x18")]
	public string Version;

	[Token(Token = "0x6001163")]
	[Address(RVA = "0x1591248", Offset = "0x1591248", VA = "0x1591248")]
	public ODRVersion(string resourceName, string version)
	{
	}
}
