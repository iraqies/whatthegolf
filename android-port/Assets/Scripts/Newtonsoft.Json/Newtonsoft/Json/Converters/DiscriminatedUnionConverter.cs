using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18470C", Offset = "0x18470C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18470C", Offset = "0x18470C")]
	public class DiscriminatedUnionConverter : JsonConverter
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18474C", Offset = "0x18474C")]
		internal class Union
		{
			[Token(Token = "0x4000346")]
			[FieldOffset(Offset = "0x10")]
			public readonly FSharpFunction TagReader;

			[Token(Token = "0x4000347")]
			[FieldOffset(Offset = "0x18")]
			public readonly List<UnionCase> Cases;

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x23373A8", Offset = "0x23373A8", VA = "0x23373A8")]
			public Union(FSharpFunction tagReader, List<UnionCase> cases)
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184760", Offset = "0x184760")]
		internal class UnionCase
		{
			[Token(Token = "0x4000348")]
			[FieldOffset(Offset = "0x10")]
			public readonly int Tag;

			[Token(Token = "0x4000349")]
			[FieldOffset(Offset = "0x18")]
			public readonly string Name;

			[Token(Token = "0x400034A")]
			[FieldOffset(Offset = "0x20")]
			public readonly PropertyInfo[] Fields;

			[Token(Token = "0x400034B")]
			[FieldOffset(Offset = "0x28")]
			public readonly FSharpFunction FieldReader;

			[Token(Token = "0x400034C")]
			[FieldOffset(Offset = "0x30")]
			public readonly FSharpFunction Constructor;

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x23373E0", Offset = "0x23373E0", VA = "0x23373E0")]
			public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184774", Offset = "0x184774")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x400034D")]
			[FieldOffset(Offset = "0x10")]
			public int tag;

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x2337350", Offset = "0x2337350", VA = "0x2337350")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x2337358", Offset = "0x2337358", VA = "0x2337358")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC44", Offset = "0x18AC44")]
			internal bool _003CWriteJson_003Eb__0(UnionCase c)
			{
				return default;
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184784", Offset = "0x184784")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x400034E")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1883B4", Offset = "0x1883B4")]
			public string caseName;

			[Token(Token = "0x400034F")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1883C8", Offset = "0x1883C8")]
			public Func<UnionCase, bool> _003C_003E9__0;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x233737C", Offset = "0x233737C", VA = "0x233737C")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x2337384", Offset = "0x2337384", VA = "0x2337384")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC58", Offset = "0x18AC58")]
			internal bool _003CReadJson_003Eb__0(UnionCase c)
			{
				return default;
			}
		}

		[Token(Token = "0x4000342")]
		private const string CasePropertyName = "Case";

		[Token(Token = "0x4000343")]
		private const string FieldsPropertyName = "Fields";

		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, Union> UnionCache;

		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x22C2AC4", Offset = "0x22C2AC4", VA = "0x22C2AC4")]
		private static Type CreateUnionTypeLookup(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x22C2D1C", Offset = "0x22C2D1C", VA = "0x22C2D1C")]
		private static Union CreateUnion(Type t)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x22C358C", Offset = "0x22C358C", VA = "0x22C358C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E1E0", Offset = "0x18E1E0")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x22C3B74", Offset = "0x22C3B74", VA = "0x22C3B74", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E1F4", Offset = "0x18E1F4")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x22C4300", Offset = "0x22C4300", VA = "0x22C4300", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x22C1768", Offset = "0x22C1768", VA = "0x22C1768")]
		public DiscriminatedUnionConverter()
		{
		}
	}
}
