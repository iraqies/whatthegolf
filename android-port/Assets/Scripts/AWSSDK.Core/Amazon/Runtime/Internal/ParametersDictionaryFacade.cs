using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x25CB8", Offset = "0x25CB8")]
	public class ParametersDictionaryFacade : IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25CF0", Offset = "0x25CF0")]
		private sealed class _003CGetEnumerator_003Ed__23 : IEnumerator<KeyValuePair<string, string>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400057B")]
			[FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, string> _003C_003E2__current;

			[Token(Token = "0x400057C")]
			[FieldOffset(Offset = "0x28")]
			public ParametersDictionaryFacade _003C_003E4__this;

			[Token(Token = "0x400057D")]
			[FieldOffset(Offset = "0x30")]
			private SortedDictionary<string, ParameterValue>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000313")]
			private KeyValuePair<string, string> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002ECurrent
			{
				[Token(Token = "0x6000B87")]
				[Address(RVA = "0x1290870", Offset = "0x1290870", VA = "0x1290870", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000314")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000B89")]
				[Address(RVA = "0x12908BC", Offset = "0x12908BC", VA = "0x12908BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x1290574", Offset = "0x1290574", VA = "0x1290574")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000B84")]
			[Address(RVA = "0x12905A0", Offset = "0x12905A0", VA = "0x12905A0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x1290674", Offset = "0x1290674", VA = "0x1290674", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x1290618", Offset = "0x1290618", VA = "0x1290618")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x1290870", Offset = "0x1290870", VA = "0x1290870", Slot = "4")]
			[DebuggerHidden]
			private KeyValuePair<string, string> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EString_003E_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x129087C", Offset = "0x129087C", VA = "0x129087C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x12908BC", Offset = "0x12908BC", VA = "0x12908BC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x10")]
		private readonly ParameterCollection _parameterCollection;

		[Token(Token = "0x1700030E")]
		public int Count
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x1246E3C", Offset = "0x1246E3C", VA = "0x1246E3C", Slot = "12")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700030F")]
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x1246F58", Offset = "0x1246F58", VA = "0x1246F58", Slot = "4")]
		public string get_Item(string key)
		{
			return null;
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x1246FC0", Offset = "0x1246FC0", VA = "0x1246FC0", Slot = "5")]
		public void set_Item(string key, string value)
		{
		}

		[Token(Token = "0x17000310")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x12470AC", Offset = "0x12470AC", VA = "0x12470AC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000311")]
		public ICollection<string> Values
		{
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x12472EC", Offset = "0x12472EC", VA = "0x12472EC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000312")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x12479C4", Offset = "0x12479C4", VA = "0x12479C4", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x1246934", Offset = "0x1246934", VA = "0x1246934")]
		public ParametersDictionaryFacade(ParameterCollection collection)
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x12469AC", Offset = "0x12469AC", VA = "0x12469AC")]
		private static string ParameterValueToString(ParameterValue pv)
		{
			return null;
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x1246B98", Offset = "0x1246B98", VA = "0x1246B98")]
		private static void UpdateParameterValue(ParameterValue pv, string newValue)
		{
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x1246D9C", Offset = "0x1246D9C", VA = "0x1246D9C", Slot = "9")]
		public void Add(string key, string value)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x1246E90", Offset = "0x1246E90", VA = "0x1246E90", Slot = "8")]
		public bool ContainsKey(string key)
		{
			return default;
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x1246EF4", Offset = "0x1246EF4", VA = "0x1246EF4", Slot = "10")]
		public bool Remove(string key)
		{
			return default;
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x1247100", Offset = "0x1247100", VA = "0x1247100", Slot = "11")]
		public bool TryGetValue(string key, out string value)
		{
			return default;
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x12471A4", Offset = "0x12471A4", VA = "0x12471A4", Slot = "18")]
		public bool Remove(KeyValuePair<string, string> item)
		{
			return default;
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x12474D0", Offset = "0x12474D0", VA = "0x12474D0", Slot = "14")]
		public void Add(KeyValuePair<string, string> item)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x124723C", Offset = "0x124723C", VA = "0x124723C", Slot = "16")]
		public bool Contains(KeyValuePair<string, string> item)
		{
			return default;
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x1247588", Offset = "0x1247588", VA = "0x1247588", Slot = "17")]
		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x1247950", Offset = "0x1247950", VA = "0x1247950", Slot = "19")]
		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x1247A7C", Offset = "0x1247A7C", VA = "0x1247A7C", Slot = "20")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x1247AF0", Offset = "0x1247AF0", VA = "0x1247AF0", Slot = "15")]
		public void Clear()
		{
		}
	}
}
