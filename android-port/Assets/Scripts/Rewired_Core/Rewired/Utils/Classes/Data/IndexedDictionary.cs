using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[Token(Token = "0x200036F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x192138", Offset = "0x192138")]
	internal class IndexedDictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyList
	{
		[Token(Token = "0x2000370")]
		private struct nnXpQNToQOcOXCGmLUrlooHLNULg
		{
			[Token(Token = "0x40011B3")]
			[FieldOffset(Offset = "0x0")]
			public TKey qwkeeArhjFVfINdRhYgfKXVRHPQW;

			[Token(Token = "0x40011B4")]
			[FieldOffset(Offset = "0x0")]
			public TValue yYOUbwIbBcyPAQvjeAEXVsjzLAln;

			[Token(Token = "0x6001A94")]
			public nnXpQNToQOcOXCGmLUrlooHLNULg(TKey P_0, TValue P_1)
			{
			}

			[Token(Token = "0x6001A95")]
			public KeyValuePair<TKey, TValue> uXAyDTEMHJilashiZEIjGfZgTJyo()
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x2000371")]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			[Token(Token = "0x40011B5")]
			[FieldOffset(Offset = "0x0")]
			private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			[Token(Token = "0x40011B6")]
			[FieldOffset(Offset = "0x0")]
			private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

			[Token(Token = "0x40011B7")]
			[FieldOffset(Offset = "0x0")]
			private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

			[Token(Token = "0x40011B8")]
			[FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> SgJVPHrjFyHgCSEpxtgUijWhNNop;

			[Token(Token = "0x40011B9")]
			[FieldOffset(Offset = "0x0")]
			private int hVLAXWNvglyqqvtcCiHFclAncMWO;

			[Token(Token = "0x170006FF")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6001A98")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000700")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001A9A")]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x17000701")]
			private DictionaryEntry System_002ECollections_002EIDictionaryEnumerator_002EEntry
			{
				[Token(Token = "0x6001A9C")]
				get
				{
					return System_002ECollections_002EIDictionaryEnumerator_002Eget_Entry();
				}
			}

			[Token(Token = "0x17000702")]
			private object System_002ECollections_002EIDictionaryEnumerator_002EKey
			{
				[Token(Token = "0x6001A9D")]
				get
				{
					return System_002ECollections_002EIDictionaryEnumerator_002Eget_Key();
				}
			}

			[Token(Token = "0x17000703")]
			private object System_002ECollections_002EIDictionaryEnumerator_002EValue
			{
				[Token(Token = "0x6001A9E")]
				get
				{
					return System_002ECollections_002EIDictionaryEnumerator_002Eget_Value();
				}
			}

			[Token(Token = "0x6001A96")]
			internal Enumerator(IndexedDictionary<TKey, TValue> P_0, int P_1)
			{
			}

			[Token(Token = "0x6001A97")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001A99")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001A9A")]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001A9B")]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001A9C")]
			private DictionaryEntry System_002ECollections_002EIDictionaryEnumerator_002Eget_Entry()
			{
				return default;
			}

			[Token(Token = "0x6001A9D")]
			private object System_002ECollections_002EIDictionaryEnumerator_002Eget_Key()
			{
				return null;
			}

			[Token(Token = "0x6001A9E")]
			private object System_002ECollections_002EIDictionaryEnumerator_002Eget_Value()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000372")]
		public sealed class KeyCollection : IEnumerable, IEnumerable<TKey>, ICollection, ICollection<TKey>
		{
			[Serializable]
			[Token(Token = "0x2000373")]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
			{
				[Token(Token = "0x40011BB")]
				[FieldOffset(Offset = "0x0")]
				private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				[Token(Token = "0x40011BC")]
				[FieldOffset(Offset = "0x0")]
				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				[Token(Token = "0x40011BD")]
				[FieldOffset(Offset = "0x0")]
				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				[Token(Token = "0x40011BE")]
				[FieldOffset(Offset = "0x0")]
				private TKey szsPnNMRosmkGGKYRlfkUtAelqA;

				[Token(Token = "0x17000708")]
				public TKey Current
				{
					[Token(Token = "0x6001AAF")]
					get
					{
						return (TKey)null;
					}
				}

				[Token(Token = "0x17000709")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001AB0")]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001AAC")]
				internal Enumerator(IndexedDictionary<TKey, TValue> P_0)
				{
				}

				[Token(Token = "0x6001AAD")]
				public void Dispose()
				{
				}

				[Token(Token = "0x6001AAE")]
				public bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001AB0")]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001AB1")]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			[Token(Token = "0x40011BA")]
			[FieldOffset(Offset = "0x0")]
			private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			[Token(Token = "0x17000704")]
			public int Count
			{
				[Token(Token = "0x6001AA1")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000705")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EIsReadOnly
			{
				[Token(Token = "0x6001AA2")]
				get
				{
					return System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002Eget_IsReadOnly();
				}
			}

			[Token(Token = "0x17000706")]
			private bool System_002ECollections_002EICollection_002EIsSynchronized
			{
				[Token(Token = "0x6001AAA")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_IsSynchronized();
				}
			}

			[Token(Token = "0x17000707")]
			private object System_002ECollections_002EICollection_002ESyncRoot
			{
				[Token(Token = "0x6001AAB")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_SyncRoot();
				}
			}

			[Token(Token = "0x6001A9F")]
			public KeyCollection(IndexedDictionary<TKey, TValue> P_0)
			{
			}

			[Token(Token = "0x6001AA0")]
			public void CopyTo(TKey[] array, int index)
			{
			}

			[Token(Token = "0x6001AA2")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002Eget_IsReadOnly()
			{
				return default;
			}

			[Token(Token = "0x6001AA3")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EAdd(TKey P_0)
			{
			}

			[Token(Token = "0x6001AA4")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EClear()
			{
			}

			[Token(Token = "0x6001AA5")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EContains(TKey P_0)
			{
				return default;
			}

			[Token(Token = "0x6001AA6")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002ERemove(TKey P_0)
			{
				return default;
			}

			[Token(Token = "0x6001AA7")]
			private IEnumerator<TKey> System_002ECollections_002EGeneric_002EIEnumerable_003CTKey_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001AA8")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001AA9")]
			private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x6001AAA")]
			private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
			{
				return default;
			}

			[Token(Token = "0x6001AAB")]
			private object System_002ECollections_002EICollection_002Eget_SyncRoot()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000374")]
		public sealed class ValueCollection : IEnumerable, ICollection, ICollection<TValue>, IEnumerable<TValue>
		{
			[Serializable]
			[Token(Token = "0x2000375")]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
			{
				[Token(Token = "0x40011C0")]
				[FieldOffset(Offset = "0x0")]
				private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				[Token(Token = "0x40011C1")]
				[FieldOffset(Offset = "0x0")]
				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				[Token(Token = "0x40011C2")]
				[FieldOffset(Offset = "0x0")]
				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				[Token(Token = "0x40011C3")]
				[FieldOffset(Offset = "0x0")]
				private TValue RfseuwiVRZUJKPFxDqhpYqNpoDuV;

				[Token(Token = "0x1700070E")]
				public TValue Current
				{
					[Token(Token = "0x6001AC2")]
					get
					{
						return (TValue)null;
					}
				}

				[Token(Token = "0x1700070F")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001AC3")]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001ABF")]
				internal Enumerator(IndexedDictionary<TKey, TValue> P_0)
				{
				}

				[Token(Token = "0x6001AC0")]
				public void Dispose()
				{
				}

				[Token(Token = "0x6001AC1")]
				public bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001AC3")]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001AC4")]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			[Token(Token = "0x40011BF")]
			[FieldOffset(Offset = "0x0")]
			private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			[Token(Token = "0x1700070A")]
			public int Count
			{
				[Token(Token = "0x6001AB4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700070B")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EIsReadOnly
			{
				[Token(Token = "0x6001AB5")]
				get
				{
					return System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002Eget_IsReadOnly();
				}
			}

			[Token(Token = "0x1700070C")]
			private bool System_002ECollections_002EICollection_002EIsSynchronized
			{
				[Token(Token = "0x6001ABD")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_IsSynchronized();
				}
			}

			[Token(Token = "0x1700070D")]
			private object System_002ECollections_002EICollection_002ESyncRoot
			{
				[Token(Token = "0x6001ABE")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_SyncRoot();
				}
			}

			[Token(Token = "0x6001AB2")]
			public ValueCollection(IndexedDictionary<TKey, TValue> P_0)
			{
			}

			[Token(Token = "0x6001AB3")]
			public void CopyTo(TValue[] array, int index)
			{
			}

			[Token(Token = "0x6001AB5")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002Eget_IsReadOnly()
			{
				return default;
			}

			[Token(Token = "0x6001AB6")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EAdd(TValue P_0)
			{
			}

			[Token(Token = "0x6001AB7")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002ERemove(TValue P_0)
			{
				return default;
			}

			[Token(Token = "0x6001AB8")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EClear()
			{
			}

			[Token(Token = "0x6001AB9")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EContains(TValue P_0)
			{
				return default;
			}

			[Token(Token = "0x6001ABA")]
			private IEnumerator<TValue> System_002ECollections_002EGeneric_002EIEnumerable_003CTValue_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001ABB")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001ABC")]
			private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x6001ABD")]
			private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
			{
				return default;
			}

			[Token(Token = "0x6001ABE")]
			private object System_002ECollections_002EICollection_002Eget_SyncRoot()
			{
				return null;
			}
		}

		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool xZKbNABvFicyafZagjtMHeawbvWPb;

		[Token(Token = "0x40011AD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool BPkiiTlArwbipfwUHrbxCyzAuCsy;

		[Token(Token = "0x40011AE")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> toVgbxhYiVFNzBqoRpxaDNzBeHrF;

		[Token(Token = "0x40011AF")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TValue> BWAEIJVQdNILOtNzQeilDQcmiWJBb;

		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x0")]
		private readonly AList<nnXpQNToQOcOXCGmLUrlooHLNULg> jaEouEThGebUjciilFRztgFLhYrT;

		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x0")]
		private readonly ADictionary<TKey, int> TQQbkBaVnxdAiuxUzscJmhHnspdn;

		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x0")]
		private bool kqntpHEZaAOJWNtUuQwFcOEYvlhX;

		[Token(Token = "0x170006EE")]
		public int Count
		{
			[Token(Token = "0x6001A66")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006EF")]
		public bool ContainsDuplicateKeys
		{
			[Token(Token = "0x6001A67")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006F0")]
		public bool AllowDuplicateKeys
		{
			[Token(Token = "0x6001A68")]
			set
			{
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170006F1")]
		[Token(Token = "0x6001A6B")]
		public TValue get_Item(int index)
		{
			return (TValue)null;
		}

		[Token(Token = "0x170006F2")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6001A79")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F3")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6001A7A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F4")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EIsReadOnly
		{
			[Token(Token = "0x6001A7E")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_IsReadOnly();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.Generic.IDictionary<TKey,TValue>.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170006F5")]
		[Token(Token = "0x6001A82")]
		private TValue get_System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EItem(TKey P_0)
		{
			return System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eget_Item(P_0);
		}

		[Token(Token = "0x6001A83")]
		private void set_System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EItem(TKey P_0, TValue P_1)
		{
			System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eset_Item(val, val2);
		}

		[Token(Token = "0x170006F6")]
		private bool System_002ECollections_002EIDictionary_002EIsFixedSize
		{
			[Token(Token = "0x6001A87")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x170006F7")]
		private bool System_002ECollections_002EIDictionary_002EIsReadOnly
		{
			[Token(Token = "0x6001A88")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x170006F8")]
		private ICollection System_002ECollections_002EIDictionary_002EKeys
		{
			[Token(Token = "0x6001A89")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Keys();
			}
		}

		[Token(Token = "0x170006F9")]
		private ICollection System_002ECollections_002EIDictionary_002EValues
		{
			[Token(Token = "0x6001A8B")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Values();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170006FA")]
		[Token(Token = "0x6001A8C")]
		private object get_System_002ECollections_002EIDictionary_002EItem(object key)
		{
			return System_002ECollections_002EIDictionary_002Eget_Item(key);
		}

		[Token(Token = "0x6001A8D")]
		private void set_System_002ECollections_002EIDictionary_002EItem(object key, object value)
		{
			System_002ECollections_002EIDictionary_002Eset_Item(key, value);
		}

		[Token(Token = "0x170006FB")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x6001A8F")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x170006FC")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x6001A90")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x170006FD")]
		private int Rewired_002EUtils_002EInterfaces_002EIReadOnlyList_002ECount
		{
			[Token(Token = "0x6001A91")]
			get
			{
				return ZbmoltwqYLIJasYpTncXzrdEzOvk();
			}
		}

		// C# has no syntax for parameterized property 'Rewired.Utils.Interfaces.IReadOnlyList.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170006FE")]
		[Token(Token = "0x6001A92")]
		private object get_Rewired_002EUtils_002EInterfaces_002EIReadOnlyList_002EItem(int P_0)
		{
			return RdLjeNLTRUydPmyayGNQCcOvEqnt(P_0);
		}

		[Token(Token = "0x6001A69")]
		public IndexedDictionary()
		{
		}

		[Token(Token = "0x6001A6A")]
		public IndexedDictionary(int P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001A6C")]
		public TValue GetValue(TKey key)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6001A6D")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default;
		}

		[Token(Token = "0x6001A6E")]
		public TKey GetKeyAt(int index)
		{
			return (TKey)null;
		}

		[Token(Token = "0x6001A6F")]
		public KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			return default;
		}

		[Token(Token = "0x6001A70")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6001A71")]
		public void SetValue(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6001A72")]
		public bool Remove(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6001A73")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6001A74")]
		public int IndexOfKey(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6001A75")]
		public int IndexOfValue(TValue value)
		{
			return default;
		}

		[Token(Token = "0x6001A76")]
		public bool ContainsKey(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6001A77")]
		public bool ContainsValue(TValue value)
		{
			return default;
		}

		[Token(Token = "0x6001A78")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001A7B")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EAdd(KeyValuePair<TKey, TValue> P_0)
		{
		}

		[Token(Token = "0x6001A7C")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EContains(KeyValuePair<TKey, TValue> P_0)
		{
			return default;
		}

		[Token(Token = "0x6001A7D")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ECopyTo(KeyValuePair<TKey, TValue>[] P_0, int P_1)
		{
		}

		[Token(Token = "0x6001A7E")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6001A7F")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ERemove(KeyValuePair<TKey, TValue> P_0)
		{
			return default;
		}

		[Token(Token = "0x6001A80")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001A81")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001A82")]
		private TValue System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eget_Item(TKey P_0)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6001A83")]
		private void System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eset_Item(TKey P_0, TValue P_1)
		{
		}

		[Token(Token = "0x6001A84")]
		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		[Token(Token = "0x6001A85")]
		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return default;
		}

		[Token(Token = "0x6001A86")]
		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001A87")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsFixedSize()
		{
			return default;
		}

		[Token(Token = "0x6001A88")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6001A89")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x6001A8A")]
		private void System_002ECollections_002EIDictionary_002ERemove(object key)
		{
		}

		[Token(Token = "0x6001A8B")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x6001A8C")]
		private object System_002ECollections_002EIDictionary_002Eget_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x6001A8D")]
		private void System_002ECollections_002EIDictionary_002Eset_Item(object key, object value)
		{
		}

		[Token(Token = "0x6001A8E")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6001A8F")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default;
		}

		[Token(Token = "0x6001A90")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x6001A91")]
		private int ZbmoltwqYLIJasYpTncXzrdEzOvk()
		{
			return default;
		}

		[Token(Token = "0x6001A92")]
		private object RdLjeNLTRUydPmyayGNQCcOvEqnt(int P_0)
		{
			return null;
		}
	}
}
