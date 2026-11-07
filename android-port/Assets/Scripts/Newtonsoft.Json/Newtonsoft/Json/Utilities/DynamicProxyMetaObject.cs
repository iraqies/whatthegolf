using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182EAC", Offset = "0x182EAC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182EAC", Offset = "0x182EAC")]
	internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject
	{
		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182EEC", Offset = "0x182EEC")]
		private delegate DynamicMetaObject Fallback([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B8A4", Offset = "0x18B8A4")] DynamicMetaObject errorSuggestion);

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x182F00", Offset = "0x182F00")]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1857AC", Offset = "0x1857AC")]
			public GetMemberBinder binder;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1857C0", Offset = "0x1857C0")]
			public DynamicProxyMetaObject<T> _003C_003E4__this;

			[Token(Token = "0x600022C")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600022D")]
			internal DynamicMetaObject _003CBindGetMember_003Eb__0([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B8CC", Offset = "0x18B8CC")] DynamicMetaObject e)
			{
				return null;
			}
		}

		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x182F10", Offset = "0x182F10")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1857D4", Offset = "0x1857D4")]
			public SetMemberBinder binder;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1857E8", Offset = "0x1857E8")]
			public DynamicProxyMetaObject<T> _003C_003E4__this;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1857FC", Offset = "0x1857FC")]
			public DynamicMetaObject value;

			[Token(Token = "0x600022E")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600022F")]
			internal DynamicMetaObject _003CBindSetMember_003Eb__0([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B8E0", Offset = "0x18B8E0")] DynamicMetaObject e)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x182F20", Offset = "0x182F20")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185810", Offset = "0x185810")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185824", Offset = "0x185824")]
			public static Func<DynamicMetaObject, Expression> _003C_003E9__18_0;

			[Token(Token = "0x6000231")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000232")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188DBC", Offset = "0x188DBC")]
			internal Expression _003CGetArgs_003Eb__18_0(DynamicMetaObject arg)
			{
				return null;
			}
		}

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly DynamicProxy<T> _proxy;

		[Token(Token = "0x1700005C")]
		private static Expression[] NoArgs
		{
			[Token(Token = "0x6000220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021C")]
		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
		{
		}

		[Token(Token = "0x600021D")]
		private bool IsOverridden(string method)
		{
			return default;
		}

		[Token(Token = "0x600021E")]
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		private static IEnumerable<Expression> GetArgs(params DynamicMetaObject[] args)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B6E4", Offset = "0x18B6E4")] Fallback fallback, [Optional][AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B754", Offset = "0x18B754")] Fallback fallbackInvoke)
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B7C4", Offset = "0x18B7C4")] Fallback fallbackInvoke)
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B834", Offset = "0x18B834")] Fallback fallback)
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		private BindingRestrictions GetRestrictions()
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return null;
		}
	}
}
