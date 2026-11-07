using System;
using Newtonsoft.Json;

namespace Wwise2
{
	internal class ParseStringConverter : JsonConverter
	{
		public static readonly ParseStringConverter Singleton;

		public override bool CanConvert(Type t)
		{
			return false;
		}

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
		}
	}
}
