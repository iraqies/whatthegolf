using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184264", Offset = "0x184264")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184264", Offset = "0x184264")]
	public class JProperty : JContainer
	{
		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1842A4", Offset = "0x1842A4")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1842A4", Offset = "0x1842A4")]
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			[Token(Token = "0x20000D5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1842F4", Offset = "0x1842F4")]
			private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<JToken>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000307")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x4000308")]
				[FieldOffset(Offset = "0x18")]
				private JToken _003C_003E2__current;

				[Token(Token = "0x4000309")]
				[FieldOffset(Offset = "0x20")]
				[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188274", Offset = "0x188274")]
				public JPropertyList _003C_003E4__this;

				[Token(Token = "0x17000122")]
				private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
				{
					[Token(Token = "0x6000688")]
					[Address(RVA = "0x233A420", Offset = "0x233A420", VA = "0x233A420", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000123")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600068A")]
					[Address(RVA = "0x233A468", Offset = "0x233A468", VA = "0x233A468", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000685")]
				[Address(RVA = "0x2338EC8", Offset = "0x2338EC8", VA = "0x2338EC8")]
				[DebuggerHidden]
				public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x6000686")]
				[Address(RVA = "0x233A3C4", Offset = "0x233A3C4", VA = "0x233A3C4", Slot = "5")]
				[DebuggerHidden]
				private void System_002EIDisposable_002EDispose()
				{
				}

				[Token(Token = "0x6000687")]
				[Address(RVA = "0x233A3C8", Offset = "0x233A3C8", VA = "0x233A3C8", Slot = "6")]
				private bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000688")]
				[Address(RVA = "0x233A420", Offset = "0x233A420", VA = "0x233A420", Slot = "4")]
				[DebuggerHidden]
				private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6000689")]
				[Address(RVA = "0x233A428", Offset = "0x233A428", VA = "0x233A428", Slot = "8")]
				[DebuggerHidden]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}

				[Token(Token = "0x600068A")]
				[Address(RVA = "0x233A468", Offset = "0x233A468", VA = "0x233A468", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x4000306")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188260", Offset = "0x188260")]
			internal JToken _token;

			[Token(Token = "0x1700011F")]
			public int Count
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x233901C", Offset = "0x233901C", VA = "0x233901C", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000120")]
			public bool IsReadOnly
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x233902C", Offset = "0x233902C", VA = "0x233902C", Slot = "10")]
				get
				{
					return default;
				}
			}

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x17000121")]
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x2339064", Offset = "0x2339064", VA = "0x2339064", Slot = "4")]
			public JToken get_Item(int index)
			{
				return null;
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x23390B0", Offset = "0x23390B0", VA = "0x23390B0", Slot = "5")]
			public void set_Item(int index, JToken value)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x2338E54", Offset = "0x2338E54", VA = "0x2338E54", Slot = "16")]
			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x2338EF4", Offset = "0x2338EF4", VA = "0x2338EF4", Slot = "17")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x2338F68", Offset = "0x2338F68", VA = "0x2338F68", Slot = "11")]
			public void Add(JToken item)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x2338F70", Offset = "0x2338F70", VA = "0x2338F70", Slot = "12")]
			public void Clear()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x2338F78", Offset = "0x2338F78", VA = "0x2338F78", Slot = "13")]
			public bool Contains(JToken item)
			{
				return default;
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x2338F88", Offset = "0x2338F88", VA = "0x2338F88", Slot = "14")]
			public void CopyTo(JToken[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2339000", Offset = "0x2339000", VA = "0x2339000", Slot = "15")]
			public bool Remove(JToken item)
			{
				return default;
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x2339034", Offset = "0x2339034", VA = "0x2339034", Slot = "6")]
			public int IndexOf(JToken item)
			{
				return default;
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x2339044", Offset = "0x2339044", VA = "0x2339044", Slot = "7")]
			public void Insert(int index, JToken item)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x2339054", Offset = "0x2339054", VA = "0x2339054", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x23390FC", Offset = "0x23390FC", VA = "0x23390FC")]
			public JPropertyList()
			{
			}
		}

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x58")]
		private readonly JPropertyList _content;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x60")]
		private readonly string _name;

		[Token(Token = "0x1700011B")]
		protected override IList<JToken> ChildrenTokens
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x22D2214", Offset = "0x22D2214", VA = "0x22D2214", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		public string Name
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x22D221C", Offset = "0x22D221C", VA = "0x22D221C")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public JToken Value
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x22CEBE8", Offset = "0x22CEBE8", VA = "0x22CEBE8")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x22D0954", Offset = "0x22D0954", VA = "0x22D0954")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public override JTokenType Type
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x22D2A78", Offset = "0x22D2A78", VA = "0x22D2A78", Slot = "12")]
			[DebuggerStepThrough]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x22D2224", Offset = "0x22D2224", VA = "0x22D2224")]
		public JProperty(JProperty other)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x22D22A8", Offset = "0x22D22A8", VA = "0x22D22A8", Slot = "73")]
		internal override JToken GetItem(int index)
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x22D2308", Offset = "0x22D2308", VA = "0x22D2308", Slot = "74")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A810", Offset = "0x18A810")]
		internal override void SetItem(int index, JToken item)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x22D251C", Offset = "0x22D251C", VA = "0x22D251C", Slot = "72")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A824", Offset = "0x18A824")]
		internal override bool RemoveItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x22D2618", Offset = "0x22D2618", VA = "0x22D2618", Slot = "71")]
		internal override void RemoveItemAt(int index)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x22D2714", Offset = "0x22D2714", VA = "0x22D2714", Slot = "69")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A838", Offset = "0x18A838")]
		internal override int IndexOfItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x22D273C", Offset = "0x22D273C", VA = "0x22D273C", Slot = "70")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A84C", Offset = "0x18A84C")]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck)
		{
			return default;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x22D28A0", Offset = "0x22D28A0", VA = "0x22D28A0", Slot = "77")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A860", Offset = "0x18A860")]
		internal override bool ContainsItem(JToken item)
		{
			return default;
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x22D28C4", Offset = "0x22D28C4", VA = "0x22D28C4", Slot = "75")]
		internal override void ClearItems()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x22D29C0", Offset = "0x22D29C0", VA = "0x22D29C0", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x22CF278", Offset = "0x22CF278", VA = "0x22CF278")]
		internal JProperty(string name)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x22D0D40", Offset = "0x22D0D40", VA = "0x22D0D40")]
		public JProperty(string name, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E088", Offset = "0x18E088")] object content)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x22D2A80", Offset = "0x22D2A80", VA = "0x22D2A80", Slot = "17")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x22D2B10", Offset = "0x22D2B10", VA = "0x22D2B10")]
		public static JProperty Load(JsonReader reader, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E0AC", Offset = "0x18E0AC")] JsonLoadSettings settings)
		{
			return null;
		}
	}
}
