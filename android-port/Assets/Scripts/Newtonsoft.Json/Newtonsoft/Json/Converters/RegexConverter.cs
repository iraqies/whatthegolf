using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Newtonsoft.Json.Bson;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1848D4", Offset = "0x1848D4")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1848D4", Offset = "0x1848D4")]
	public class RegexConverter : JsonConverter
	{
		[Token(Token = "0x400035C")]
		private const string PatternName = "Pattern";

		[Token(Token = "0x400035D")]
		private const string OptionsName = "Options";

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2321400", Offset = "0x2321400", VA = "0x2321400", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E2D0", Offset = "0x18E2D0")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x232185C", Offset = "0x232185C", VA = "0x232185C")]
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return default;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2321528", Offset = "0x2321528", VA = "0x2321528")]
		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2321670", Offset = "0x2321670", VA = "0x2321670")]
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2321868", Offset = "0x2321868", VA = "0x2321868", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E2E4", Offset = "0x18E2E4")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2321B98", Offset = "0x2321B98", VA = "0x2321B98")]
		private object ReadRegexString(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2321918", Offset = "0x2321918", VA = "0x2321918")]
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2321D7C", Offset = "0x2321D7C", VA = "0x2321D7C", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2321DF8", Offset = "0x2321DF8", VA = "0x2321DF8")]
		private bool IsRegex(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2321E94", Offset = "0x2321E94", VA = "0x2321E94")]
		public RegexConverter()
		{
		}
	}
}
