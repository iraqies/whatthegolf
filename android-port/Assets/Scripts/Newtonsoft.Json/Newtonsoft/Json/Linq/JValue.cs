using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184524", Offset = "0x184524")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184524", Offset = "0x184524")]
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184564", Offset = "0x184564")]
		private class JValueDynamicProxy : DynamicProxy<JValue>
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x233913C", Offset = "0x233913C", VA = "0x233913C")]
			public JValueDynamicProxy()
			{
			}
		}

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x30")]
		private JTokenType _valueType;

		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18838C", Offset = "0x18838C")]
		private object _value;

		[Token(Token = "0x1700013C")]
		public override bool HasValues
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x22E0404", Offset = "0x22E0404", VA = "0x22E0404", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700013D")]
		public override JTokenType Type
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x22E1248", Offset = "0x22E1248", VA = "0x22E1248", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700013E")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F84C", Offset = "0x18F84C")]
		public object Value
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x22E1250", Offset = "0x22E1250", VA = "0x22E1250")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC08", Offset = "0x18AC08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x22D3A7C", Offset = "0x22D3A7C", VA = "0x22D3A7C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18ABB8", Offset = "0x18ABB8")]
		internal JValue(object value, JTokenType type)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x22D3918", Offset = "0x22D3918", VA = "0x22D3918")]
		public JValue(JValue other)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x22CE654", Offset = "0x22CE654", VA = "0x22CE654")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18ABCC", Offset = "0x18ABCC")]
		public JValue(object value)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x22E040C", Offset = "0x22E040C", VA = "0x22E040C")]
		private static int CompareBigInteger(BigInteger i1, object i2)
		{
			return default;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x22E069C", Offset = "0x22E069C", VA = "0x22E069C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18ABE0", Offset = "0x18ABE0")]
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			return default;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x22E1060", Offset = "0x22E1060", VA = "0x22E1060")]
		private static int CompareFloat(object objA, object objB)
		{
			return default;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x22E1170", Offset = "0x22E1170", VA = "0x22E1170", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x22CED24", Offset = "0x22CED24", VA = "0x22CED24")]
		public static JValue CreateComment([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E108", Offset = "0x18E108")] string value)
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x22CC564", Offset = "0x22CC564", VA = "0x22CC564")]
		public static JValue CreateNull()
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x22CEDD8", Offset = "0x22CEDD8", VA = "0x22CEDD8")]
		public static JValue CreateUndefined()
		{
			return null;
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x22DFF54", Offset = "0x22DFF54", VA = "0x22DFF54")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18ABF4", Offset = "0x18ABF4")]
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return default;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x22E11D4", Offset = "0x22E11D4", VA = "0x22E11D4")]
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return default;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x22E1258", Offset = "0x22E1258", VA = "0x22E1258", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x22E1C88", Offset = "0x22E1C88", VA = "0x22E1C88")]
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return default;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x22E1CF0", Offset = "0x22E1CF0", VA = "0x22E1CF0", Slot = "19")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC1C", Offset = "0x18AC1C")]
		public bool Equals(JValue other)
		{
			return default;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x22E1D58", Offset = "0x22E1D58", VA = "0x22E1D58", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x22E1E2C", Offset = "0x22E1E2C", VA = "0x22E1E2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x22E1E44", Offset = "0x22E1E44", VA = "0x22E1E44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x22E1EB0", Offset = "0x22E1EB0", VA = "0x22E1EB0", Slot = "38")]
		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x22E1EBC", Offset = "0x22E1EBC", VA = "0x22E1EBC", Slot = "20")]
		public string ToString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E12C", Offset = "0x18E12C")] string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x22E1FE4", Offset = "0x22E1FE4", VA = "0x22E1FE4", Slot = "18")]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x22E209C", Offset = "0x22E209C", VA = "0x22E209C", Slot = "21")]
		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x22E2168", Offset = "0x22E2168", VA = "0x22E2168", Slot = "22")]
		public int CompareTo(JValue obj)
		{
			return default;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x22E2198", Offset = "0x22E2198", VA = "0x22E2198", Slot = "23")]
		private TypeCode System_002EIConvertible_002EGetTypeCode()
		{
			return default;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x22E2264", Offset = "0x22E2264", VA = "0x22E2264", Slot = "24")]
		private bool System_002EIConvertible_002EToBoolean(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x22E22DC", Offset = "0x22E22DC", VA = "0x22E22DC", Slot = "25")]
		private char System_002EIConvertible_002EToChar(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x22E2354", Offset = "0x22E2354", VA = "0x22E2354", Slot = "26")]
		private sbyte System_002EIConvertible_002EToSByte(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x22E23CC", Offset = "0x22E23CC", VA = "0x22E23CC", Slot = "27")]
		private byte System_002EIConvertible_002EToByte(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x22E2444", Offset = "0x22E2444", VA = "0x22E2444", Slot = "28")]
		private short System_002EIConvertible_002EToInt16(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x22E24BC", Offset = "0x22E24BC", VA = "0x22E24BC", Slot = "29")]
		private ushort System_002EIConvertible_002EToUInt16(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x22E2534", Offset = "0x22E2534", VA = "0x22E2534", Slot = "30")]
		private int System_002EIConvertible_002EToInt32(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x22E25AC", Offset = "0x22E25AC", VA = "0x22E25AC", Slot = "31")]
		private uint System_002EIConvertible_002EToUInt32(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x22E2624", Offset = "0x22E2624", VA = "0x22E2624", Slot = "32")]
		private long System_002EIConvertible_002EToInt64(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x22E269C", Offset = "0x22E269C", VA = "0x22E269C", Slot = "33")]
		private ulong System_002EIConvertible_002EToUInt64(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x22E2714", Offset = "0x22E2714", VA = "0x22E2714", Slot = "34")]
		private float System_002EIConvertible_002EToSingle(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x22E278C", Offset = "0x22E278C", VA = "0x22E278C", Slot = "35")]
		private double System_002EIConvertible_002EToDouble(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x22E2804", Offset = "0x22E2804", VA = "0x22E2804", Slot = "36")]
		private decimal System_002EIConvertible_002EToDecimal(IFormatProvider provider)
		{
			return 0m;
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x22E287C", Offset = "0x22E287C", VA = "0x22E287C", Slot = "37")]
		private DateTime System_002EIConvertible_002EToDateTime(IFormatProvider provider)
		{
			return default;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x22E28F4", Offset = "0x22E28F4", VA = "0x22E28F4", Slot = "39")]
		private object System_002EIConvertible_002EToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}
	}
}
