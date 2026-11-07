using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		private class JValueDynamicProxy : DynamicProxy<JValue>
		{
		}

		private JTokenType _valueType;

		private object _value;

		public override bool HasValues => false;

		public override JTokenType Type => JTokenType.None;

		public object Value => null;

		internal JValue(object value, JTokenType type)
		{
		}

		public JValue(JValue other)
		{
		}

		public JValue(object value)
		{
		}

		private static int CompareBigInteger(BigInteger i1, object i2)
		{
			return 0;
		}

		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			return 0;
		}

		private static int CompareFloat(object objA, object objB)
		{
			return 0;
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public static JValue CreateComment(string value)
		{
			return null;
		}

		public static JValue CreateNull()
		{
			return null;
		}

		public static JValue CreateUndefined()
		{
			return null;
		}

		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return JTokenType.None;
		}

		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return JTokenType.None;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return false;
		}

		public bool Equals(JValue other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(JValue obj)
		{
			return 0;
		}

		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Empty;
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return false;
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return '\0';
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return 0;
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return 0;
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return 0;
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return 0;
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return 0;
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return 0u;
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return 0L;
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return 0uL;
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return 0f;
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return 0.0;
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return 0m;
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return default;
		}

		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}
	}
}
