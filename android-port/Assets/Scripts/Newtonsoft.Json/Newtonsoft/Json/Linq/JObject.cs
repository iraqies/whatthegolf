using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184170", Offset = "0x184170")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184170", Offset = "0x184170")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x184170", Offset = "0x184170")]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1841D4", Offset = "0x1841D4")]
		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			[Serializable]
			[Token(Token = "0x20000D1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184244", Offset = "0x184244")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x40002FE")]
				[FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18813C", Offset = "0x18813C")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x40002FF")]
				[FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188150", Offset = "0x188150")]
				public static Func<JProperty, string> _003C_003E9__2_0;

				[Token(Token = "0x600065A")]
				[Address(RVA = "0x233A3A4", Offset = "0x233A3A4", VA = "0x233A3A4")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x600065B")]
				[Address(RVA = "0x233A3AC", Offset = "0x233A3AC", VA = "0x233A3AC")]
				[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A78C", Offset = "0x18A78C")]
				internal string _003CGetDynamicMemberNames_003Eb__2_0(JProperty p)
				{
					return null;
				}
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x2338CA4", Offset = "0x2338CA4", VA = "0x2338CA4", Slot = "4")]
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return null;
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x2338DFC", Offset = "0x2338DFC", VA = "0x2338DFC")]
			public JObjectDynamicProxy()
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184254", Offset = "0x184254")]
		private sealed class _003CGetEnumerator_003Ed__63 : IEnumerator<KeyValuePair<string, JToken>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000300")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000301")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188164", Offset = "0x188164")]
			private KeyValuePair<string, JToken> _003C_003E2__current;

			[Token(Token = "0x4000302")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1881DC", Offset = "0x1881DC")]
			public JObject _003C_003E4__this;

			[Token(Token = "0x4000303")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1881F0", Offset = "0x1881F0")]
			private IEnumerator<JToken> _003C_003E7__wrap1;

			[Token(Token = "0x17000119")]
			private KeyValuePair<string, JToken> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECurrent
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x2338BF0", Offset = "0x2338BF0", VA = "0x2338BF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700011A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x2338C3C", Offset = "0x2338C3C", VA = "0x2338C3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x23386AC", Offset = "0x23386AC", VA = "0x23386AC")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__63(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x23386D8", Offset = "0x23386D8", VA = "0x23386D8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x2338878", Offset = "0x2338878", VA = "0x2338878", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x23387B4", Offset = "0x23387B4", VA = "0x23387B4")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x2338BF0", Offset = "0x2338BF0", VA = "0x2338BF0", Slot = "4")]
			[DebuggerHidden]
			private KeyValuePair<string, JToken> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x2338BFC", Offset = "0x2338BFC", VA = "0x2338BFC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x2338C3C", Offset = "0x2338C3C", VA = "0x2338C3C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x58")]
		private readonly JPropertyKeyedCollection _properties;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1880C4", Offset = "0x1880C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1880C4", Offset = "0x1880C4")]
		private PropertyChangedEventHandler m_PropertyChanged;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188100", Offset = "0x188100")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188100", Offset = "0x188100")]
		private PropertyChangingEventHandler m_PropertyChanging;

		[Token(Token = "0x17000113")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x22CFC94", Offset = "0x22CFC94", VA = "0x22CFC94", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x22D0730", Offset = "0x22D0730", VA = "0x22D0730", Slot = "12")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000115"), AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F750", Offset = "0x18F750")]
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x22D078C", Offset = "0x22D078C", VA = "0x22D078C", Slot = "81")]
		public JToken get_Item(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x22D0810", Offset = "0x22D0810", VA = "0x22D0810", Slot = "82")]
		public void set_Item(string propertyName, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DE4C", Offset = "0x18DE4C")] JToken value)
		{
		}

		[Token(Token = "0x17000116")]
		private ICollection<string> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EKeys
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x22D1008", Offset = "0x22D1008", VA = "0x22D1008", Slot = "83")]
			get
			{
				return System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Keys();
			}
		}

		[Token(Token = "0x17000117")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F764", Offset = "0x18F764")]
		private ICollection<JToken> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EValues
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x22D11B8", Offset = "0x22D11B8", VA = "0x22D11B8", Slot = "84")]
			get
			{
				return System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Values();
			}
		}

		[Token(Token = "0x17000118")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EIsReadOnly
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x22D17D0", Offset = "0x22D17D0", VA = "0x22D17D0", Slot = "90")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x14000004")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E720", Offset = "0x18E720")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x22CFC9C", Offset = "0x22CFC9C", VA = "0x22CFC9C", Slot = "97")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A624", Offset = "0x18A624")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A624", Offset = "0x18A624")]
			add
			{
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x22CFD40", Offset = "0x22CFD40", VA = "0x22CFD40", Slot = "98")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A660", Offset = "0x18A660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A660", Offset = "0x18A660")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E734", Offset = "0x18E734")]
		public event PropertyChangingEventHandler PropertyChanging
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x22CFDE4", Offset = "0x22CFDE4", VA = "0x22CFDE4", Slot = "111")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A69C", Offset = "0x18A69C")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A69C", Offset = "0x18A69C")]
			add
			{
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x22CFE88", Offset = "0x22CFE88", VA = "0x22CFE88", Slot = "112")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A6D8", Offset = "0x18A6D8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A6D8", Offset = "0x18A6D8")]
			remove
			{
			}
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x22CEC04", Offset = "0x22CEC04", VA = "0x22CEC04")]
		public JObject()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x22CFFC8", Offset = "0x22CFFC8", VA = "0x22CFFC8")]
		public JObject(JObject other)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x22D00B4", Offset = "0x22D00B4", VA = "0x22D00B4", Slot = "69")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A714", Offset = "0x18A714")]
		internal override int IndexOfItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x22D01A4", Offset = "0x22D01A4", VA = "0x22D01A4", Slot = "70")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A728", Offset = "0x18A728")]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck)
		{
			return default;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x22D0218", Offset = "0x22D0218", VA = "0x22D0218", Slot = "79")]
		internal override void ValidateToken(JToken o, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DE38", Offset = "0x18DE38")] JToken existing)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x22D0560", Offset = "0x22D0560", VA = "0x22D0560")]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x22D06A8", Offset = "0x22D06A8", VA = "0x22D06A8")]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x22D06CC", Offset = "0x22D06CC", VA = "0x22D06CC", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x22D0738", Offset = "0x22D0738", VA = "0x22D0738")]
		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x22CF090", Offset = "0x22CF090", VA = "0x22CF090")]
		public JProperty Property(string name, StringComparison comparison)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x22D0A5C", Offset = "0x22D0A5C", VA = "0x22D0A5C")]
		public static JObject Load(JsonReader reader, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DE60", Offset = "0x18DE60")] JsonLoadSettings settings)
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x22D0C54", Offset = "0x22D0C54", VA = "0x22D0C54", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x22D09D4", Offset = "0x22D09D4", VA = "0x22D09D4", Slot = "86")]
		public void Add(string propertyName, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DE84", Offset = "0x18DE84")] JToken value)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x22D0EDC", Offset = "0x22D0EDC", VA = "0x22D0EDC", Slot = "85")]
		public bool ContainsKey(string propertyName)
		{
			return default;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x22D1008", Offset = "0x22D1008", VA = "0x22D1008", Slot = "83")]
		private ICollection<string> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x22D10C4", Offset = "0x22D10C4", VA = "0x22D10C4", Slot = "87")]
		public bool Remove(string propertyName)
		{
			return default;
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x22D116C", Offset = "0x22D116C", VA = "0x22D116C", Slot = "88")]
		public bool TryGetValue(string propertyName, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DE98", Offset = "0x18DE98")] out JToken value)
		{
			return default;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x22D11B8", Offset = "0x22D11B8", VA = "0x22D11B8", Slot = "84")]
		private ICollection<JToken> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x22D11F8", Offset = "0x22D11F8", VA = "0x22D11F8", Slot = "91")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EAdd([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DEAC", Offset = "0x18DEAC")] KeyValuePair<string, JToken> item)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x22D1298", Offset = "0x22D1298", VA = "0x22D1298", Slot = "92")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EClear()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x22D12A8", Offset = "0x22D12A8", VA = "0x22D12A8", Slot = "93")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EContains([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DF24", Offset = "0x18DF24")] KeyValuePair<string, JToken> item)
		{
			return default;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x22D1330", Offset = "0x22D1330", VA = "0x22D1330", Slot = "94")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECopyTo([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DF9C", Offset = "0x18DF9C")] KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x22D17D0", Offset = "0x22D17D0", VA = "0x22D17D0", Slot = "90")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x22D17D8", Offset = "0x22D17D8", VA = "0x22D17D8", Slot = "95")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ERemove([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E010", Offset = "0x18E010")] KeyValuePair<string, JToken> item)
		{
			return default;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x22D1948", Offset = "0x22D1948", VA = "0x22D1948", Slot = "96")]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x22D19BC", Offset = "0x22D19BC", VA = "0x22D19BC", Slot = "113")]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x22D1A4C", Offset = "0x22D1A4C", VA = "0x22D1A4C", Slot = "114")]
		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x22D1ADC", Offset = "0x22D1ADC", VA = "0x22D1ADC", Slot = "108")]
		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties()
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x22D1B94", Offset = "0x22D1B94", VA = "0x22D1B94", Slot = "109")]
		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties(Attribute[] attributes)
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x22D1F28", Offset = "0x22D1F28", VA = "0x22D1F28", Slot = "99")]
		private AttributeCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetAttributes()
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x22D1F8C", Offset = "0x22D1F8C", VA = "0x22D1F8C", Slot = "100")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A73C", Offset = "0x18A73C")]
		private string System_002EComponentModel_002EICustomTypeDescriptor_002EGetClassName()
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x22D1F94", Offset = "0x22D1F94", VA = "0x22D1F94", Slot = "101")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A750", Offset = "0x18A750")]
		private string System_002EComponentModel_002EICustomTypeDescriptor_002EGetComponentName()
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x22D1F9C", Offset = "0x22D1F9C", VA = "0x22D1F9C", Slot = "102")]
		private TypeConverter System_002EComponentModel_002EICustomTypeDescriptor_002EGetConverter()
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x22D1FF4", Offset = "0x22D1FF4", VA = "0x22D1FF4", Slot = "103")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A764", Offset = "0x18A764")]
		private EventDescriptor System_002EComponentModel_002EICustomTypeDescriptor_002EGetDefaultEvent()
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x22D1FFC", Offset = "0x22D1FFC", VA = "0x22D1FFC", Slot = "104")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A778", Offset = "0x18A778")]
		private PropertyDescriptor System_002EComponentModel_002EICustomTypeDescriptor_002EGetDefaultProperty()
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x22D2004", Offset = "0x22D2004", VA = "0x22D2004", Slot = "105")]
		private object System_002EComponentModel_002EICustomTypeDescriptor_002EGetEditor(Type editorBaseType)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x22D200C", Offset = "0x22D200C", VA = "0x22D200C", Slot = "107")]
		private EventDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetEvents(Attribute[] attributes)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x22D2070", Offset = "0x22D2070", VA = "0x22D2070", Slot = "106")]
		private EventDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetEvents()
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x22D20D4", Offset = "0x22D20D4", VA = "0x22D20D4", Slot = "110")]
		private object System_002EComponentModel_002EICustomTypeDescriptor_002EGetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x22D215C", Offset = "0x22D215C", VA = "0x22D215C", Slot = "18")]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}
	}
}
