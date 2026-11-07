using System;
using Prime31.Reflection;

namespace Prime31
{
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		internal CacheResolver cacheResolver;

		private static readonly string[] Iso8601Format;

		protected virtual void buildMap(Type type, SafeDictionary<string, CacheResolver.MemberMap> memberMaps)
		{
		}

		public virtual bool serializeNonPrimitiveObject(object input, out object output)
		{
			output = null;
			return false;
		}

		public virtual object deserializeObject(object value, Type type)
		{
			return null;
		}

		protected virtual object serializeEnum(Enum p)
		{
			return null;
		}

		protected virtual bool trySerializeKnownTypes(object input, out object output)
		{
			output = null;
			return false;
		}

		protected virtual bool trySerializeUnknownTypes(object input, out object output)
		{
			output = null;
			return false;
		}
	}
}
