using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183094", Offset = "0x183094")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183094", Offset = "0x183094")]
	internal static class EnumUtils
	{
		[Serializable]
		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1830D4", Offset = "0x1830D4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40001BD")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185904", Offset = "0x185904")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40001BE")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185918", Offset = "0x185918")]
			public static Func<EnumMemberAttribute, string> _003C_003E9__3_0;

			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2338298", Offset = "0x2338298", VA = "0x2338298")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x23382A0", Offset = "0x23382A0", VA = "0x23382A0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188DE0", Offset = "0x188DE0")]
			internal string _003CInitializeValuesAndNames_003Eb__3_0(EnumMemberAttribute a)
			{
				return null;
			}
		}

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185888", Offset = "0x185888")]
		private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x8")]
		private static CamelCaseNamingStrategy _camelCaseNamingStrategy;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x22C53DC", Offset = "0x22C53DC", VA = "0x22C53DC")]
		private static EnumInfo InitializeValuesAndNames([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B904", Offset = "0x18B904")] StructMultiKey<Type, NamingStrategy> key)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x22C5D1C", Offset = "0x22C5D1C", VA = "0x22C5D1C")]
		public static bool TryToString(Type enumType, object value, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B97C", Offset = "0x18B97C")] NamingStrategy namingStrategy, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B990", Offset = "0x18B990")] out string name)
		{
			return default;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x22C5EBC", Offset = "0x22C5EBC", VA = "0x22C5EBC")]
		private static string InternalFlagsFormat(EnumInfo entry, ulong result)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x22C6078", Offset = "0x22C6078", VA = "0x22C6078")]
		public static EnumInfo GetEnumValuesAndNames(Type enumType)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x22C59AC", Offset = "0x22C59AC", VA = "0x22C59AC")]
		private static ulong ToUInt64(object value)
		{
			return default;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x22C6148", Offset = "0x22C6148", VA = "0x22C6148")]
		public static object ParseEnum(Type enumType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B9A4", Offset = "0x18B9A4")] NamingStrategy namingStrategy, string value, bool disallowNumber)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x22C6B20", Offset = "0x22C6B20", VA = "0x22C6B20")]
		private static int? MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x22C6A14", Offset = "0x22C6A14", VA = "0x22C6A14")]
		private static int? FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}
	}
}
