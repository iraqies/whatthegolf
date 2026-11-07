using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1827B8", Offset = "0x1827B8")]
	public class JsonExtensionDataAttribute : Attribute
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1850C8", Offset = "0x1850C8")]
		private bool WriteData__BackingField;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1850D8", Offset = "0x1850D8")]
		private bool ReadData__BackingField;

		[Token(Token = "0x1700000D")]
		public bool WriteData
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x22E9B98", Offset = "0x22E9B98", VA = "0x22E9B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188784", Offset = "0x188784")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000E")]
		public bool ReadData
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x22E9BA0", Offset = "0x22E9BA0", VA = "0x22E9BA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188794", Offset = "0x188794")]
			get
			{
				return default;
			}
		}
	}
}
