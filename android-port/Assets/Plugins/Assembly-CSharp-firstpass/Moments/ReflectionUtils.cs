using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Moments
{
	public class ReflectionUtils<T> where T : class, new()
	{
		private readonly T _Instance;

		public ReflectionUtils(T instance)
		{
		}

		public string GetFieldName<U>(Expression<Func<T, U>> fieldAccess)
		{
			return null;
		}

		public FieldInfo GetField(string fieldName)
		{
			return null;
		}

		public A GetAttribute<A>(FieldInfo field) where A : Attribute
		{
			return null;
		}

		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, float value)
		{
		}

		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, int value)
		{
		}

		public void ConstrainRange<U>(Expression<Func<T, U>> fieldAccess, int value)
		{
		}
	}
}
