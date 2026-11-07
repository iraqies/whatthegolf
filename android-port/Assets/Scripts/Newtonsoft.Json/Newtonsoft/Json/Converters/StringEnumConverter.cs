using System;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	public class StringEnumConverter : JsonConverter
	{
		[Obsolete]
		public bool CamelCaseText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public NamingStrategy NamingStrategy { get; set; }

		public bool AllowIntegerValues { get; set; }

		public StringEnumConverter()
		{
		}

		[Obsolete]
		public StringEnumConverter(bool camelCaseText)
		{
		}

		public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true)
		{
		}

		public StringEnumConverter(Type namingStrategyType)
		{
		}

		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters)
		{
		}

		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues)
		{
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
