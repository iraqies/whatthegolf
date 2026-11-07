using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001E")]
	[Attribute(Name = "NullableAttribute", RVA = "0x182854", Offset = "0x182854")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x182854", Offset = "0x182854")]
	internal struct JsonPosition
	{
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] SpecialCharacters;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		internal JsonContainerType Type;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x4")]
		internal int Position;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "NullableAttribute", RVA = "0x1850E8", Offset = "0x1850E8")]
		internal string PropertyName;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		internal bool HasIndex;

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x22EA9B4", Offset = "0x22EA9B4", VA = "0x22EA9B4")]
		public JsonPosition(JsonContainerType type)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x22EAA4C", Offset = "0x22EAA4C", VA = "0x22EAA4C")]
		internal int CalculateLength()
		{
			return default;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x22EAAEC", Offset = "0x22EAAEC", VA = "0x22EAAEC")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x1887B8", Offset = "0x1887B8")]
		internal void WriteTo([Attribute(Name = "NullableAttribute", RVA = "0x18B23C", Offset = "0x18B23C")] StringBuilder sb, ref StringWriter writer, ref char[] buffer)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x22EAA3C", Offset = "0x22EAA3C", VA = "0x22EAA3C")]
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return default;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x22EAD2C", Offset = "0x22EAD2C", VA = "0x22EAD2C")]
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x22EAFE8", Offset = "0x22EAFE8", VA = "0x22EAFE8")]
		internal static string FormatMessage([Attribute(Name = "NullableAttribute", RVA = "0x18B250", Offset = "0x18B250")] IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}
	}
}
