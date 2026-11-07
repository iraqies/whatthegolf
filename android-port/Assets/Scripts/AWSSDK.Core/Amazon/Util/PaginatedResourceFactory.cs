using System;

namespace Amazon.Util
{
	public static class PaginatedResourceFactory
	{
		public static object Create<TItemType, TRequestType, TResponseType>(PaginatedResourceInfo pri)
		{
			return null;
		}

		private static PaginatedResource<ItemType> Create<ItemType, TRequestType, TResponseType>(object client, string methodName, object request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
		{
			return null;
		}

		private static PaginatedResource<ItemType> Create<ItemType, TRequestType, TResponseType>(Func<TRequestType, TResponseType> call, TRequestType request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
		{
			return null;
		}

		private static void SetPropertyValueAtPath(object instance, string path, string value)
		{
		}

		private static T GetPropertyValueFromPath<T>(object instance, string path)
		{
			return default;
		}

		internal static Type GetPropertyTypeFromPath(Type start, string path)
		{
			return null;
		}

		private static Type GetFuncType<T, U>()
		{
			return null;
		}

		internal static T Cast<T>(object o)
		{
			return default;
		}
	}
}
