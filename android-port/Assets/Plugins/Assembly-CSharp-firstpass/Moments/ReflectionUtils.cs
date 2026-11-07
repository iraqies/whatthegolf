using System;
using System.Linq.Expressions;
using System.Reflection;
using Il2CppDummyDll;

namespace Moments
{
	[Token(Token = "0x2000280")]
	public class ReflectionUtils<T> where T : class, new()
	{
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _Instance;

		[Token(Token = "0x6001076")]
		public ReflectionUtils(T instance)
		{
		}

		[Token(Token = "0x6001077")]
		public string GetFieldName<U>(Expression<Func<T, U>> fieldAccess)
		{
			return null;
		}

		[Token(Token = "0x6001078")]
		public FieldInfo GetField(string fieldName)
		{
			return null;
		}

		[Token(Token = "0x6001079")]
		public A GetAttribute<A>(FieldInfo field) where A : Attribute
		{
			return null;
		}

		[Token(Token = "0x600107A")]
		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, float value)
		{
		}

		[Token(Token = "0x600107B")]
		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, int value)
		{
		}

		[Token(Token = "0x600107C")]
		public void ConstrainRange<U>(Expression<Func<T, U>> fieldAccess, int value)
		{
		}
	}
}
