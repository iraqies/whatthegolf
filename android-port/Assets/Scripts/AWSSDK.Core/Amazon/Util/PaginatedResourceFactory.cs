using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000061")]
	public static class PaginatedResourceFactory
	{
		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x257F4", Offset = "0x257F4")]
		private sealed class _003C_003Ec__DisplayClass1_0<ItemType, TRequestType, TResponseType>
		{
			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x0")]
			public MethodInfo fetcherMethod;

			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x0")]
			public object client;

			[Token(Token = "0x6000375")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000376")]
			internal TResponseType _003CCreate_003Eb__0(TRequestType req)
			{
				return (TResponseType)null;
			}
		}

		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25804", Offset = "0x25804")]
		private sealed class _003C_003Ec__DisplayClass2_0<ItemType, TRequestType, TResponseType>
		{
			[Token(Token = "0x4000209")]
			[FieldOffset(Offset = "0x0")]
			public TRequestType request;

			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x0")]
			public string tokenRequestPropertyPath;

			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x0")]
			public Func<TRequestType, TResponseType> call;

			[Token(Token = "0x400020C")]
			[FieldOffset(Offset = "0x0")]
			public string tokenResponsePropertyPath;

			[Token(Token = "0x400020D")]
			[FieldOffset(Offset = "0x0")]
			public string itemListPropertyPath;

			[Token(Token = "0x6000377")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000378")]
			internal Marker<ItemType> _003CCreate_003Eb__0(string token)
			{
				return null;
			}
		}

		[Token(Token = "0x600036D")]
		public static object Create<TItemType, TRequestType, TResponseType>(PaginatedResourceInfo pri)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		private static PaginatedResource<ItemType> Create<ItemType, TRequestType, TResponseType>(object client, string methodName, object request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		private static PaginatedResource<ItemType> Create<ItemType, TRequestType, TResponseType>(Func<TRequestType, TResponseType> call, TRequestType request, string tokenRequestPropertyPath, string tokenResponsePropertyPath, string itemListPropertyPath)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x124541C", Offset = "0x124541C", VA = "0x124541C")]
		private static void SetPropertyValueAtPath(object instance, string path, string value)
		{
		}

		[Token(Token = "0x6000371")]
		private static T GetPropertyValueFromPath<T>(object instance, string path)
		{
			return (T)null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x12456FC", Offset = "0x12456FC", VA = "0x12456FC")]
		internal static Type GetPropertyTypeFromPath(Type start, string path)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		private static Type GetFuncType<T, U>()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		internal static T Cast<T>(object o)
		{
			return (T)null;
		}
	}
}
