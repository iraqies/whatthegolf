using System;
using Il2CppDummyDll;
using Prime31.Reflection;

namespace Prime31
{
	[Token(Token = "0x2000017")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x10")]
		internal CacheResolver cacheResolver;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] Iso8601Format;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x233F928", Offset = "0x233F928", VA = "0x233F928")]
		public PocoJsonSerializerStrategy()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x233FA38", Offset = "0x233FA38", VA = "0x233FA38", Slot = "6")]
		protected virtual void buildMap(Type type, SafeDictionary<string, CacheResolver.MemberMap> memberMaps)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x233FD50", Offset = "0x233FD50", VA = "0x233FD50", Slot = "7")]
		public virtual bool serializeNonPrimitiveObject(object input, out object output)
		{
			return default;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x233FDB4", Offset = "0x233FDB4", VA = "0x233FDB4", Slot = "8")]
		public virtual object deserializeObject(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2341A6C", Offset = "0x2341A6C", VA = "0x2341A6C", Slot = "9")]
		protected virtual object serializeEnum(Enum p)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2341B44", Offset = "0x2341B44", VA = "0x2341B44", Slot = "10")]
		protected virtual bool trySerializeKnownTypes(object input, out object output)
		{
			return default;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2341DCC", Offset = "0x2341DCC", VA = "0x2341DCC", Slot = "11")]
		protected virtual bool trySerializeUnknownTypes(object input, out object output)
		{
			return default;
		}
	}
}
