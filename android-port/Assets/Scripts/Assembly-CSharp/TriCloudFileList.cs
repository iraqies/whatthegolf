using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000CF3")]
public class TriCloudFileList
{
	[Token(Token = "0x400465E")]
	[FieldOffset(Offset = "0x10")]
	public List<string> files;

	[Token(Token = "0x400465F")]
	[FieldOffset(Offset = "0x18")]
	public List<long> modifiedTimestamps;

	[Token(Token = "0x6003D40")]
	[Address(RVA = "0x172CF24", Offset = "0x172CF24", VA = "0x172CF24")]
	public TriCloudFileList()
	{
	}
}
