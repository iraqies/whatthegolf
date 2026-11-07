using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Prime31.Reflection
{
	[Token(Token = "0x200001D")]
	public class CacheResolver
	{
		[Token(Token = "0x200001E")]
		private delegate object CtorDelegate();

		[Token(Token = "0x200001F")]
		public sealed class MemberMap
		{
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x10")]
			public readonly MemberInfo MemberInfo;

			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x18")]
			public readonly Type Type;

			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x20")]
			public readonly GetHandler Getter;

			[Token(Token = "0x4000045")]
			[FieldOffset(Offset = "0x28")]
			public readonly SetHandler Setter;

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x233FBF0", Offset = "0x233FBF0", VA = "0x233FBF0")]
			public MemberMap(PropertyInfo propertyInfo)
			{
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x233FCA0", Offset = "0x233FCA0", VA = "0x233FCA0")]
			public MemberMap(FieldInfo fieldInfo)
			{
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190538", Offset = "0x190538")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4000046")]
			[FieldOffset(Offset = "0x10")]
			public ConstructorInfo constructorInfo;

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x233B1EC", Offset = "0x233B1EC", VA = "0x233B1EC")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2345340", Offset = "0x2345340", VA = "0x2345340")]
			internal object _003CgetNewInstance_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190548", Offset = "0x190548")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x10")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x233BA54", Offset = "0x233BA54", VA = "0x233BA54")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2345360", Offset = "0x2345360", VA = "0x2345360")]
			internal object _003CcreateGetHandler_003Eb__0(object instance)
			{
				return null;
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190558", Offset = "0x190558")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x10")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x233BB98", Offset = "0x233BB98", VA = "0x233BB98")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2345384", Offset = "0x2345384", VA = "0x2345384")]
			internal void _003CcreateSetHandler_003Eb__0(object instance, object value)
			{
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190568", Offset = "0x190568")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x10")]
			public MethodInfo getMethodInfo;

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x233BCCC", Offset = "0x233BCCC", VA = "0x233BCCC")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x23453A0", Offset = "0x23453A0", VA = "0x23453A0")]
			internal object _003CcreateGetHandler_003Eb__0(object instance)
			{
				return null;
			}
		}

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190578", Offset = "0x190578")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x10")]
			public MethodInfo setMethodInfo;

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x233BDA0", Offset = "0x233BDA0", VA = "0x233BDA0")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2345278", Offset = "0x2345278", VA = "0x2345278")]
			internal void _003CcreateSetHandler_003Eb__0(object instance, object value)
			{
			}
		}

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		private readonly MemberMapLoader _memberMapLoader;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		private readonly SafeDictionary<Type, SafeDictionary<string, MemberMap>> _memberMapsCache;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SafeDictionary<Type, CtorDelegate> constructorCache;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x233AF8C", Offset = "0x233AF8C", VA = "0x233AF8C")]
		public CacheResolver(MemberMapLoader memberMapLoader)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x233B020", Offset = "0x233B020", VA = "0x233B020")]
		public static object getNewInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x233B47C", Offset = "0x233B47C", VA = "0x233B47C")]
		public SafeDictionary<string, MemberMap> loadMaps(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x233B9A8", Offset = "0x233B9A8", VA = "0x233B9A8")]
		private static GetHandler createGetHandler(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x233BABC", Offset = "0x233BABC", VA = "0x233BABC")]
		private static SetHandler createSetHandler(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x233BC00", Offset = "0x233BC00", VA = "0x233BC00")]
		private static GetHandler createGetHandler(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x233BCD4", Offset = "0x233BCD4", VA = "0x233BCD4")]
		private static SetHandler createSetHandler(PropertyInfo propertyInfo)
		{
			return null;
		}
	}
}
