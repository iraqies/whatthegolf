using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000BB5")]
public static class AppleDeviceModel
{
	[Token(Token = "0x4004138")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, string> IOSModels;

	[Token(Token = "0x4004139")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, string> AppleTvModels;

	[Token(Token = "0x400413A")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, string> MacModels;

	[Token(Token = "0x6003873")]
	[Address(RVA = "0x14199D0", Offset = "0x14199D0", VA = "0x14199D0")]
	public static string GetModelNameFromModelId(string modelId)
	{
		return null;
	}
}
