using System;
using System.Globalization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184814", Offset = "0x184814")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184814", Offset = "0x184814")]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x4000355")]
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x10")]
		private DateTimeStyles _dateTimeStyles;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1883F0", Offset = "0x1883F0")]
		private string _dateTimeFormat;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188404", Offset = "0x188404")]
		private CultureInfo _culture;

		[Token(Token = "0x17000141")]
		public DateTimeStyles DateTimeStyles
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x22C97A0", Offset = "0x22C97A0", VA = "0x22C97A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x22C97A8", Offset = "0x22C97A8", VA = "0x22C97A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F860", Offset = "0x18F860")]
		public string DateTimeFormat
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x22C97B0", Offset = "0x22C97B0", VA = "0x22C97B0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC6C", Offset = "0x18AC6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x22C9808", Offset = "0x22C9808", VA = "0x22C9808")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC80", Offset = "0x18AC80")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x22C9848", Offset = "0x22C9848", VA = "0x22C9848")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x22C98BC", Offset = "0x22C98BC", VA = "0x22C98BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x22C98C4", Offset = "0x22C98C4", VA = "0x22C98C4", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E258", Offset = "0x18E258")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x22C9BF4", Offset = "0x22C9BF4", VA = "0x22C9BF4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E26C", Offset = "0x18E26C")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x22CA2CC", Offset = "0x22CA2CC", VA = "0x22CA2CC")]
		public IsoDateTimeConverter()
		{
		}
	}
}
