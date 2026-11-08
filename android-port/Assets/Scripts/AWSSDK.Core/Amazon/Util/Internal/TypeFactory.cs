using System;
using System.Collections.Generic;
using System.Reflection;

namespace Amazon.Util.Internal
{
	public static class TypeFactory
	{
		private abstract class AbstractTypeInfo : ITypeInfo
		{
			protected Type _type;

			public Type Type => null;

			public abstract Type BaseType { get; }

			public abstract Assembly Assembly { get; }

			public abstract bool IsClass { get; }

			public abstract bool IsInterface { get; }

			public abstract bool IsAbstract { get; }

			public abstract bool IsSealed { get; }

			public abstract bool IsEnum { get; }

			public abstract bool IsValueType { get; }

			public abstract bool ContainsGenericParameters { get; }

			public abstract bool IsGenericTypeDefinition { get; }

			public abstract bool IsGenericType { get; }

			public bool IsArray => false;

			public string FullName => null;

			public string Name => null;

			internal AbstractTypeInfo(Type type)
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public bool IsType(Type type)
			{
				return false;
			}

			public abstract Type GetInterface(string name);

			public abstract Type[] GetInterfaces();

			public abstract IEnumerable<PropertyInfo> GetProperties();

			public abstract IEnumerable<FieldInfo> GetFields();

			public abstract FieldInfo GetField(string name);

			public abstract MethodInfo GetMethod(string name);

			public abstract MethodInfo GetMethod(string name, ITypeInfo[] paramTypes);

			public abstract MemberInfo[] GetMembers();

			public abstract PropertyInfo GetProperty(string name);

			public abstract bool IsAssignableFrom(ITypeInfo typeInfo);

			public abstract ConstructorInfo GetConstructor(ITypeInfo[] paramTypes);

			public abstract object[] GetCustomAttributes(bool inherit);

			public abstract object[] GetCustomAttributes(ITypeInfo attributeType, bool inherit);

			public abstract Type GetGenericTypeDefinition();

			public abstract Type[] GetGenericArguments();

			public object EnumToObject(object value)
			{
				return null;
			}

			public ITypeInfo EnumGetUnderlyingType()
			{
				return null;
			}

			public object CreateInstance()
			{
				return null;
			}

			public Array ArrayCreateInstance(int length)
			{
				return null;
			}

			public ITypeInfo GetElementType()
			{
				return null;
			}
		}

		private class TypeInfoWrapper : AbstractTypeInfo
		{
			private TypeInfo _typeInfo;

			private static readonly Type objectType;

			public override Type BaseType => null;

			public override bool IsClass => false;

			public override bool IsValueType => false;

			public override bool IsInterface => false;

			public override bool IsAbstract => false;

			public override bool IsSealed => false;

			public override bool IsEnum => false;

			public override bool ContainsGenericParameters => false;

			public override bool IsGenericTypeDefinition => false;

			public override bool IsGenericType => false;

			public override Assembly Assembly => null;

			internal TypeInfoWrapper(Type type) : base(type)
			{
			}

			public override Type GetInterface(string name)
			{
				return null;
			}

			public override Type[] GetInterfaces()
			{
				return null;
			}

			public override IEnumerable<PropertyInfo> GetProperties()
			{
				return null;
			}

			public override IEnumerable<FieldInfo> GetFields()
			{
				return null;
			}

			public override FieldInfo GetField(string name)
			{
				return null;
			}

			public override MemberInfo[] GetMembers()
			{
				return null;
			}

			private static bool IsBackingField(MemberInfo mi)
			{
				return false;
			}

			private static IEnumerable<MemberInfo> GetMembers_Helper(TypeInfo ti)
			{
				return null;
			}

			public override MethodInfo GetMethod(string name)
			{
				return null;
			}

			public override Type GetGenericTypeDefinition()
			{
				return null;
			}

			public override Type[] GetGenericArguments()
			{
				return null;
			}

			public override MethodInfo GetMethod(string name, ITypeInfo[] paramTypes)
			{
				return null;
			}

			public override PropertyInfo GetProperty(string name)
			{
				return null;
			}

			public override bool IsAssignableFrom(ITypeInfo typeInfo)
			{
				return false;
			}

			public override object[] GetCustomAttributes(bool inherit)
			{
				return null;
			}

			public override object[] GetCustomAttributes(ITypeInfo attributeType, bool inherit)
			{
				return null;
			}

			public override ConstructorInfo GetConstructor(ITypeInfo[] paramTypes)
			{
				return null;
			}
		}

		public static readonly ITypeInfo[] EmptyTypes;

		public static ITypeInfo GetTypeInfo(Type type)
		{
			return null;
		}
	}
}
