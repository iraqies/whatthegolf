using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183388", Offset = "0x183388")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183388", Offset = "0x183388")]
	internal abstract class ReflectionDelegateFactory
	{
		[Token(Token = "0x60002BC")]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		[Token(Token = "0x60002BF")]
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		[Token(Token = "0x60002C0")]
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		[Token(Token = "0x60002C1")]
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		[Token(Token = "0x60002C2")]
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		[Token(Token = "0x60002C3")]
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		[Token(Token = "0x60002C4")]
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x231BA0C", Offset = "0x231BA0C", VA = "0x231BA0C")]
		protected ReflectionDelegateFactory()
		{
		}
	}
}
