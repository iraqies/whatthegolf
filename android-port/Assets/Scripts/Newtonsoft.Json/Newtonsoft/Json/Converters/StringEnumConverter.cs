using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184914", Offset = "0x184914")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184914", Offset = "0x184914")]
	public class StringEnumConverter : JsonConverter
	{
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188418", Offset = "0x188418")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188418", Offset = "0x188418")]
		private NamingStrategy NamingStrategy__BackingField;

		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188454", Offset = "0x188454")]
		private bool AllowIntegerValues__BackingField;

		[Token(Token = "0x17000144")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x18F874", Offset = "0x18F874")]
		public bool CamelCaseText
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x2322A3C", Offset = "0x2322A3C", VA = "0x2322A3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x2322ABC", Offset = "0x2322ABC", VA = "0x2322ABC")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F8AC", Offset = "0x18F8AC")]
		public NamingStrategy NamingStrategy
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x2322B90", Offset = "0x2322B90", VA = "0x2322B90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18AC94", Offset = "0x18AC94")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC94", Offset = "0x18AC94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x2322B98", Offset = "0x2322B98", VA = "0x2322B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18ACD0", Offset = "0x18ACD0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18ACD0", Offset = "0x18ACD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public bool AllowIntegerValues
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x2322BA0", Offset = "0x2322BA0", VA = "0x2322BA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18AD0C", Offset = "0x18AD0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x2322BA8", Offset = "0x2322BA8", VA = "0x2322BA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18AD1C", Offset = "0x18AD1C")]
			set
			{
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2322BB0", Offset = "0x2322BB0", VA = "0x2322BB0")]
		public StringEnumConverter()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2322BC0", Offset = "0x2322BC0", VA = "0x2322BC0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x18AD2C", Offset = "0x18AD2C")]
		public StringEnumConverter(bool camelCaseText)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2322C40", Offset = "0x2322C40", VA = "0x2322C40")]
		public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2322C84", Offset = "0x2322C84", VA = "0x2322C84")]
		public StringEnumConverter(Type namingStrategyType)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2322DB8", Offset = "0x2322DB8", VA = "0x2322DB8")]
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2322EA0", Offset = "0x2322EA0", VA = "0x2322EA0")]
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2322F98", Offset = "0x2322F98", VA = "0x2322F98", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E2F8", Offset = "0x18E2F8")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x23232A0", Offset = "0x23232A0", VA = "0x23232A0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E30C", Offset = "0x18E30C")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x23238D4", Offset = "0x23238D4", VA = "0x23238D4", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}
	}
}
