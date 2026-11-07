using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Utils.Classes.Data
{
	[Token(Token = "0x2000368")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x192100", Offset = "0x192100")]
	internal class ADictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		[Token(Token = "0x2000369")]
		internal struct Entry
		{
			[Token(Token = "0x4001199")]
			[FieldOffset(Offset = "0x0")]
			public int hashCode;

			[Token(Token = "0x400119A")]
			[FieldOffset(Offset = "0x0")]
			public int next;

			[Token(Token = "0x400119B")]
			[FieldOffset(Offset = "0x0")]
			public TKey key;

			[Token(Token = "0x400119C")]
			[FieldOffset(Offset = "0x0")]
			public TValue value;
		}

		[Serializable]
		[Token(Token = "0x200036A")]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			[Token(Token = "0x400119D")]
			[FieldOffset(Offset = "0x0")]
			private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			[Token(Token = "0x400119E")]
			[FieldOffset(Offset = "0x0")]
			private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

			[Token(Token = "0x400119F")]
			[FieldOffset(Offset = "0x0")]
			private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

			[Token(Token = "0x40011A0")]
			[FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> SgJVPHrjFyHgCSEpxtgUijWhNNop;

			[Token(Token = "0x40011A1")]
			[FieldOffset(Offset = "0x0")]
			private int hVLAXWNvglyqqvtcCiHFclAncMWO;

			[Token(Token = "0x170006DD")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6001A39")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170006DE")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001A3B")]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x170006DF")]
			private DictionaryEntry System_002ECollections_002EIDictionaryEnumerator_002EEntry
			{
				[Token(Token = "0x6001A3D")]
				get
				{
					return System_002ECollections_002EIDictionaryEnumerator_002Eget_Entry();
				}
			}

			[Token(Token = "0x170006E0")]
			private object System_002ECollections_002EIDictionaryEnumerator_002EKey
			{
				[Token(Token = "0x6001A3E")]
				get
				{
					return System_002ECollections_002EIDictionaryEnumerator_002Eget_Key();
				}
			}

			[Token(Token = "0x170006E1")]
			private object System_002ECollections_002EIDictionaryEnumerator_002EValue
			{
				[Token(Token = "0x6001A3F")]
				get
				{
					return System_002ECollections_002EIDictionaryEnumerator_002Eget_Value();
				}
			}

			[Token(Token = "0x6001A37")]
			internal Enumerator(ADictionary<TKey, TValue> P_0, int P_1)
			{
			}

			[Token(Token = "0x6001A38")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001A3A")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001A3B")]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001A3C")]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001A3D")]
			private DictionaryEntry System_002ECollections_002EIDictionaryEnumerator_002Eget_Entry()
			{
				return default;
			}

			[Token(Token = "0x6001A3E")]
			private object System_002ECollections_002EIDictionaryEnumerator_002Eget_Key()
			{
				return null;
			}

			[Token(Token = "0x6001A3F")]
			private object System_002ECollections_002EIDictionaryEnumerator_002Eget_Value()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200036B")]
		public sealed class KeyCollection : IEnumerable, IEnumerable<TKey>, ICollection, ICollection<TKey>
		{
			[Serializable]
			[Token(Token = "0x200036C")]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
			{
				[Token(Token = "0x40011A3")]
				[FieldOffset(Offset = "0x0")]
				private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				[Token(Token = "0x40011A4")]
				[FieldOffset(Offset = "0x0")]
				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				[Token(Token = "0x40011A5")]
				[FieldOffset(Offset = "0x0")]
				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				[Token(Token = "0x40011A6")]
				[FieldOffset(Offset = "0x0")]
				private TKey szsPnNMRosmkGGKYRlfkUtAelqA;

				[Token(Token = "0x170006E6")]
				public TKey Current
				{
					[Token(Token = "0x6001A50")]
					get
					{
						return (TKey)null;
					}
				}

				[Token(Token = "0x170006E7")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001A51")]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001A4D")]
				internal Enumerator(ADictionary<TKey, TValue> P_0)
				{
				}

				[Token(Token = "0x6001A4E")]
				public void Dispose()
				{
				}

				[Token(Token = "0x6001A4F")]
				public bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001A51")]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001A52")]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			[Token(Token = "0x40011A2")]
			[FieldOffset(Offset = "0x0")]
			private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			[Token(Token = "0x170006E2")]
			public int Count
			{
				[Token(Token = "0x6001A42")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170006E3")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EIsReadOnly
			{
				[Token(Token = "0x6001A43")]
				get
				{
					return System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002Eget_IsReadOnly();
				}
			}

			[Token(Token = "0x170006E4")]
			private bool System_002ECollections_002EICollection_002EIsSynchronized
			{
				[Token(Token = "0x6001A4B")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_IsSynchronized();
				}
			}

			[Token(Token = "0x170006E5")]
			private object System_002ECollections_002EICollection_002ESyncRoot
			{
				[Token(Token = "0x6001A4C")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_SyncRoot();
				}
			}

			[Token(Token = "0x6001A40")]
			public KeyCollection(ADictionary<TKey, TValue> P_0)
			{
			}

			[Token(Token = "0x6001A41")]
			public void CopyTo(TKey[] array, int index)
			{
			}

			[Token(Token = "0x6001A43")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002Eget_IsReadOnly()
			{
				return default;
			}

			[Token(Token = "0x6001A44")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EAdd(TKey P_0)
			{
			}

			[Token(Token = "0x6001A45")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EClear()
			{
			}

			[Token(Token = "0x6001A46")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002EContains(TKey P_0)
			{
				return default;
			}

			[Token(Token = "0x6001A47")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTKey_003E_002ERemove(TKey P_0)
			{
				return default;
			}

			[Token(Token = "0x6001A48")]
			private IEnumerator<TKey> System_002ECollections_002EGeneric_002EIEnumerable_003CTKey_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001A49")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001A4A")]
			private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x6001A4B")]
			private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
			{
				return default;
			}

			[Token(Token = "0x6001A4C")]
			private object System_002ECollections_002EICollection_002Eget_SyncRoot()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200036D")]
		public sealed class ValueCollection : IEnumerable, ICollection, ICollection<TValue>, IEnumerable<TValue>
		{
			[Serializable]
			[Token(Token = "0x200036E")]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
			{
				[Token(Token = "0x40011A8")]
				[FieldOffset(Offset = "0x0")]
				private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				[Token(Token = "0x40011A9")]
				[FieldOffset(Offset = "0x0")]
				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				[Token(Token = "0x40011AA")]
				[FieldOffset(Offset = "0x0")]
				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				[Token(Token = "0x40011AB")]
				[FieldOffset(Offset = "0x0")]
				private TValue RfseuwiVRZUJKPFxDqhpYqNpoDuV;

				[Token(Token = "0x170006EC")]
				public TValue Current
				{
					[Token(Token = "0x6001A63")]
					get
					{
						return (TValue)null;
					}
				}

				[Token(Token = "0x170006ED")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x6001A64")]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6001A60")]
				internal Enumerator(ADictionary<TKey, TValue> P_0)
				{
				}

				[Token(Token = "0x6001A61")]
				public void Dispose()
				{
				}

				[Token(Token = "0x6001A62")]
				public bool MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6001A64")]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}

				[Token(Token = "0x6001A65")]
				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			[Token(Token = "0x40011A7")]
			[FieldOffset(Offset = "0x0")]
			private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			[Token(Token = "0x170006E8")]
			public int Count
			{
				[Token(Token = "0x6001A55")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170006E9")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EIsReadOnly
			{
				[Token(Token = "0x6001A56")]
				get
				{
					return System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002Eget_IsReadOnly();
				}
			}

			[Token(Token = "0x170006EA")]
			private bool System_002ECollections_002EICollection_002EIsSynchronized
			{
				[Token(Token = "0x6001A5E")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_IsSynchronized();
				}
			}

			[Token(Token = "0x170006EB")]
			private object System_002ECollections_002EICollection_002ESyncRoot
			{
				[Token(Token = "0x6001A5F")]
				get
				{
					return System_002ECollections_002EICollection_002Eget_SyncRoot();
				}
			}

			[Token(Token = "0x6001A53")]
			public ValueCollection(ADictionary<TKey, TValue> P_0)
			{
			}

			[Token(Token = "0x6001A54")]
			public void CopyTo(TValue[] array, int index)
			{
			}

			[Token(Token = "0x6001A56")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002Eget_IsReadOnly()
			{
				return default;
			}

			[Token(Token = "0x6001A57")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EAdd(TValue P_0)
			{
			}

			[Token(Token = "0x6001A58")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002ERemove(TValue P_0)
			{
				return default;
			}

			[Token(Token = "0x6001A59")]
			private void System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EClear()
			{
			}

			[Token(Token = "0x6001A5A")]
			private bool System_002ECollections_002EGeneric_002EICollection_003CTValue_003E_002EContains(TValue P_0)
			{
				return default;
			}

			[Token(Token = "0x6001A5B")]
			private IEnumerator<TValue> System_002ECollections_002EGeneric_002EIEnumerable_003CTValue_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001A5C")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6001A5D")]
			private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x6001A5E")]
			private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
			{
				return default;
			}

			[Token(Token = "0x6001A5F")]
			private object System_002ECollections_002EICollection_002Eget_SyncRoot()
			{
				return null;
			}
		}

		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x0")]
		private int[] JRAtgWgLrfDRuSJOiKQULiuRWxCl;

		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x0")]
		internal Entry[] _entries;

		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x0")]
		internal int _count;

		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x0")]
		private int ZMmXJIUpRkkINbjuQpRQDgAgOgdk;

		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x0")]
		private int JcBBAHIAaohONoRvXaksQMlIiKSz;

		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x0")]
		private int oklhWJbpIyGuhHoQsdtnWmUIGVQx;

		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x0")]
		private int gnsEgIUPDZGSRDOouaeyYVNFYxprA;

		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> toVgbxhYiVFNzBqoRpxaDNzBeHrF;

		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TValue> BWAEIJVQdNILOtNzQeilDQcmiWJBb;

		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x0")]
		private KeyCollection mRJsAJSfWTOusfaseyppRkuiypFP;

		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x0")]
		private ValueCollection VePwhFxSBkhXLQKWMwBJJwSoAsVl;

		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x0")]
		private readonly object YmPJVmEIVpGMAdftFocwGnzawvaZb;

		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool xZKbNABvFicyafZagjtMHeawbvWPb;

		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool BPkiiTlArwbipfwUHrbxCyzAuCsy;

		[Token(Token = "0x4001195")]
		private const string FEHSYqJUHgdMQREzOqNogNTrQMlb = "Version";

		[Token(Token = "0x4001196")]
		private const string JtEctPpMbgGoSaONyyZNUGsVexXm = "HashSize";

		[Token(Token = "0x4001197")]
		private const string NiHfTUhZZPBSvxDirOSSUbNqpkwFb = "KeyValuePairs";

		[Token(Token = "0x4001198")]
		private const string HlUAtFSnxTEPvqADfXeSFTCTKfnK = "Comparer";

		[Token(Token = "0x170006CF")]
		public int Count
		{
			[Token(Token = "0x6001A06")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006D0")]
		public KeyCollection Keys
		{
			[Token(Token = "0x6001A07")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D1")]
		public ValueCollection Values
		{
			[Token(Token = "0x6001A08")]
			get
			{
				return null;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170006D2")]
		[Token(Token = "0x6001A09")]
		public TValue get_Item(TKey key)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6001A0A")]
		public void set_Item(TKey key, TValue value)
		{
		}

		[Token(Token = "0x170006D3")]
		private ICollection<TKey> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EKeys
		{
			[Token(Token = "0x6001A1E")]
			get
			{
				return System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eget_Keys();
			}
		}

		[Token(Token = "0x170006D4")]
		private ICollection<TValue> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EValues
		{
			[Token(Token = "0x6001A1F")]
			get
			{
				return System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eget_Values();
			}
		}

		[Token(Token = "0x170006D5")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EIsReadOnly
		{
			[Token(Token = "0x6001A24")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x170006D6")]
		private bool System_002ECollections_002EICollection_002EIsSynchronized
		{
			[Token(Token = "0x6001A28")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x170006D7")]
		private object System_002ECollections_002EICollection_002ESyncRoot
		{
			[Token(Token = "0x6001A29")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x170006D8")]
		private bool System_002ECollections_002EIDictionary_002EIsFixedSize
		{
			[Token(Token = "0x6001A2A")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x170006D9")]
		private bool System_002ECollections_002EIDictionary_002EIsReadOnly
		{
			[Token(Token = "0x6001A2B")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x170006DA")]
		private ICollection System_002ECollections_002EIDictionary_002EKeys
		{
			[Token(Token = "0x6001A2C")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Keys();
			}
		}

		[Token(Token = "0x170006DB")]
		private ICollection System_002ECollections_002EIDictionary_002EValues
		{
			[Token(Token = "0x6001A2D")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Values();
			}
		}

		// C# has no syntax for parameterized property 'System.Collections.IDictionary.Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170006DC")]
		[Token(Token = "0x6001A2E")]
		private object get_System_002ECollections_002EIDictionary_002EItem(object key)
		{
			return System_002ECollections_002EIDictionary_002Eget_Item(key);
		}

		[Token(Token = "0x6001A2F")]
		private void set_System_002ECollections_002EIDictionary_002EItem(object key, object value)
		{
			System_002ECollections_002EIDictionary_002Eset_Item(key, value);
		}

		[Token(Token = "0x6001A0B")]
		public ADictionary()
		{
		}

		[Token(Token = "0x6001A0C")]
		public ADictionary(int P_0)
		{
		}

		[Token(Token = "0x6001A0D")]
		public ADictionary(int P_0, IEqualityComparer<TKey> P_1)
		{
		}

		[Token(Token = "0x6001A0E")]
		public ADictionary(int P_0, IEqualityComparer<TKey> P_1, IEqualityComparer<TValue> P_2)
		{
		}

		[Token(Token = "0x6001A0F")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6001A10")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001A11")]
		public bool ContainsKey(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6001A12")]
		public bool ContainsValue(TValue value)
		{
			return default;
		}

		[Token(Token = "0x6001A13")]
		public Enumerator GetEnumerator()
		{
			return default;
		}

		[Token(Token = "0x6001A14")]
		public bool Remove(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6001A15")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default;
		}

		[Token(Token = "0x6001A16")]
		public TValue GetValueSafe(TKey key)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6001A17")]
		public int IndexOfKey(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6001A18")]
		public int IndexOfValue(TValue value)
		{
			return default;
		}

		[Token(Token = "0x6001A19")]
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		[Token(Token = "0x6001A1A")]
		private void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(int P_0)
		{
		}

		[Token(Token = "0x6001A1B")]
		private void PcDQXUadsLAlVcLLblWJXXzcEHhCA(TKey P_0, TValue P_1, bool P_2)
		{
		}

		[Token(Token = "0x6001A1C")]
		private void tDOYzectlTkeiSukMnmpKmfTjmIr()
		{
		}

		[Token(Token = "0x6001A1D")]
		private void tDOYzectlTkeiSukMnmpKmfTjmIr(int P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001A1E")]
		private ICollection<TKey> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x6001A1F")]
		private ICollection<TValue> System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x6001A20")]
		private IEnumerator<KeyValuePair<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001A21")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EAdd(KeyValuePair<TKey, TValue> P_0)
		{
		}

		[Token(Token = "0x6001A22")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EContains(KeyValuePair<TKey, TValue> P_0)
		{
			return default;
		}

		[Token(Token = "0x6001A23")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ERemove(KeyValuePair<TKey, TValue> P_0)
		{
			return default;
		}

		[Token(Token = "0x6001A24")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6001A25")]
		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ECopyTo(KeyValuePair<TKey, TValue>[] P_0, int P_1)
		{
		}

		[Token(Token = "0x6001A26")]
		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6001A27")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001A28")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default;
		}

		[Token(Token = "0x6001A29")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x6001A2A")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsFixedSize()
		{
			return default;
		}

		[Token(Token = "0x6001A2B")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6001A2C")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x6001A2D")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x6001A2E")]
		private object System_002ECollections_002EIDictionary_002Eget_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x6001A2F")]
		private void System_002ECollections_002EIDictionary_002Eset_Item(object key, object value)
		{
		}

		[Token(Token = "0x6001A30")]
		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		[Token(Token = "0x6001A31")]
		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return default;
		}

		[Token(Token = "0x6001A32")]
		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6001A33")]
		private void System_002ECollections_002EIDictionary_002ERemove(object key)
		{
		}

		[Token(Token = "0x6001A34")]
		private static bool kiujzptUwmTvUnXAMFvmoCuUpoDe(object P_0)
		{
			return default;
		}

		[Token(Token = "0x6001A35")]
		private static void iGUAMOJZDehgdBroHNKeJJmGumDBA<_0001>(object P_0, string P_1)
		{
		}
	}
}
