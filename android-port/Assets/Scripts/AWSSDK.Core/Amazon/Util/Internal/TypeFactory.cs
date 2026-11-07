using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;

namespace Amazon.Util.Internal
{
	[Token(Token = "0x200007C")]
	public static class TypeFactory
	{
		[Token(Token = "0x200007D")]
		private abstract class AbstractTypeInfo : ITypeInfo
		{
			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x10")]
			protected Type _type;

			[Token(Token = "0x17000122")]
			public Type Type
			{
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0x1297098", Offset = "0x1297098", VA = "0x1297098", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			public abstract Type BaseType
			{
				[Token(Token = "0x60004D3")]
				get;
			}

			[Token(Token = "0x17000124")]
			public abstract Assembly Assembly
			{
				[Token(Token = "0x60004D4")]
				get;
			}

			[Token(Token = "0x17000125")]
			public abstract bool IsClass
			{
				[Token(Token = "0x60004DF")]
				get;
			}

			[Token(Token = "0x17000126")]
			public abstract bool IsInterface
			{
				[Token(Token = "0x60004E0")]
				get;
			}

			[Token(Token = "0x17000127")]
			public abstract bool IsAbstract
			{
				[Token(Token = "0x60004E1")]
				get;
			}

			[Token(Token = "0x17000128")]
			public abstract bool IsSealed
			{
				[Token(Token = "0x60004E2")]
				get;
			}

			[Token(Token = "0x17000129")]
			public abstract bool IsEnum
			{
				[Token(Token = "0x60004E3")]
				get;
			}

			[Token(Token = "0x1700012A")]
			public abstract bool IsValueType
			{
				[Token(Token = "0x60004E4")]
				get;
			}

			[Token(Token = "0x1700012B")]
			public abstract bool ContainsGenericParameters
			{
				[Token(Token = "0x60004E8")]
				get;
			}

			[Token(Token = "0x1700012C")]
			public abstract bool IsGenericTypeDefinition
			{
				[Token(Token = "0x60004E9")]
				get;
			}

			[Token(Token = "0x1700012D")]
			public abstract bool IsGenericType
			{
				[Token(Token = "0x60004EA")]
				get;
			}

			[Token(Token = "0x1700012E")]
			public bool IsArray
			{
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x1297204", Offset = "0x1297204", VA = "0x1297204", Slot = "7")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700012F")]
			public string FullName
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0x1297400", Offset = "0x1297400", VA = "0x1297400", Slot = "31")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000130")]
			public string Name
			{
				[Token(Token = "0x60004F4")]
				[Address(RVA = "0x1297424", Offset = "0x1297424", VA = "0x1297424", Slot = "32")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x129706C", Offset = "0x129706C", VA = "0x129706C")]
			internal AbstractTypeInfo(Type type)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x12970A0", Offset = "0x12970A0", VA = "0x12970A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x12970C0", Offset = "0x12970C0", VA = "0x12970C0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x129717C", Offset = "0x129717C", VA = "0x129717C", Slot = "30")]
			public bool IsType(Type type)
			{
				return default;
			}

			[Token(Token = "0x60004D5")]
			public abstract Type GetInterface(string name);

			[Token(Token = "0x60004D6")]
			public abstract Type[] GetInterfaces();

			[Token(Token = "0x60004D7")]
			public abstract IEnumerable<PropertyInfo> GetProperties();

			[Token(Token = "0x60004D8")]
			public abstract IEnumerable<FieldInfo> GetFields();

			[Token(Token = "0x60004D9")]
			public abstract FieldInfo GetField(string name);

			[Token(Token = "0x60004DA")]
			public abstract MethodInfo GetMethod(string name);

			[Token(Token = "0x60004DB")]
			public abstract MethodInfo GetMethod(string name, ITypeInfo[] paramTypes);

			[Token(Token = "0x60004DC")]
			public abstract MemberInfo[] GetMembers();

			[Token(Token = "0x60004DD")]
			public abstract PropertyInfo GetProperty(string name);

			[Token(Token = "0x60004DE")]
			public abstract bool IsAssignableFrom(ITypeInfo typeInfo);

			[Token(Token = "0x60004E5")]
			public abstract ConstructorInfo GetConstructor(ITypeInfo[] paramTypes);

			[Token(Token = "0x60004E6")]
			public abstract object[] GetCustomAttributes(bool inherit);

			[Token(Token = "0x60004E7")]
			public abstract object[] GetCustomAttributes(ITypeInfo attributeType, bool inherit);

			[Token(Token = "0x60004EB")]
			public abstract Type GetGenericTypeDefinition();

			[Token(Token = "0x60004EC")]
			public abstract Type[] GetGenericArguments();

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x1297220", Offset = "0x1297220", VA = "0x1297220", Slot = "26")]
			public object EnumToObject(object value)
			{
				return null;
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x12972A8", Offset = "0x12972A8", VA = "0x12972A8", Slot = "27")]
			public ITypeInfo EnumGetUnderlyingType()
			{
				return null;
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1297360", Offset = "0x1297360", VA = "0x1297360", Slot = "28")]
			public object CreateInstance()
			{
				return null;
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x129736C", Offset = "0x129736C", VA = "0x129736C", Slot = "8")]
			public Array ArrayCreateInstance(int length)
			{
				return null;
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1297378", Offset = "0x1297378", VA = "0x1297378", Slot = "29")]
			public ITypeInfo GetElementType()
			{
				return null;
			}
		}

		[Token(Token = "0x200007E")]
		private class TypeInfoWrapper : AbstractTypeInfo
		{
			[Token(Token = "0x200007F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2597C", Offset = "0x2597C")]
			private sealed class _003C_003Ec__DisplayClass4_0
			{
				[Token(Token = "0x4000275")]
				[FieldOffset(Offset = "0x10")]
				public string name;

				[Token(Token = "0x6000513")]
				[Address(RVA = "0x12975B0", Offset = "0x12975B0", VA = "0x12975B0")]
				public _003C_003Ec__DisplayClass4_0()
				{
				}

				[Token(Token = "0x6000514")]
				[Address(RVA = "0x1299380", Offset = "0x1299380", VA = "0x1299380")]
				internal bool _003CGetInterface_003Eb__0(Type x)
				{
					return default;
				}
			}

			[Token(Token = "0x2000080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2598C", Offset = "0x2598C")]
			private sealed class _003C_003Ec__DisplayClass12_0
			{
				[Token(Token = "0x4000276")]
				[FieldOffset(Offset = "0x10")]
				public HashSet<string> processedProperties;

				[Token(Token = "0x6000515")]
				[Address(RVA = "0x12992B0", Offset = "0x12992B0", VA = "0x12992B0")]
				public _003C_003Ec__DisplayClass12_0()
				{
				}

				[Token(Token = "0x6000516")]
				[Address(RVA = "0x12992B8", Offset = "0x12992B8", VA = "0x12992B8")]
				internal bool _003CGetMembers_Helper_003Eb__0(MemberInfo member)
				{
					return default;
				}
			}

			[Token(Token = "0x2000081")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2599C", Offset = "0x2599C")]
			private sealed class _003CGetMembers_Helper_003Ed__12 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000277")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x4000278")]
				[FieldOffset(Offset = "0x18")]
				private MemberInfo _003C_003E2__current;

				[Token(Token = "0x4000279")]
				[FieldOffset(Offset = "0x20")]
				private int _003C_003El__initialThreadId;

				[Token(Token = "0x400027A")]
				[FieldOffset(Offset = "0x28")]
				private TypeInfo ti;

				[Token(Token = "0x400027B")]
				[FieldOffset(Offset = "0x30")]
				public TypeInfo _003C_003E3__ti;

				[Token(Token = "0x400027C")]
				[FieldOffset(Offset = "0x38")]
				private Func<MemberInfo, bool> _003CalreadyProcessProperty_003E5__2;

				[Token(Token = "0x400027D")]
				[FieldOffset(Offset = "0x40")]
				private IEnumerator<MemberInfo> _003C_003E7__wrap2;

				[Token(Token = "0x400027E")]
				[FieldOffset(Offset = "0x48")]
				private List<MemberInfo>.Enumerator _003C_003E7__wrap3;

				[Token(Token = "0x1700013C")]
				private MemberInfo System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EReflection_002EMemberInfo_003E_002ECurrent
				{
					[Token(Token = "0x600051C")]
					[Address(RVA = "0x1299E7C", Offset = "0x1299E7C", VA = "0x1299E7C", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EReflection_002EMemberInfo_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700013D")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600051E")]
					[Address(RVA = "0x1299EC4", Offset = "0x1299EC4", VA = "0x1299EC4", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000517")]
				[Address(RVA = "0x129786C", Offset = "0x129786C", VA = "0x129786C")]
				[DebuggerHidden]
				public _003CGetMembers_Helper_003Ed__12(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x6000518")]
				[Address(RVA = "0x129941C", Offset = "0x129941C", VA = "0x129941C", Slot = "7")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000519")]
				[Address(RVA = "0x12996DC", Offset = "0x12996DC", VA = "0x12996DC", Slot = "8")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600051A")]
				[Address(RVA = "0x12995BC", Offset = "0x12995BC", VA = "0x12995BC")]
				private void _003C_003Em__Finally1()
				{
				}

				[Token(Token = "0x600051B")]
				[Address(RVA = "0x1299680", Offset = "0x1299680", VA = "0x1299680")]
				private void _003C_003Em__Finally2()
				{
				}

				[Token(Token = "0x600051C")]
				[Address(RVA = "0x1299E7C", Offset = "0x1299E7C", VA = "0x1299E7C", Slot = "6")]
				[DebuggerHidden]
				private MemberInfo System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EReflection_002EMemberInfo_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600051D")]
				[Address(RVA = "0x1299E84", Offset = "0x1299E84", VA = "0x1299E84", Slot = "10")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600051E")]
				[Address(RVA = "0x1299EC4", Offset = "0x1299EC4", VA = "0x1299EC4", Slot = "9")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x600051F")]
				[Address(RVA = "0x1299ECC", Offset = "0x1299ECC", VA = "0x1299ECC", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<MemberInfo> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EReflection_002EMemberInfo_003E_002EGetEnumerator()
				{
					return null;
				}

				[Token(Token = "0x6000520")]
				[Address(RVA = "0x1299F78", Offset = "0x1299F78", VA = "0x1299F78", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
				{
					return null;
				}
			}

			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x18")]
			private TypeInfo _typeInfo;

			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Type objectType;

			[Token(Token = "0x17000131")]
			public override Type BaseType
			{
				[Token(Token = "0x60004F6")]
				[Address(RVA = "0x1297480", Offset = "0x1297480", VA = "0x1297480", Slot = "40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000132")]
			public override bool IsClass
			{
				[Token(Token = "0x60004FF")]
				[Address(RVA = "0x12978A4", Offset = "0x12978A4", VA = "0x12978A4", Slot = "52")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000133")]
			public override bool IsValueType
			{
				[Token(Token = "0x6000500")]
				[Address(RVA = "0x12978C0", Offset = "0x12978C0", VA = "0x12978C0", Slot = "57")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000134")]
			public override bool IsInterface
			{
				[Token(Token = "0x6000501")]
				[Address(RVA = "0x12978DC", Offset = "0x12978DC", VA = "0x12978DC", Slot = "53")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000135")]
			public override bool IsAbstract
			{
				[Token(Token = "0x6000502")]
				[Address(RVA = "0x12978F8", Offset = "0x12978F8", VA = "0x12978F8", Slot = "54")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000136")]
			public override bool IsSealed
			{
				[Token(Token = "0x6000503")]
				[Address(RVA = "0x1297914", Offset = "0x1297914", VA = "0x1297914", Slot = "55")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000137")]
			public override bool IsEnum
			{
				[Token(Token = "0x6000504")]
				[Address(RVA = "0x1297930", Offset = "0x1297930", VA = "0x1297930", Slot = "56")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000138")]
			public override bool ContainsGenericParameters
			{
				[Token(Token = "0x6000506")]
				[Address(RVA = "0x1297970", Offset = "0x1297970", VA = "0x1297970", Slot = "61")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000139")]
			public override bool IsGenericTypeDefinition
			{
				[Token(Token = "0x6000507")]
				[Address(RVA = "0x1297994", Offset = "0x1297994", VA = "0x1297994", Slot = "62")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700013A")]
			public override bool IsGenericType
			{
				[Token(Token = "0x6000508")]
				[Address(RVA = "0x12979B8", Offset = "0x12979B8", VA = "0x12979B8", Slot = "63")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700013B")]
			public override Assembly Assembly
			{
				[Token(Token = "0x6000510")]
				[Address(RVA = "0x1297DA4", Offset = "0x1297DA4", VA = "0x1297DA4", Slot = "41")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1297444", Offset = "0x1297444", VA = "0x1297444")]
			internal TypeInfoWrapper(Type type)
			{
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x12974A4", Offset = "0x12974A4", VA = "0x12974A4", Slot = "42")]
			public override Type GetInterface(string name)
			{
				return null;
			}

			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x12975B8", Offset = "0x12975B8", VA = "0x12975B8", Slot = "43")]
			public override Type[] GetInterfaces()
			{
				return null;
			}

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x129761C", Offset = "0x129761C", VA = "0x129761C", Slot = "44")]
			public override IEnumerable<PropertyInfo> GetProperties()
			{
				return null;
			}

			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1297638", Offset = "0x1297638", VA = "0x1297638", Slot = "45")]
			public override IEnumerable<FieldInfo> GetFields()
			{
				return null;
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1297654", Offset = "0x1297654", VA = "0x1297654", Slot = "46")]
			public override FieldInfo GetField(string name)
			{
				return null;
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1297670", Offset = "0x1297670", VA = "0x1297670", Slot = "49")]
			public override MemberInfo[] GetMembers()
			{
				return null;
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x12977F0", Offset = "0x12977F0", VA = "0x12977F0")]
			private static bool IsBackingField(MemberInfo mi)
			{
				return default;
			}

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x129776C", Offset = "0x129776C", VA = "0x129776C")]
			private static IEnumerable<MemberInfo> GetMembers_Helper(TypeInfo ti)
			{
				return null;
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1297954", Offset = "0x1297954", VA = "0x1297954", Slot = "47")]
			public override MethodInfo GetMethod(string name)
			{
				return null;
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x12979DC", Offset = "0x12979DC", VA = "0x12979DC", Slot = "64")]
			public override Type GetGenericTypeDefinition()
			{
				return null;
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x1297A00", Offset = "0x1297A00", VA = "0x1297A00", Slot = "65")]
			public override Type[] GetGenericArguments()
			{
				return null;
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1297A24", Offset = "0x1297A24", VA = "0x1297A24", Slot = "48")]
			public override MethodInfo GetMethod(string name, ITypeInfo[] paramTypes)
			{
				return null;
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x1297B78", Offset = "0x1297B78", VA = "0x1297B78", Slot = "50")]
			public override PropertyInfo GetProperty(string name)
			{
				return null;
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x1297B94", Offset = "0x1297B94", VA = "0x1297B94", Slot = "51")]
			public override bool IsAssignableFrom(ITypeInfo typeInfo)
			{
				return default;
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0x1297C38", Offset = "0x1297C38", VA = "0x1297C38", Slot = "59")]
			public override object[] GetCustomAttributes(bool inherit)
			{
				return null;
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x1297CA4", Offset = "0x1297CA4", VA = "0x1297CA4", Slot = "60")]
			public override object[] GetCustomAttributes(ITypeInfo attributeType, bool inherit)
			{
				return null;
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1297DC8", Offset = "0x1297DC8", VA = "0x1297DC8", Slot = "58")]
			public override ConstructorInfo GetConstructor(ITypeInfo[] paramTypes)
			{
				return null;
			}
		}

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ITypeInfo[] EmptyTypes;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x12712D8", Offset = "0x12712D8", VA = "0x12712D8")]
		public static ITypeInfo GetTypeInfo(Type type)
		{
			return null;
		}
	}
}
