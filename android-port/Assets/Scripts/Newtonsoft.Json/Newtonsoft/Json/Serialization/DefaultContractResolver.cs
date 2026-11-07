using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183750", Offset = "0x183750")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183750", Offset = "0x183750")]
	public class DefaultContractResolver : IContractResolver
	{
		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183790", Offset = "0x183790")]
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			[Token(Token = "0x200008B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1837A4", Offset = "0x1837A4")]
			private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<KeyValuePair<object, object>>, IEnumerator, IDisposable
			{
				[Token(Token = "0x400021E")]
				[FieldOffset(Offset = "0x0")]
				private int _003C_003E1__state;

				[Token(Token = "0x400021F")]
				[FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186608", Offset = "0x186608")]
				private KeyValuePair<object, object> _003C_003E2__current;

				[Token(Token = "0x4000220")]
				[FieldOffset(Offset = "0x0")]
				public EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> _003C_003E4__this;

				[Token(Token = "0x4000221")]
				[FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186680", Offset = "0x186680")]
				private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _003C_003E7__wrap1;

				[Token(Token = "0x17000080")]
				private KeyValuePair<object, object> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EObject_002CSystem_002EObject_003E_003E_002ECurrent
				{
					[Token(Token = "0x60003A1")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EObject_002CSystem_002EObject_003E_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000081")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x60003A3")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600039D")]
				[DebuggerHidden]
				public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x600039E")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x600039F")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60003A0")]
				private void _003C_003Em__Finally1()
				{
				}

				[Token(Token = "0x60003A1")]
				[DebuggerHidden]
				private KeyValuePair<object, object> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EObject_002CSystem_002EObject_003E_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x60003A2")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x60003A3")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186594", Offset = "0x186594")]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			[Token(Token = "0x600039A")]
			public EnumerableDictionaryWrapper([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C9B8", Offset = "0x18C9B8")] IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			[Token(Token = "0x600039B")]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600039C")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1895FC", Offset = "0x1895FC")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1837B4", Offset = "0x1837B4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1866F0", Offset = "0x1866F0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186704", Offset = "0x186704")]
			public static Func<MemberInfo, bool> _003C_003E9__40_0;

			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186718", Offset = "0x186718")]
			public static Func<MemberInfo, bool> _003C_003E9__40_1;

			[Token(Token = "0x4000225")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18672C", Offset = "0x18672C")]
			public static Func<Type, IEnumerable<MemberInfo>> _003C_003E9__44_0;

			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186740", Offset = "0x186740")]
			public static Func<MemberInfo, bool> _003C_003E9__44_1;

			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186754", Offset = "0x186754")]
			public static Func<ConstructorInfo, bool> _003C_003E9__47_0;

			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186768", Offset = "0x186768")]
			public static Func<JsonProperty, int> _003C_003E9__75_0;

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x23364F8", Offset = "0x23364F8", VA = "0x23364F8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x2336500", Offset = "0x2336500", VA = "0x2336500")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189660", Offset = "0x189660")]
			internal bool _003CGetSerializableMembers_003Eb__40_0(MemberInfo m)
			{
				return default;
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x23365CC", Offset = "0x23365CC", VA = "0x23365CC")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189674", Offset = "0x189674")]
			internal bool _003CGetSerializableMembers_003Eb__40_1(MemberInfo m)
			{
				return default;
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x233663C", Offset = "0x233663C", VA = "0x233663C")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189688", Offset = "0x189688")]
			internal IEnumerable<MemberInfo> _003CGetExtensionDataMemberForType_003Eb__44_0(Type baseType)
			{
				return null;
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x2336720", Offset = "0x2336720", VA = "0x2336720")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18969C", Offset = "0x18969C")]
			internal bool _003CGetExtensionDataMemberForType_003Eb__44_1(MemberInfo m)
			{
				return default;
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x2336BE0", Offset = "0x2336BE0", VA = "0x2336BE0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1896B0", Offset = "0x1896B0")]
			internal bool _003CGetAttributeConstructor_003Eb__47_0(ConstructorInfo c)
			{
				return default;
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x2336C90", Offset = "0x2336C90", VA = "0x2336C90")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1896C4", Offset = "0x1896C4")]
			internal int _003CCreateProperties_003Eb__75_0(JsonProperty p)
			{
				return default;
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1837C4", Offset = "0x1837C4")]
		private sealed class _003C_003Ec__DisplayClass42_0
		{
			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18677C", Offset = "0x18677C")]
			public NamingStrategy namingStrategy;

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x2336CEC", Offset = "0x2336CEC", VA = "0x2336CEC")]
			public _003C_003Ec__DisplayClass42_0()
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x2336CF4", Offset = "0x2336CF4", VA = "0x2336CF4")]
			internal string _003CCreateObjectContract_003Eb__0(string s)
			{
				return null;
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1837D4", Offset = "0x1837D4")]
		private sealed class _003C_003Ec__DisplayClass45_0
		{
			[Token(Token = "0x400022A")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186790", Offset = "0x186790")]
			public Func<object, object> getExtensionDataDictionary;

			[Token(Token = "0x400022B")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186808", Offset = "0x186808")]
			public MemberInfo member;

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x2336D14", Offset = "0x2336D14", VA = "0x2336D14")]
			public _003C_003Ec__DisplayClass45_0()
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1837E4", Offset = "0x1837E4")]
		private sealed class _003C_003Ec__DisplayClass45_1
		{
			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18681C", Offset = "0x18681C")]
			public Action<object, object> setExtensionDataDictionary;

			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186894", Offset = "0x186894")]
			public Func<object> createExtensionDataDictionary;

			[Token(Token = "0x400022E")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186904", Offset = "0x186904")]
			public MethodCall<object, object> setExtensionDataDictionaryValue;

			[Token(Token = "0x400022F")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18697C", Offset = "0x18697C")]
			public _003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x2336D1C", Offset = "0x2336D1C", VA = "0x2336D1C")]
			public _003C_003Ec__DisplayClass45_1()
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x2336D24", Offset = "0x2336D24", VA = "0x2336D24")]
			internal void _003CSetExtensionDataDelegates_003Eb__0(object o, string key, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CA2C", Offset = "0x18CA2C")] object value)
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1837F4", Offset = "0x1837F4")]
		private sealed class _003C_003Ec__DisplayClass45_2
		{
			[Token(Token = "0x4000230")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186990", Offset = "0x186990")]
			public ObjectConstructor<object> createEnumerableWrapper;

			[Token(Token = "0x4000231")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186A00", Offset = "0x186A00")]
			public _003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals2;

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x2336F84", Offset = "0x2336F84", VA = "0x2336F84")]
			public _003C_003Ec__DisplayClass45_2()
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2336F8C", Offset = "0x2336F8C", VA = "0x2336F8C")]
			internal IEnumerable<KeyValuePair<object, object>> _003CSetExtensionDataDelegates_003Eb__1(object o)
			{
				return null;
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183804", Offset = "0x183804")]
		private sealed class _003C_003Ec__DisplayClass62_0
		{
			[Token(Token = "0x4000232")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186A14", Offset = "0x186A14")]
			public NamingStrategy namingStrategy;

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x23370C8", Offset = "0x23370C8", VA = "0x23370C8")]
			public _003C_003Ec__DisplayClass62_0()
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x23370D0", Offset = "0x23370D0", VA = "0x23370D0")]
			internal string _003CCreateDictionaryContract_003Eb__0(string s)
			{
				return null;
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183814", Offset = "0x183814")]
		private sealed class _003C_003Ec__DisplayClass67_0
		{
			[Token(Token = "0x4000233")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186A28", Offset = "0x186A28")]
			public NamingStrategy namingStrategy;

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x23370F0", Offset = "0x23370F0", VA = "0x23370F0")]
			public _003C_003Ec__DisplayClass67_0()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x23370F8", Offset = "0x23370F8", VA = "0x23370F8")]
			internal string _003CCreateDynamicContract_003Eb__0(string s)
			{
				return null;
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183824", Offset = "0x183824")]
		private sealed class _003C_003Ec__DisplayClass80_0
		{
			[Token(Token = "0x4000234")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186A3C", Offset = "0x186A3C")]
			public MethodCall<object, object> shouldSerializeCall;

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x2337118", Offset = "0x2337118", VA = "0x2337118")]
			public _003C_003Ec__DisplayClass80_0()
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x2337120", Offset = "0x2337120", VA = "0x2337120")]
			internal bool _003CCreateShouldSerializeTest_003Eb__0(object o)
			{
				return default;
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183834", Offset = "0x183834")]
		private sealed class _003C_003Ec__DisplayClass81_0
		{
			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186AB4", Offset = "0x186AB4")]
			public Func<object, object> specifiedPropertyGet;

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2337260", Offset = "0x2337260", VA = "0x2337260")]
			public _003C_003Ec__DisplayClass81_0()
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x2337268", Offset = "0x2337268", VA = "0x2337268")]
			internal bool _003CSetIsSpecifiedActions_003Eb__0(object o)
			{
				return default;
			}
		}

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IContractResolver _instance;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] BlacklistedTypeNames;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x10")]
		private static readonly JsonConverter[] BuiltInConverters;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x10")]
		private readonly DefaultJsonNameTable _nameTable;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x18")]
		private readonly ThreadSafeStore<Type, JsonContract> _contractCache;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1864F8", Offset = "0x1864F8")]
		private BindingFlags DefaultMembersSearchFlags__BackingField;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186508", Offset = "0x186508")]
		private bool SerializeCompilerGeneratedMembers__BackingField;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x25")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186518", Offset = "0x186518")]
		private bool IgnoreSerializableInterface__BackingField;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x26")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186528", Offset = "0x186528")]
		private bool IgnoreSerializableAttribute__BackingField;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x27")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186538", Offset = "0x186538")]
		private bool IgnoreIsSpecifiedMembers__BackingField;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186548", Offset = "0x186548")]
		private bool IgnoreShouldSerializeMembers__BackingField;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186558", Offset = "0x186558")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186558", Offset = "0x186558")]
		private NamingStrategy NamingStrategy__BackingField;

		[Token(Token = "0x17000078")]
		internal static IContractResolver Instance
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x22B93F0", Offset = "0x22B93F0", VA = "0x22B93F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x18EF50", Offset = "0x18EF50")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x22B9454", Offset = "0x22B9454", VA = "0x22B9454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189540", Offset = "0x189540")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x22B945C", Offset = "0x22B945C", VA = "0x22B945C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189550", Offset = "0x189550")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool SerializeCompilerGeneratedMembers
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x22B9464", Offset = "0x22B9464", VA = "0x22B9464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189560", Offset = "0x189560")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007B")]
		public bool IgnoreSerializableInterface
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x22B946C", Offset = "0x22B946C", VA = "0x22B946C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189570", Offset = "0x189570")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007C")]
		public bool IgnoreSerializableAttribute
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x22B9474", Offset = "0x22B9474", VA = "0x22B9474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189580", Offset = "0x189580")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x22B947C", Offset = "0x22B947C", VA = "0x22B947C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189590", Offset = "0x189590")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public bool IgnoreIsSpecifiedMembers
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x22B9484", Offset = "0x22B9484", VA = "0x22B9484")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1895A0", Offset = "0x1895A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007E")]
		public bool IgnoreShouldSerializeMembers
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x22B948C", Offset = "0x22B948C", VA = "0x22B948C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1895B0", Offset = "0x1895B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007F")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EF88", Offset = "0x18EF88")]
		public NamingStrategy NamingStrategy
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x22B9494", Offset = "0x22B9494", VA = "0x22B9494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1895C0", Offset = "0x1895C0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1895C0", Offset = "0x1895C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x22B949C", Offset = "0x22B949C", VA = "0x22B949C")]
		public DefaultContractResolver()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x22B9674", Offset = "0x22B9674", VA = "0x22B9674", Slot = "5")]
		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x22B96FC", Offset = "0x22B96FC", VA = "0x22B96FC")]
		private static bool FilterMembers(MemberInfo member)
		{
			return default;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x22B9874", Offset = "0x22B9874", VA = "0x22B9874", Slot = "6")]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x22BA57C", Offset = "0x22BA57C", VA = "0x22BA57C")]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return default;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x22BA690", Offset = "0x22BA690", VA = "0x22BA690", Slot = "7")]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x22BC404", Offset = "0x22BC404", VA = "0x22BC404")]
		private static void ThrowUnableToSerializeError(object o, StreamingContext context)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x22BB8BC", Offset = "0x22BB8BC", VA = "0x22BB8BC")]
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x22BBAFC", Offset = "0x22BBAFC", VA = "0x22BBAFC")]
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x22BAFDC", Offset = "0x22BAFDC", VA = "0x22BAFDC")]
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x22BB5B8", Offset = "0x22BB5B8", VA = "0x22BB5B8")]
		private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x22BB568", Offset = "0x22BB568", VA = "0x22BB568")]
		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x22BC7C8", Offset = "0x22BC7C8", VA = "0x22BC7C8", Slot = "8")]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x22BC70C", Offset = "0x22BC70C", VA = "0x22BC70C")]
		private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x22BC95C", Offset = "0x22BC95C", VA = "0x22BC95C", Slot = "9")]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C74C", Offset = "0x18C74C")] JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x22BD374", Offset = "0x22BD374", VA = "0x22BD374", Slot = "10")]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x22BD3E0", Offset = "0x22BD3E0", VA = "0x22BD3E0")]
		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x22BAD30", Offset = "0x22BAD30", VA = "0x22BAD30")]
		private void InitializeContract(JsonContract contract)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x22BD498", Offset = "0x22BD498", VA = "0x22BD498")]
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x22BD5F4", Offset = "0x22BD5F4", VA = "0x22BD5F4")]
		private void GetCallbackMethodsForType(Type type, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C760", Offset = "0x18C760")] out List<SerializationCallback> onSerializing, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C7D0", Offset = "0x18C7D0")] out List<SerializationCallback> onSerialized, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C840", Offset = "0x18C840")] out List<SerializationCallback> onDeserializing, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C8B0", Offset = "0x18C8B0")] out List<SerializationCallback> onDeserialized, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C920", Offset = "0x18C920")] out List<SerializationErrorCallback> onError)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x22BE9F8", Offset = "0x22BE9F8", VA = "0x22BE9F8")]
		private static bool IsConcurrentOrObservableCollection(Type t)
		{
			return default;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x22BE040", Offset = "0x22BE040", VA = "0x22BE040")]
		private static bool ShouldSkipDeserialized(Type t)
		{
			return default;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x22BDF54", Offset = "0x22BDF54", VA = "0x22BDF54")]
		private static bool ShouldSkipSerializing(Type t)
		{
			return default;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x22BC4C8", Offset = "0x22BC4C8", VA = "0x22BC4C8")]
		private List<Type> GetClassHierarchyForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x22BEB3C", Offset = "0x22BEB3C", VA = "0x22BEB3C", Slot = "11")]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x22BF110", Offset = "0x22BF110", VA = "0x22BF110", Slot = "12")]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x22BF4A4", Offset = "0x22BF4A4", VA = "0x22BF4A4", Slot = "13")]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x22BF51C", Offset = "0x22BF51C", VA = "0x22BF51C", Slot = "14")]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x22BF594", Offset = "0x22BF594", VA = "0x22BF594", Slot = "15")]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x22BF7E0", Offset = "0x22BF7E0", VA = "0x22BF7E0", Slot = "16")]
		protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x22BFA34", Offset = "0x22BFA34", VA = "0x22BFA34", Slot = "17")]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x22BFAAC", Offset = "0x22BFAAC", VA = "0x22BFAAC", Slot = "18")]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x22BFF3C", Offset = "0x22BFF3C", VA = "0x22BFF3C")]
		internal static bool IsJsonPrimitiveType(Type t)
		{
			return default;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x22C0140", Offset = "0x22C0140", VA = "0x22C0140")]
		internal static bool IsIConvertible(Type t)
		{
			return default;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x22BFFF8", Offset = "0x22BFFF8", VA = "0x22BFFF8")]
		internal static bool CanConvertToString(Type type)
		{
			return default;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x22BE12C", Offset = "0x22BE12C", VA = "0x22BE12C")]
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C990", Offset = "0x18C990")] MethodInfo currentCallback, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C9A4", Offset = "0x18C9A4")] ref Type prevAttributeType)
		{
			return default;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x22C02F0", Offset = "0x22C02F0", VA = "0x22C02F0")]
		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x22C03FC", Offset = "0x22C03FC", VA = "0x22C03FC", Slot = "19")]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x22C09F0", Offset = "0x22C09F0", VA = "0x22C09F0", Slot = "20")]
		internal virtual DefaultJsonNameTable GetNameTable()
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x22C09F8", Offset = "0x22C09F8", VA = "0x22C09F8", Slot = "21")]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x22C0A60", Offset = "0x22C0A60", VA = "0x22C0A60", Slot = "22")]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x22BCBE8", Offset = "0x22BCBE8", VA = "0x22BCBE8")]
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x22C0C60", Offset = "0x22C0C60", VA = "0x22C0C60")]
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x22C0EF0", Offset = "0x22C0EF0", VA = "0x22C0EF0")]
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x22C1228", Offset = "0x22C1228", VA = "0x22C1228", Slot = "23")]
		protected virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x22C1248", Offset = "0x22C1248", VA = "0x22C1248", Slot = "24")]
		protected virtual string ResolveExtensionDataName(string extensionDataName)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x22C1264", Offset = "0x22C1264", VA = "0x22C1264", Slot = "25")]
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x22B3990", Offset = "0x22B3990", VA = "0x22B3990")]
		public string GetResolvedPropertyName(string propertyName)
		{
			return null;
		}
	}
}
