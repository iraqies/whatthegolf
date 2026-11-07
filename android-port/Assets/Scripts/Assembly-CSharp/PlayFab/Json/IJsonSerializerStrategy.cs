using System;

namespace PlayFab.Json
{
	public interface IJsonSerializerStrategy
	{
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		object DeserializeObject(object value, Type type);
	}
}
