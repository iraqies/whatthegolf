using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace PlayFab.Json
{
	[Token(Token = "0x20011A5")]
	internal class ReflectionUtils
	{
		[Token(Token = "0x20011A6")]
		public delegate object GetDelegate(object source);

		[Token(Token = "0x20011A7")]
		public delegate void SetDelegate(object source, object value);

		[Token(Token = "0x20011A8")]
		public delegate object ConstructorDelegate(params object[] args);

		[Token(Token = "0x20011A9")]
		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);

		[Token(Token = "0x20011AA")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x481D4", Offset = "0x481D4")]
		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			[Token(Token = "0x4005F23")]
			[FieldOffset(Offset = "0x0")]
			private readonly object _lock;

			[Token(Token = "0x4005F24")]
			[FieldOffset(Offset = "0x0")]
			private readonly ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			[Token(Token = "0x4005F25")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			[Token(Token = "0x170008B3")]
			public ICollection<TKey> Keys
			{
				[Token(Token = "0x60050C3")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170008B4")]
			public ICollection<TValue> Values
			{
				[Token(Token = "0x60050C6")]
				get
				{
					return null;
				}
			}

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x170008B5")]
			[Token(Token = "0x60050C7")]
			public TValue get_Item(TKey key)
			{
				return (TValue)null;
			}

			[Token(Token = "0x60050C8")]
			public void set_Item(TKey key, TValue value)
			{
			}

			[Token(Token = "0x170008B6")]
			public int Count
			{
				[Token(Token = "0x60050CD")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170008B7")]
			public bool IsReadOnly
			{
				[Token(Token = "0x60050CE")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60050BE")]
			public ThreadSafeDictionary(ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
			}

			[Token(Token = "0x60050BF")]
			private TValue Get(TKey key)
			{
				return (TValue)null;
			}

			[Token(Token = "0x60050C0")]
			private TValue AddValue(TKey key)
			{
				return (TValue)null;
			}

			[Token(Token = "0x60050C1")]
			public void Add(TKey key, TValue value)
			{
			}

			[Token(Token = "0x60050C2")]
			public bool ContainsKey(TKey key)
			{
				return default;
			}

			[Token(Token = "0x60050C4")]
			public bool Remove(TKey key)
			{
				return default;
			}

			[Token(Token = "0x60050C5")]
			public bool TryGetValue(TKey key, out TValue value)
			{
				return default;
			}

			[Token(Token = "0x60050C9")]
			public void Add(KeyValuePair<TKey, TValue> item)
			{
			}

			[Token(Token = "0x60050CA")]
			public void Clear()
			{
			}

			[Token(Token = "0x60050CB")]
			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				return default;
			}

			[Token(Token = "0x60050CC")]
			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x60050CF")]
			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				return default;
			}

			[Token(Token = "0x60050D0")]
			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60050D1")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20011AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4820C", Offset = "0x4820C")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x4005F26")]
			[FieldOffset(Offset = "0x10")]
			public ConstructorInfo constructorInfo;

			[Token(Token = "0x60050D2")]
			[Address(RVA = "0x1831CAC", Offset = "0x1831CAC", VA = "0x1831CAC")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60050D3")]
			[Address(RVA = "0x1831CB4", Offset = "0x1831CB4", VA = "0x1831CB4")]
			internal object _003CGetConstructorByReflection_003Eb__0(object[] args)
			{
				return null;
			}
		}

		[Token(Token = "0x20011AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4821C", Offset = "0x4821C")]
		private sealed class _003C_003Ec__DisplayClass30_0
		{
			[Token(Token = "0x4005F27")]
			[FieldOffset(Offset = "0x10")]
			public MethodInfo methodInfo;

			[Token(Token = "0x60050D4")]
			[Address(RVA = "0x1831CD0", Offset = "0x1831CD0", VA = "0x1831CD0")]
			public _003C_003Ec__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60050D5")]
			[Address(RVA = "0x1831CD8", Offset = "0x1831CD8", VA = "0x1831CD8")]
			internal object _003CGetGetMethodByReflection_003Eb__0(object source)
			{
				return null;
			}
		}

		[Token(Token = "0x20011AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4822C", Offset = "0x4822C")]
		private sealed class _003C_003Ec__DisplayClass31_0
		{
			[Token(Token = "0x4005F28")]
			[FieldOffset(Offset = "0x10")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x60050D6")]
			[Address(RVA = "0x1831D74", Offset = "0x1831D74", VA = "0x1831D74")]
			public _003C_003Ec__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60050D7")]
			[Address(RVA = "0x1831D7C", Offset = "0x1831D7C", VA = "0x1831D7C")]
			internal object _003CGetGetMethodByReflection_003Eb__0(object source)
			{
				return null;
			}
		}

		[Token(Token = "0x20011AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4823C", Offset = "0x4823C")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x4005F29")]
			[FieldOffset(Offset = "0x10")]
			public MethodInfo methodInfo;

			[Token(Token = "0x60050D8")]
			[Address(RVA = "0x1831DA0", Offset = "0x1831DA0", VA = "0x1831DA0")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60050D9")]
			[Address(RVA = "0x1831DA8", Offset = "0x1831DA8", VA = "0x1831DA8")]
			internal void _003CGetSetMethodByReflection_003Eb__0(object source, object value)
			{
			}
		}

		[Token(Token = "0x20011AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4824C", Offset = "0x4824C")]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			[Token(Token = "0x4005F2A")]
			[FieldOffset(Offset = "0x10")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x60050DA")]
			[Address(RVA = "0x1831EFC", Offset = "0x1831EFC", VA = "0x1831EFC")]
			public _003C_003Ec__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60050DB")]
			[Address(RVA = "0x1831F04", Offset = "0x1831F04", VA = "0x1831F04")]
			internal void _003CGetSetMethodByReflection_003Eb__0(object source, object value)
			{
			}
		}

		[Token(Token = "0x4005F21")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object[] EmptyObjects;

		[Token(Token = "0x4005F22")]
		[ThreadStatic]
		private static object[] _1ObjArray;

		[Token(Token = "0x6005093")]
		[Address(RVA = "0x16468C4", Offset = "0x16468C4", VA = "0x16468C4")]
		public static Type GetTypeInfo(Type type)
		{
			return null;
		}

		[Token(Token = "0x6005094")]
		[Address(RVA = "0x16468C8", Offset = "0x16468C8", VA = "0x16468C8")]
		public static Type GetGenericListElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6005095")]
		[Address(RVA = "0x1646ED8", Offset = "0x1646ED8", VA = "0x1646ED8")]
		public static Type[] GetGenericTypeArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6005096")]
		[Address(RVA = "0x1646E4C", Offset = "0x1646E4C", VA = "0x1646E4C")]
		public static bool IsTypeGeneric(Type type)
		{
			return default;
		}

		[Token(Token = "0x6005097")]
		[Address(RVA = "0x1646EF8", Offset = "0x1646EF8", VA = "0x1646EF8")]
		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			return default;
		}

		[Token(Token = "0x6005098")]
		[Address(RVA = "0x16470F4", Offset = "0x16470F4", VA = "0x16470F4")]
		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return default;
		}

		[Token(Token = "0x6005099")]
		[Address(RVA = "0x1647190", Offset = "0x1647190", VA = "0x1647190")]
		public static bool IsTypeDictionary(Type type)
		{
			return default;
		}

		[Token(Token = "0x600509A")]
		[Address(RVA = "0x1647360", Offset = "0x1647360", VA = "0x1647360")]
		public static bool IsNullableType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600509B")]
		[Address(RVA = "0x1647470", Offset = "0x1647470", VA = "0x1647470")]
		public static object ToNullableType(object obj, Type nullableType)
		{
			return null;
		}

		[Token(Token = "0x600509C")]
		[Address(RVA = "0x1647548", Offset = "0x1647548", VA = "0x1647548")]
		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return null;
		}

		[Token(Token = "0x600509D")]
		[Address(RVA = "0x1647560", Offset = "0x1647560", VA = "0x1647560")]
		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			return null;
		}

		[Token(Token = "0x600509E")]
		[Address(RVA = "0x1647A30", Offset = "0x1647A30", VA = "0x1647A30")]
		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return null;
		}

		[Token(Token = "0x600509F")]
		[Address(RVA = "0x1647A54", Offset = "0x1647A54", VA = "0x1647A54")]
		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return null;
		}

		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x1647A78", Offset = "0x1647A78", VA = "0x1647A78")]
		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x1647A9C", Offset = "0x1647A9C", VA = "0x1647A9C")]
		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x1647AC0", Offset = "0x1647AC0", VA = "0x1647AC0")]
		public static ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return null;
		}

		[Token(Token = "0x60050A3")]
		[Address(RVA = "0x1647C48", Offset = "0x1647C48", VA = "0x1647C48")]
		public static ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return null;
		}

		[Token(Token = "0x60050A4")]
		[Address(RVA = "0x1647B48", Offset = "0x1647B48", VA = "0x1647B48")]
		public static ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			return null;
		}

		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x1647CFC", Offset = "0x1647CFC", VA = "0x1647CFC")]
		public static GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60050A6")]
		[Address(RVA = "0x1647E70", Offset = "0x1647E70", VA = "0x1647E70")]
		public static GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x1647D74", Offset = "0x1647D74", VA = "0x1647D74")]
		public static GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60050A8")]
		[Address(RVA = "0x1647EE8", Offset = "0x1647EE8", VA = "0x1647EE8")]
		public static GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x1647F9C", Offset = "0x1647F9C", VA = "0x1647F9C")]
		public static SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x1648110", Offset = "0x1648110", VA = "0x1648110")]
		public static SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x1648014", Offset = "0x1648014", VA = "0x1648014")]
		public static SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60050AC")]
		[Address(RVA = "0x1648188", Offset = "0x1648188", VA = "0x1648188")]
		public static SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return null;
		}
	}
}
