using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1844E4", Offset = "0x1844E4")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1844E4", Offset = "0x1844E4")]
	public class JTokenWriter : JsonWriter
	{
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x60")]
		private JContainer _token;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x68")]
		private JContainer _parent;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x70")]
		private JValue _value;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x78")]
		private JToken _current;

		[Token(Token = "0x1700013B")]
		public JToken Token
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x22DEAFC", Offset = "0x22DEAFC", VA = "0x22DEAFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x22DEB14", Offset = "0x22DEB14", VA = "0x22DEB14")]
		public JTokenWriter()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x22DEB90", Offset = "0x22DEB90", VA = "0x22DEB90", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x22DEB98", Offset = "0x22DEB98", VA = "0x22DEB98", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x22DEC20", Offset = "0x22DEC20", VA = "0x22DEC20")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AB68", Offset = "0x18AB68")]
		private void AddParent(JContainer container)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x22DEC60", Offset = "0x22DEC60", VA = "0x22DEC60")]
		private void RemoveParent()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x22DECBC", Offset = "0x22DECBC", VA = "0x22DECBC", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x22DED44", Offset = "0x22DED44", VA = "0x22DED44", Slot = "11")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AB7C", Offset = "0x18AB7C")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x22DEDD8", Offset = "0x22DEDD8", VA = "0x22DEDD8", Slot = "17")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x22DEE34", Offset = "0x22DEE34", VA = "0x22DEE34", Slot = "13")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AB90", Offset = "0x18AB90")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x22DEF2C", Offset = "0x22DEF2C", VA = "0x22DEF2C")]
		private void AddValue(object value, JsonToken token)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x22DEFFC", Offset = "0x22DEFFC", VA = "0x22DEFFC")]
		internal void AddValue(JValue value, JsonToken token)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x22DF0A0", Offset = "0x22DF0A0", VA = "0x22DF0A0", Slot = "62")]
		public override void WriteValue(object value)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x22DF144", Offset = "0x22DF144", VA = "0x22DF144", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x22DF170", Offset = "0x22DF170", VA = "0x22DF170", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x22DF19C", Offset = "0x22DF19C", VA = "0x22DF19C", Slot = "23")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x22DF270", Offset = "0x22DF270", VA = "0x22DF270", Slot = "63")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x22DF2A8", Offset = "0x22DF2A8", VA = "0x22DF2A8", Slot = "25")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x22DF2DC", Offset = "0x22DF2DC", VA = "0x22DF2DC", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x22DF364", Offset = "0x22DF364", VA = "0x22DF364", Slot = "27")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x22DF3EC", Offset = "0x22DF3EC", VA = "0x22DF3EC", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x22DF474", Offset = "0x22DF474", VA = "0x22DF474", Slot = "29")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x22DF4FC", Offset = "0x22DF4FC", VA = "0x22DF4FC", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x22DF58C", Offset = "0x22DF58C", VA = "0x22DF58C", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x22DF61C", Offset = "0x22DF61C", VA = "0x22DF61C", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x22DF6A4", Offset = "0x22DF6A4", VA = "0x22DF6A4", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x22DF72C", Offset = "0x22DF72C", VA = "0x22DF72C", Slot = "34")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x22DF7B4", Offset = "0x22DF7B4", VA = "0x22DF7B4", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x22DF85C", Offset = "0x22DF85C", VA = "0x22DF85C", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x22DF8E4", Offset = "0x22DF8E4", VA = "0x22DF8E4", Slot = "37")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x22DF96C", Offset = "0x22DF96C", VA = "0x22DF96C", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x22DFA04", Offset = "0x22DFA04", VA = "0x22DFA04", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x22DFAD0", Offset = "0x22DFAD0", VA = "0x22DFAD0", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x22DFB68", Offset = "0x22DFB68", VA = "0x22DFB68", Slot = "60")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x22DFB9C", Offset = "0x22DFB9C", VA = "0x22DFB9C", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x22DFC24", Offset = "0x22DFC24", VA = "0x22DFC24", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x22DFCBC", Offset = "0x22DFCBC", VA = "0x22DFCBC", Slot = "61")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x22DFCF0", Offset = "0x22DFCF0", VA = "0x22DFCF0", Slot = "16")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18ABA4", Offset = "0x18ABA4")]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}
	}
}
