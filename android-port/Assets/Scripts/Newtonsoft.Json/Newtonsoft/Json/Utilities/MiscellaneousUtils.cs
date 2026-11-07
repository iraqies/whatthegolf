using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183348", Offset = "0x183348")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183348", Offset = "0x183348")]
	internal static class MiscellaneousUtils
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x231BB40", Offset = "0x231BB40", VA = "0x231BB40")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1890EC", Offset = "0x1890EC")]
		public static bool ValueEquals(object objA, object objB)
		{
			return default;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2316EE4", Offset = "0x2316EE4", VA = "0x2316EE4")]
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x231BED4", Offset = "0x231BED4", VA = "0x231BED4")]
		public static string ToString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C284", Offset = "0x18C284")] object value)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x231BF88", Offset = "0x231BF88", VA = "0x231BF88")]
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			return default;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x231C050", Offset = "0x231C050", VA = "0x231C050")]
		public static string GetPrefix(string qualifiedName)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x231C174", Offset = "0x231C174", VA = "0x231C174")]
		public static string GetLocalName(string qualifiedName)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x231C0DC", Offset = "0x231C0DC", VA = "0x231C0DC")]
		public static void GetQualifiedNameParts(string qualifiedName, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C298", Offset = "0x18C298")] out string prefix, out string localName)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x231C1F4", Offset = "0x231C1F4", VA = "0x231C1F4")]
		internal static RegexOptions GetRegexOptions(string optionsText)
		{
			return default;
		}
	}
}
