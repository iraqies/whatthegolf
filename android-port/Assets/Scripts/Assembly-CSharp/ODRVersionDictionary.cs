using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20003AB")]
public class ODRVersionDictionary
{
	[Token(Token = "0x20003AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F71C", Offset = "0x3F71C")]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		[Token(Token = "0x4001449")]
		[FieldOffset(Offset = "0x10")]
		public string resourceName;

		[Token(Token = "0x6001166")]
		[Address(RVA = "0x1809FD4", Offset = "0x1809FD4", VA = "0x1809FD4")]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6001167")]
		[Address(RVA = "0x1809FDC", Offset = "0x1809FDC", VA = "0x1809FDC")]
		internal bool _003CGetVersion_003Eb__0(ODRVersion v)
		{
			return default;
		}
	}

	[Token(Token = "0x4001448")]
	[FieldOffset(Offset = "0x10")]
	public List<ODRVersion> Versions;

	[Token(Token = "0x6001164")]
	[Address(RVA = "0x1591280", Offset = "0x1591280", VA = "0x1591280")]
	public ODRVersion GetVersion(string resourceName)
	{
		return null;
	}

	[Token(Token = "0x6001165")]
	[Address(RVA = "0x1591374", Offset = "0x1591374", VA = "0x1591374")]
	public ODRVersionDictionary()
	{
	}
}
