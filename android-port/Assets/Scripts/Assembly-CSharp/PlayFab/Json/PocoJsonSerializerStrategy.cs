using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace PlayFab.Json
{
	[Token(Token = "0x20011A4")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		[Token(Token = "0x4005F1B")]
		[FieldOffset(Offset = "0x10")]
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		[Token(Token = "0x4005F1C")]
		[FieldOffset(Offset = "0x18")]
		internal IDictionary<Type, IDictionary<MemberInfo, ReflectionUtils.GetDelegate>> GetCache;

		[Token(Token = "0x4005F1D")]
		[FieldOffset(Offset = "0x20")]
		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		[Token(Token = "0x4005F1E")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Type[] EmptyTypes;

		[Token(Token = "0x4005F1F")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Type[] ArrayConstructorParameterTypes;

		[Token(Token = "0x4005F20")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] Iso8601Format;

		[Token(Token = "0x6005087")]
		[Address(RVA = "0x15F4340", Offset = "0x15F4340", VA = "0x15F4340")]
		public PocoJsonSerializerStrategy()
		{
		}

		[Token(Token = "0x6005088")]
		[Address(RVA = "0x15FF400", Offset = "0x15FF400", VA = "0x15FF400", Slot = "6")]
		protected virtual string MapClrMemberNameToJsonFieldName(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6005089")]
		[Address(RVA = "0x15FF594", Offset = "0x15FF594", VA = "0x15FF594", Slot = "7")]
		protected virtual void MapClrMemberNameToJsonFieldName(MemberInfo memberInfo, out string jsonName, out JsonProperty jsonProp)
		{
		}

		[Token(Token = "0x600508A")]
		[Address(RVA = "0x15FF740", Offset = "0x15FF740", VA = "0x15FF740", Slot = "8")]
		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return null;
		}

		[Token(Token = "0x600508B")]
		[Address(RVA = "0x15FF834", Offset = "0x15FF834", VA = "0x15FF834", Slot = "9")]
		internal virtual IDictionary<MemberInfo, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			return null;
		}

		[Token(Token = "0x600508C")]
		[Address(RVA = "0x1600090", Offset = "0x1600090", VA = "0x1600090", Slot = "10")]
		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			return null;
		}

		[Token(Token = "0x600508D")]
		[Address(RVA = "0x16009F4", Offset = "0x16009F4", VA = "0x16009F4", Slot = "11")]
		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			return default;
		}

		[Token(Token = "0x600508E")]
		[Address(RVA = "0x1600A60", Offset = "0x1600A60", VA = "0x1600A60", Slot = "12")]
		public virtual object DeserializeObject(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x600508F")]
		[Address(RVA = "0x16027FC", Offset = "0x16027FC", VA = "0x16027FC", Slot = "13")]
		protected virtual object SerializeEnum(Enum p)
		{
			return null;
		}

		[Token(Token = "0x6005090")]
		[Address(RVA = "0x16028D4", Offset = "0x16028D4", VA = "0x16028D4", Slot = "14")]
		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			return default;
		}

		[Token(Token = "0x6005091")]
		[Address(RVA = "0x1602C40", Offset = "0x1602C40", VA = "0x1602C40", Slot = "15")]
		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			return default;
		}
	}
}
