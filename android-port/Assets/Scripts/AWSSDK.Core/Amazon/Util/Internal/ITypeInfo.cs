using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Amazon.Util.Internal
{
	[Token(Token = "0x200007B")]
	public interface ITypeInfo
	{
		[Token(Token = "0x17000113")]
		Type BaseType
		{
			[Token(Token = "0x60004A8")]
			get;
		}

		[Token(Token = "0x17000114")]
		Type Type
		{
			[Token(Token = "0x60004A9")]
			get;
		}

		[Token(Token = "0x17000115")]
		Assembly Assembly
		{
			[Token(Token = "0x60004AA")]
			get;
		}

		[Token(Token = "0x17000116")]
		bool IsArray
		{
			[Token(Token = "0x60004AB")]
			get;
		}

		[Token(Token = "0x17000117")]
		bool IsEnum
		{
			[Token(Token = "0x60004B8")]
			get;
		}

		[Token(Token = "0x17000118")]
		bool IsClass
		{
			[Token(Token = "0x60004B9")]
			get;
		}

		[Token(Token = "0x17000119")]
		bool IsValueType
		{
			[Token(Token = "0x60004BA")]
			get;
		}

		[Token(Token = "0x1700011A")]
		bool IsInterface
		{
			[Token(Token = "0x60004BB")]
			get;
		}

		[Token(Token = "0x1700011B")]
		bool IsAbstract
		{
			[Token(Token = "0x60004BC")]
			get;
		}

		[Token(Token = "0x1700011C")]
		bool IsSealed
		{
			[Token(Token = "0x60004BD")]
			get;
		}

		[Token(Token = "0x1700011D")]
		string FullName
		{
			[Token(Token = "0x60004C3")]
			get;
		}

		[Token(Token = "0x1700011E")]
		string Name
		{
			[Token(Token = "0x60004C4")]
			get;
		}

		[Token(Token = "0x1700011F")]
		bool IsGenericTypeDefinition
		{
			[Token(Token = "0x60004C5")]
			get;
		}

		[Token(Token = "0x17000120")]
		bool IsGenericType
		{
			[Token(Token = "0x60004C6")]
			get;
		}

		[Token(Token = "0x17000121")]
		bool ContainsGenericParameters
		{
			[Token(Token = "0x60004C7")]
			get;
		}

		[Token(Token = "0x60004AC")]
		Array ArrayCreateInstance(int length);

		[Token(Token = "0x60004AD")]
		Type GetInterface(string name);

		[Token(Token = "0x60004AE")]
		Type[] GetInterfaces();

		[Token(Token = "0x60004AF")]
		IEnumerable<PropertyInfo> GetProperties();

		[Token(Token = "0x60004B0")]
		IEnumerable<FieldInfo> GetFields();

		[Token(Token = "0x60004B1")]
		FieldInfo GetField(string name);

		[Token(Token = "0x60004B2")]
		MethodInfo GetMethod(string name);

		[Token(Token = "0x60004B3")]
		MethodInfo GetMethod(string name, ITypeInfo[] paramTypes);

		[Token(Token = "0x60004B4")]
		MemberInfo[] GetMembers();

		[Token(Token = "0x60004B5")]
		ConstructorInfo GetConstructor(ITypeInfo[] paramTypes);

		[Token(Token = "0x60004B6")]
		PropertyInfo GetProperty(string name);

		[Token(Token = "0x60004B7")]
		bool IsAssignableFrom(ITypeInfo typeInfo);

		[Token(Token = "0x60004BE")]
		object EnumToObject(object value);

		[Token(Token = "0x60004BF")]
		ITypeInfo EnumGetUnderlyingType();

		[Token(Token = "0x60004C0")]
		object CreateInstance();

		[Token(Token = "0x60004C1")]
		ITypeInfo GetElementType();

		[Token(Token = "0x60004C2")]
		bool IsType(Type type);

		[Token(Token = "0x60004C8")]
		Type GetGenericTypeDefinition();

		[Token(Token = "0x60004C9")]
		Type[] GetGenericArguments();

		[Token(Token = "0x60004CA")]
		object[] GetCustomAttributes(bool inherit);

		[Token(Token = "0x60004CB")]
		object[] GetCustomAttributes(ITypeInfo attributeType, bool inherit);
	}
}
