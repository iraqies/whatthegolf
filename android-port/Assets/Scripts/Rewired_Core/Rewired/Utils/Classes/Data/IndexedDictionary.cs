using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	internal class IndexedDictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IReadOnlyList
	{
		private struct nnXpQNToQOcOXCGmLUrlooHLNULg
		{
			public TKey qwkeeArhjFVfINdRhYgfKXVRHPQW;

			public TValue yYOUbwIbBcyPAQvjeAEXVsjzLAln;

			public nnXpQNToQOcOXCGmLUrlooHLNULg(TKey P_0, TValue P_1)
			{
				qwkeeArhjFVfINdRhYgfKXVRHPQW = default;
				yYOUbwIbBcyPAQvjeAEXVsjzLAln = default;
			}

			public KeyValuePair<TKey, TValue> uXAyDTEMHJilashiZEIjGfZgTJyo()
			{
				return default;
			}
		}

		[Serializable]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

			private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

			private KeyValuePair<TKey, TValue> SgJVPHrjFyHgCSEpxtgUijWhNNop;

			private int hVLAXWNvglyqqvtcCiHFclAncMWO;

			public KeyValuePair<TKey, TValue> Current => default;

			object IEnumerator.Current => null;

			DictionaryEntry IDictionaryEnumerator.Entry => default;

			object IDictionaryEnumerator.Key => null;

			object IDictionaryEnumerator.Value => null;

			internal Enumerator(IndexedDictionary<TKey, TValue> P_0, int P_1)
			{
				gtOwGaSStjjjqPkwkkQpbgQQomCn = null;
				IXQaoUCUZGEGQAwPFohIYgSPNjoiB = 0;
				PqXTkiKXdxRLgXpucsKUqWEJhHUQ = 0;
				SgJVPHrjFyHgCSEpxtgUijWhNNop = default;
				hVLAXWNvglyqqvtcCiHFclAncMWO = 0;
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
			}
		}

		[Serializable]
		public sealed class KeyCollection : IEnumerable, IEnumerable<TKey>, ICollection, ICollection<TKey>
		{
			[Serializable]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
			{
				private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				private TKey szsPnNMRosmkGGKYRlfkUtAelqA;

				public TKey Current => default;

				object IEnumerator.Current => null;

				internal Enumerator(IndexedDictionary<TKey, TValue> P_0)
				{
					gtOwGaSStjjjqPkwkkQpbgQQomCn = null;
					PqXTkiKXdxRLgXpucsKUqWEJhHUQ = 0;
					IXQaoUCUZGEGQAwPFohIYgSPNjoiB = 0;
					szsPnNMRosmkGGKYRlfkUtAelqA = default;
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				void IEnumerator.Reset()
				{
				}
			}

			private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			public int Count => 0;

			bool ICollection<TKey>.IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public KeyCollection(IndexedDictionary<TKey, TValue> P_0)
			{
			}

			public void CopyTo(TKey[] array, int index)
			{
			}

			void ICollection<TKey>.Add(TKey P_0)
			{
			}

			void ICollection<TKey>.Clear()
			{
			}

			bool ICollection<TKey>.Contains(TKey P_0)
			{
				return false;
			}

			bool ICollection<TKey>.Remove(TKey P_0)
			{
				return false;
			}

			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}
		}

		[Serializable]
		public sealed class ValueCollection : IEnumerable, ICollection, ICollection<TValue>, IEnumerable<TValue>
		{
			[Serializable]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
			{
				private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				private TValue RfseuwiVRZUJKPFxDqhpYqNpoDuV;

				public TValue Current => default;

				object IEnumerator.Current => null;

				internal Enumerator(IndexedDictionary<TKey, TValue> P_0)
				{
					gtOwGaSStjjjqPkwkkQpbgQQomCn = null;
					PqXTkiKXdxRLgXpucsKUqWEJhHUQ = 0;
					IXQaoUCUZGEGQAwPFohIYgSPNjoiB = 0;
					RfseuwiVRZUJKPFxDqhpYqNpoDuV = default;
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				void IEnumerator.Reset()
				{
				}
			}

			private IndexedDictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			public int Count => 0;

			bool ICollection<TValue>.IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public ValueCollection(IndexedDictionary<TKey, TValue> P_0)
			{
			}

			public void CopyTo(TValue[] array, int index)
			{
			}

			void ICollection<TValue>.Add(TValue P_0)
			{
			}

			bool ICollection<TValue>.Remove(TValue P_0)
			{
				return false;
			}

			void ICollection<TValue>.Clear()
			{
			}

			bool ICollection<TValue>.Contains(TValue P_0)
			{
				return false;
			}

			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}
		}

		private static readonly bool xZKbNABvFicyafZagjtMHeawbvWPb;

		private static readonly bool BPkiiTlArwbipfwUHrbxCyzAuCsy;

		private IEqualityComparer<TKey> toVgbxhYiVFNzBqoRpxaDNzBeHrF;

		private IEqualityComparer<TValue> BWAEIJVQdNILOtNzQeilDQcmiWJBb;

		private readonly AList<nnXpQNToQOcOXCGmLUrlooHLNULg> jaEouEThGebUjciilFRztgFLhYrT;

		private readonly ADictionary<TKey, int> TQQbkBaVnxdAiuxUzscJmhHnspdn;

		private bool kqntpHEZaAOJWNtUuQwFcOEYvlhX;

		public int Count => 0;

		public bool ContainsDuplicateKeys => false;

		public bool AllowDuplicateKeys
		{
			set
			{
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		public TValue get_Item(int index)
		{
			return default;
		}

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		TValue IDictionary<TKey, TValue>.this[TKey P_0]
		{
			get => default;
			set { }
		}

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		ICollection IDictionary.Keys => null;

		ICollection IDictionary.Values => null;

		object IDictionary.this[object key]
		{
			get => null;
			set { }
		}

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		int IReadOnlyList.Count => ZbmoltwqYLIJasYpTncXzrdEzOvk();

		// C# has no syntax for parameterized property 'Rewired.Utils.Interfaces.IReadOnlyList.Item'.
		object IReadOnlyList.get_Item(int P_0)
		{
			return RdLjeNLTRUydPmyayGNQCcOvEqnt(P_0);
		}

		public IndexedDictionary()
		{
		}

		public IndexedDictionary(int P_0, bool P_1)
		{
		}

		public TValue GetValue(TKey key)
		{
			return default;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		public TKey GetKeyAt(int index)
		{
			return default;
		}

		public KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			return default;
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void SetValue(TKey key, TValue value)
		{
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		public int IndexOfKey(TKey key)
		{
			return 0;
		}

		public int IndexOfValue(TValue value)
		{
			return 0;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool ContainsValue(TValue value)
		{
			return false;
		}

		public void Clear()
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> P_0)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> P_0)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] P_0, int P_1)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> P_0)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return false;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		private int ZbmoltwqYLIJasYpTncXzrdEzOvk()
		{
			return 0;
		}

		private object RdLjeNLTRUydPmyayGNQCcOvEqnt(int P_0)
		{
			return null;
		}
	}
}
