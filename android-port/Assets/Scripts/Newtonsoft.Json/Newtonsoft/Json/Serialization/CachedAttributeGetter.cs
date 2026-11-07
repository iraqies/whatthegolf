using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000087")]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186480", Offset = "0x186480")]
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;

		[Token(Token = "0x6000359")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189518", Offset = "0x189518")]
		public static T GetAttribute(object type)
		{
			return null;
		}
	}
}
