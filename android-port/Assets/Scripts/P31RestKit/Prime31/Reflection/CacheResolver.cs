using System;
using System.Reflection;

namespace Prime31.Reflection
{
	public class CacheResolver
	{
		private delegate object CtorDelegate();

		public sealed class MemberMap
		{
			public readonly MemberInfo MemberInfo;

			public readonly Type Type;

			public readonly GetHandler Getter;

			public readonly SetHandler Setter;

			public MemberMap(PropertyInfo propertyInfo)
			{
			}

			public MemberMap(FieldInfo fieldInfo)
			{
			}
		}

		private readonly MemberMapLoader _memberMapLoader;

		private readonly SafeDictionary<Type, SafeDictionary<string, MemberMap>> _memberMapsCache;

		private static readonly SafeDictionary<Type, CtorDelegate> constructorCache;

		public CacheResolver(MemberMapLoader memberMapLoader)
		{
		}

		public static object getNewInstance(Type type)
		{
			return null;
		}

		public SafeDictionary<string, MemberMap> loadMaps(Type type)
		{
			return null;
		}

		private static GetHandler createGetHandler(FieldInfo fieldInfo)
		{
			return null;
		}

		private static SetHandler createSetHandler(FieldInfo fieldInfo)
		{
			return null;
		}

		private static GetHandler createGetHandler(PropertyInfo propertyInfo)
		{
			return null;
		}

		private static SetHandler createSetHandler(PropertyInfo propertyInfo)
		{
			return null;
		}
	}
}
