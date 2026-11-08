using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonFormatterConverter : IFormatterConverter
	{
		private readonly JsonSerializerInternalReader _reader;

		private readonly JsonISerializableContract _contract;

		private readonly JsonProperty _member;

		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
		}

		private T GetTokenValue<T>(object value)
		{
			return default;
		}

		public object Convert(object value, Type type)
		{
			return null;
		}

		public object Convert(object value, TypeCode typeCode) => null;
		public byte ToByte(object value) => 0;
		public char ToChar(object value) => '\0';
		public DateTime ToDateTime(object value) => default;
		public decimal ToDecimal(object value) => 0m;
		public double ToDouble(object value) => 0.0;
		public short ToInt16(object value) => 0;
		public sbyte ToSByte(object value) => 0;
		public ushort ToUInt16(object value) => 0;
		public uint ToUInt32(object value) => 0u;
		public ulong ToUInt64(object value) => 0uL;

		public bool ToBoolean(object value)
		{
			return false;
		}

		public int ToInt32(object value)
		{
			return 0;
		}

		public long ToInt64(object value)
		{
			return 0L;
		}

		public float ToSingle(object value)
		{
			return 0f;
		}

		public string ToString(object value)
		{
			return null;
		}
	}
}
