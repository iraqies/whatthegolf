using System;

namespace PlayFab.Json
{
	public class SimpleJsonInstance : ISerializerPlugin, IPlayFabPlugin
	{
		public class PlayFabSimpleJsonCuztomization : PocoJsonSerializerStrategy
		{
			public override object DeserializeObject(object value, Type type)
			{
				return null;
			}

			protected override bool TrySerializeKnownTypes(object input, out object output)
			{
				output = null;
				return false;
			}
		}

		public static PlayFabSimpleJsonCuztomization ApiSerializerStrategy;

		public T DeserializeObject<T>(string json)
		{
			return default;
		}

		public string SerializeObject(object json)
		{
			return null;
		}
	}
}
