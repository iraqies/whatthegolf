using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18442C", Offset = "0x18442C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x18442C", Offset = "0x18442C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18442C", Offset = "0x18442C")]
	public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184490", Offset = "0x184490")]
		private class LineInfoAnnotation
		{
			[Token(Token = "0x400031D")]
			[FieldOffset(Offset = "0x10")]
			internal readonly int LineNumber;

			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0x14")]
			internal readonly int LinePosition;

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x2339104", Offset = "0x2339104", VA = "0x2339104")]
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
			}
		}

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188300", Offset = "0x188300")]
		private JContainer _parent;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188314", Offset = "0x188314")]
		private JToken _previous;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188328", Offset = "0x188328")]
		private JToken _next;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18833C", Offset = "0x18833C")]
		private object _annotations;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x0")]
		private static readonly JTokenType[] BooleanTypes;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x8")]
		private static readonly JTokenType[] NumberTypes;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x10")]
		private static readonly JTokenType[] BigIntegerTypes;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x18")]
		private static readonly JTokenType[] StringTypes;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x20")]
		private static readonly JTokenType[] GuidTypes;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x28")]
		private static readonly JTokenType[] TimeSpanTypes;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x30")]
		private static readonly JTokenType[] UriTypes;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x38")]
		private static readonly JTokenType[] CharTypes;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x40")]
		private static readonly JTokenType[] DateTimeTypes;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x48")]
		private static readonly JTokenType[] BytesTypes;

		[Token(Token = "0x1700012C")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F7D4", Offset = "0x18F7D4")]
		public JContainer Parent
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x22D3EA8", Offset = "0x22D3EA8", VA = "0x22D3EA8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A8E8", Offset = "0x18A8E8")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x22D3EB0", Offset = "0x22D3EB0", VA = "0x22D3EB0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A924", Offset = "0x18A924")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public JToken Root
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x22CC614", Offset = "0x22CC614", VA = "0x22CC614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		public abstract JTokenType Type
		{
			[Token(Token = "0x60006AE")]
			get;
		}

		[Token(Token = "0x1700012F")]
		public abstract bool HasValues
		{
			[Token(Token = "0x60006AF")]
			get;
		}

		[Token(Token = "0x17000130")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F7E8", Offset = "0x18F7E8")]
		public JToken Next
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x22D3EB8", Offset = "0x22D3EB8", VA = "0x22D3EB8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A938", Offset = "0x18A938")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x22D3EC0", Offset = "0x22D3EC0", VA = "0x22D3EC0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A94C", Offset = "0x18A94C")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000131")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F7FC", Offset = "0x18F7FC")]
		public JToken Previous
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x22D3EC8", Offset = "0x22D3EC8", VA = "0x22D3EC8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A960", Offset = "0x18A960")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x22D3ED0", Offset = "0x22D3ED0", VA = "0x22D3ED0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A974", Offset = "0x18A974")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public string Path
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x22D3ED8", Offset = "0x22D3ED8", VA = "0x22D3ED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000133")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F810", Offset = "0x18F810")]
		public virtual JToken First
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x22D41C4", Offset = "0x22D41C4", VA = "0x22D41C4", Slot = "14")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A988", Offset = "0x18A988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F824", Offset = "0x18F824")]
		public virtual JToken Last
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x22D4280", Offset = "0x22D4280", VA = "0x22D4280", Slot = "15")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A99C", Offset = "0x18A99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x22DD7B0", Offset = "0x22DD7B0", VA = "0x22DD7B0", Slot = "7")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber();
			}
		}

		[Token(Token = "0x17000136")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x22DD814", Offset = "0x22DD814", VA = "0x22DD814", Slot = "8")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition();
			}
		}

		[Token(Token = "0x60006AD")]
		internal abstract JToken CloneToken();

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x22CB944", Offset = "0x22CB944", VA = "0x22CB944")]
		internal JToken()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x22D433C", Offset = "0x22D433C", VA = "0x22D433C", Slot = "16")]
		public virtual JEnumerable<JToken> Children()
		{
			return default;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x22D10FC", Offset = "0x22D10FC", VA = "0x22D10FC")]
		public void Remove()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x22CF354", Offset = "0x22CF354", VA = "0x22CF354")]
		public void Replace(JToken value)
		{
		}

		[Token(Token = "0x60006BB")]
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x22D43A0", Offset = "0x22D43A0", VA = "0x22D43A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x22D4478", Offset = "0x22D4478", VA = "0x22D4478")]
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x22D46C0", Offset = "0x22D46C0", VA = "0x22D46C0")]
		private static JValue EnsureValue(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x22D47EC", Offset = "0x22D47EC", VA = "0x22D47EC")]
		private static string GetType(JToken token)
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x22D4914", Offset = "0x22D4914", VA = "0x22D4914")]
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return default;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x22D49D8", Offset = "0x22D49D8", VA = "0x22D49D8")]
		public static explicit operator bool(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x22D4CDC", Offset = "0x22D4CDC", VA = "0x22D4CDC")]
		public static explicit operator DateTimeOffset(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x22D500C", Offset = "0x22D500C", VA = "0x22D500C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A9B0", Offset = "0x18A9B0")]
		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x22D5380", Offset = "0x22D5380", VA = "0x22D5380")]
		public static explicit operator long(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x22D5658", Offset = "0x22D5658", VA = "0x22D5658")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A9C4", Offset = "0x18A9C4")]
		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x22D5970", Offset = "0x22D5970", VA = "0x22D5970")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A9D8", Offset = "0x18A9D8")]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x22D5D4C", Offset = "0x22D5D4C", VA = "0x22D5D4C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A9EC", Offset = "0x18A9EC")]
		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x22D60A4", Offset = "0x22D60A4", VA = "0x22D60A4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA00", Offset = "0x18AA00")]
		public static explicit operator double?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x22D63E0", Offset = "0x22D63E0", VA = "0x22D63E0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA14", Offset = "0x18AA14")]
		public static explicit operator char?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x22D6720", Offset = "0x22D6720", VA = "0x22D6720")]
		public static explicit operator int(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x22D69F8", Offset = "0x22D69F8", VA = "0x22D69F8")]
		public static explicit operator short(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x22D6CD0", Offset = "0x22D6CD0", VA = "0x22D6CD0")]
		public static explicit operator ushort(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x22D6FA8", Offset = "0x22D6FA8", VA = "0x22D6FA8")]
		public static explicit operator char(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x22D7280", Offset = "0x22D7280", VA = "0x22D7280")]
		public static explicit operator byte(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x22D7558", Offset = "0x22D7558", VA = "0x22D7558")]
		public static explicit operator sbyte(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x22D7830", Offset = "0x22D7830", VA = "0x22D7830")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA28", Offset = "0x18AA28")]
		public static explicit operator int?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x22D7B70", Offset = "0x22D7B70", VA = "0x22D7B70")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA3C", Offset = "0x18AA3C")]
		public static explicit operator short?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x22D7EB0", Offset = "0x22D7EB0", VA = "0x22D7EB0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA50", Offset = "0x18AA50")]
		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x22D81F0", Offset = "0x22D81F0", VA = "0x22D81F0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA64", Offset = "0x18AA64")]
		public static explicit operator byte?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x22D8530", Offset = "0x22D8530", VA = "0x22D8530")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA78", Offset = "0x18AA78")]
		public static explicit operator sbyte?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x22D8870", Offset = "0x22D8870", VA = "0x22D8870")]
		public static explicit operator DateTime(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x22D8B30", Offset = "0x22D8B30", VA = "0x22D8B30")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AA8C", Offset = "0x18AA8C")]
		public static explicit operator long?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x22D8E70", Offset = "0x22D8E70", VA = "0x22D8E70")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AAA0", Offset = "0x18AAA0")]
		public static explicit operator float?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x22D91AC", Offset = "0x22D91AC", VA = "0x22D91AC")]
		public static explicit operator decimal(JToken value)
		{
			return 0m;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x22D9484", Offset = "0x22D9484", VA = "0x22D9484")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AAB4", Offset = "0x18AAB4")]
		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x22D97C4", Offset = "0x22D97C4", VA = "0x22D97C4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AAC8", Offset = "0x18AAC8")]
		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x22D9B04", Offset = "0x22D9B04", VA = "0x22D9B04")]
		public static explicit operator double(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x22D9DDC", Offset = "0x22D9DDC", VA = "0x22D9DDC")]
		public static explicit operator float(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x22DA0B4", Offset = "0x22DA0B4", VA = "0x22DA0B4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AADC", Offset = "0x18AADC")]
		public static explicit operator string(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x22DA44C", Offset = "0x22DA44C", VA = "0x22DA44C")]
		public static explicit operator uint(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x22DA724", Offset = "0x22DA724", VA = "0x22DA724")]
		public static explicit operator ulong(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x22DA9FC", Offset = "0x22DA9FC", VA = "0x22DA9FC")]
		public static explicit operator Guid(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x22DACF0", Offset = "0x22DACF0", VA = "0x22DACF0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AAF0", Offset = "0x18AAF0")]
		public static explicit operator Guid?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x22DB05C", Offset = "0x22DB05C", VA = "0x22DB05C")]
		public static explicit operator TimeSpan(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x22DB33C", Offset = "0x22DB33C", VA = "0x22DB33C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AB04", Offset = "0x18AB04")]
		public static explicit operator TimeSpan?(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x22DB680", Offset = "0x22DB680", VA = "0x22DB680")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AB18", Offset = "0x18AB18")]
		public static explicit operator Uri(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x22DB978", Offset = "0x22DB978", VA = "0x22DB978")]
		private static BigInteger ToBigInteger(JToken value)
		{
			return default;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x22DBB88", Offset = "0x22DBB88", VA = "0x22DBB88")]
		private static BigInteger? ToBigIntegerNullable(JToken value)
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x22DBE24", Offset = "0x22DBE24", VA = "0x22DBE24", Slot = "5")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x22DBED4", Offset = "0x22DBED4", VA = "0x22DBED4", Slot = "4")]
		private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x22DBF54", Offset = "0x22DBF54", VA = "0x22DBF54")]
		public JsonReader CreateReader()
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x22DC068", Offset = "0x22DC068", VA = "0x22DC068")]
		public object ToObject(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x22DCE50", Offset = "0x22DCE50", VA = "0x22DCE50")]
		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x22DD04C", Offset = "0x22DD04C", VA = "0x22DD04C")]
		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x22DD0C8", Offset = "0x22DD0C8", VA = "0x22DD0C8")]
		public static JToken ReadFrom(JsonReader reader, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E0F4", Offset = "0x18E0F4")] JsonLoadSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x22CABD4", Offset = "0x22CABD4", VA = "0x22CABD4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AB2C", Offset = "0x18AB2C")]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x22DD488", Offset = "0x22DD488", VA = "0x22DD488")]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x22DD74C", Offset = "0x22DD74C", VA = "0x22DD74C", Slot = "6")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x22DD7B0", Offset = "0x22DD7B0", VA = "0x22DD7B0", Slot = "7")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber()
		{
			return default;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x22DD814", Offset = "0x22DD814", VA = "0x22DD814", Slot = "8")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition()
		{
			return default;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x22DD878", Offset = "0x22DD878", VA = "0x22DD878", Slot = "18")]
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x22DD94C", Offset = "0x22DD94C", VA = "0x22DD94C", Slot = "10")]
		private DynamicMetaObject System_002EDynamic_002EIDynamicMetaObjectProvider_002EGetMetaObject(Expression parameter)
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x22DD95C", Offset = "0x22DD95C", VA = "0x22DD95C", Slot = "9")]
		private object System_002EICloneable_002EClone()
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x22DD968", Offset = "0x22DD968", VA = "0x22DD968")]
		public JToken DeepClone()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x22DD508", Offset = "0x22DD508", VA = "0x22DD508")]
		public void AddAnnotation(object annotation)
		{
		}

		[Token(Token = "0x60006F8")]
		public T Annotation<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x22CBCBC", Offset = "0x22CBCBC", VA = "0x22CBCBC")]
		internal void CopyAnnotations(JToken target, JToken source)
		{
		}
	}
}
