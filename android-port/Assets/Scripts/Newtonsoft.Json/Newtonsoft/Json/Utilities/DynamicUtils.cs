using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182F30", Offset = "0x182F30")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182F30", Offset = "0x182F30")]
	internal static class DynamicUtils
	{
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182F80", Offset = "0x182F80")]
		internal static class BinderWrapper
		{
			[Token(Token = "0x40001AF")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185838", Offset = "0x185838")]
			private static object _getCSharpArgumentInfoArray;

			[Token(Token = "0x40001B0")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18584C", Offset = "0x18584C")]
			private static object _setCSharpArgumentInfoArray;

			[Token(Token = "0x40001B1")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185860", Offset = "0x185860")]
			private static MethodCall<object, object> _getMemberCall;

			[Token(Token = "0x40001B2")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185874", Offset = "0x185874")]
			private static MethodCall<object, object> _setMemberCall;

			[Token(Token = "0x40001B3")]
			[FieldOffset(Offset = "0x20")]
			private static bool _init;

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2337434", Offset = "0x2337434", VA = "0x2337434")]
			private static void Init()
			{
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x233764C", Offset = "0x233764C", VA = "0x233764C")]
			private static object CreateSharpArgumentInfoArray(params int[] values)
			{
				return null;
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x2337938", Offset = "0x2337938", VA = "0x2337938")]
			private static void CreateMemberCalls()
			{
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x2337E18", Offset = "0x2337E18", VA = "0x2337E18")]
			public static CallSiteBinder GetMember(string name, Type context)
			{
				return null;
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2338028", Offset = "0x2338028", VA = "0x2338028")]
			public static CallSiteBinder SetMember(string name, Type context)
			{
				return null;
			}
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x22C490C", Offset = "0x22C490C", VA = "0x22C490C")]
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
		{
			return null;
		}
	}
}
