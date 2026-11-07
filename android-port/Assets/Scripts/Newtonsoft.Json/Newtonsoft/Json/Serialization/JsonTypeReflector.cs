using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183E30", Offset = "0x183E30")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183E30", Offset = "0x183E30")]
	internal static class JsonTypeReflector
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183E70", Offset = "0x183E70")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x40002DB")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187F14", Offset = "0x187F14")]
			public Type type;

			[Token(Token = "0x40002DC")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187F28", Offset = "0x187F28")]
			public Func<object> defaultConstructor;

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x23395CC", Offset = "0x23395CC", VA = "0x23395CC")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x23395D4", Offset = "0x23395D4", VA = "0x23395D4")]
			internal object _003CGetCreator_003Eb__0([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DB6C", Offset = "0x18DB6C")] object[] parameters)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183E80", Offset = "0x183E80")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002DD")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187F98", Offset = "0x187F98")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187FAC", Offset = "0x187FAC")]
			public static Func<object, Type> _003C_003E9__22_1;

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x2339560", Offset = "0x2339560", VA = "0x2339560")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x2339568", Offset = "0x2339568", VA = "0x2339568")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A344", Offset = "0x18A344")]
			internal Type _003CGetCreator_003Eb__22_1(object param)
			{
				return null;
			}
		}

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x0")]
		private static bool? _fullyTrusted;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187E0C", Offset = "0x187E0C")]
		private static readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187E88", Offset = "0x187E88")]
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187F00", Offset = "0x187F00")]
		private static ReflectionObject _metadataTypeAttributeReflectionObject;

		[Token(Token = "0x170000EB")]
		public static bool FullyTrusted
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x2315404", Offset = "0x2315404", VA = "0x2315404")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EC")]
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x23149A4", Offset = "0x23149A4", VA = "0x23149A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000530")]
		public static T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x23136EC", Offset = "0x23136EC", VA = "0x23136EC")]
		public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter)
		{
			return default;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2313914", Offset = "0x2313914", VA = "0x2313914")]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x23139FC", Offset = "0x23139FC", VA = "0x23139FC")]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x231407C", Offset = "0x231407C", VA = "0x231407C")]
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			return default;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x231426C", Offset = "0x231426C", VA = "0x231426C")]
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x23143D8", Offset = "0x23143D8", VA = "0x23143D8")]
		public static JsonConverter CreateJsonConverterInstance(Type converterType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DA8C", Offset = "0x18DA8C")] object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x23144F8", Offset = "0x23144F8", VA = "0x23144F8")]
		public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DAFC", Offset = "0x18DAFC")] object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2314618", Offset = "0x2314618", VA = "0x2314618")]
		public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2314704", Offset = "0x2314704", VA = "0x2314704")]
		private static Func<object[], object> GetCreator(Type type)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2314A40", Offset = "0x2314A40", VA = "0x2314A40")]
		private static Type GetAssociatedMetadataType(Type type)
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2314AD4", Offset = "0x2314AD4", VA = "0x2314AD4")]
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2315364", Offset = "0x2315364", VA = "0x2315364")]
		public static bool IsNonSerializable(object provider)
		{
			return default;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x23141CC", Offset = "0x23141CC", VA = "0x23141CC")]
		public static bool IsSerializable(object provider)
		{
			return default;
		}

		[Token(Token = "0x6000540")]
		public static T GetAttribute<T>(object provider) where T : Attribute
		{
			return null;
		}
	}
}
