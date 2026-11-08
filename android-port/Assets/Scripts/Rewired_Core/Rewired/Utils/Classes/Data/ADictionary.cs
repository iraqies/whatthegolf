using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Data
{
	internal class ADictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		internal struct Entry
		{
			public int hashCode;

			public int next;

			public TKey key;

			public TValue value;
		}

		[Serializable]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

			private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

			private KeyValuePair<TKey, TValue> SgJVPHrjFyHgCSEpxtgUijWhNNop;

			private int hVLAXWNvglyqqvtcCiHFclAncMWO;

			public KeyValuePair<TKey, TValue> Current => default;

			object IEnumerator.Current => null;

			DictionaryEntry IDictionaryEnumerator.Entry => default;

			object IDictionaryEnumerator.Key => null;

			object IDictionaryEnumerator.Value => null;

			internal Enumerator(ADictionary<TKey, TValue> P_0, int P_1)
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
				private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				private TKey szsPnNMRosmkGGKYRlfkUtAelqA;

				public TKey Current => default;

				object IEnumerator.Current => null;

				internal Enumerator(ADictionary<TKey, TValue> P_0)
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

			private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			public int Count => 0;

			bool ICollection<TKey>.IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public KeyCollection(ADictionary<TKey, TValue> P_0)
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
				private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

				private int PqXTkiKXdxRLgXpucsKUqWEJhHUQ;

				private int IXQaoUCUZGEGQAwPFohIYgSPNjoiB;

				private TValue RfseuwiVRZUJKPFxDqhpYqNpoDuV;

				public TValue Current => default;

				object IEnumerator.Current => null;

				internal Enumerator(ADictionary<TKey, TValue> P_0)
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

			private ADictionary<TKey, TValue> gtOwGaSStjjjqPkwkkQpbgQQomCn;

			public int Count => 0;

			bool ICollection<TValue>.IsReadOnly => false;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public ValueCollection(ADictionary<TKey, TValue> P_0)
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

		private int[] JRAtgWgLrfDRuSJOiKQULiuRWxCl;

		internal Entry[] _entries;

		internal int _count;

		private int ZMmXJIUpRkkINbjuQpRQDgAgOgdk;

		private int JcBBAHIAaohONoRvXaksQMlIiKSz;

		private int oklhWJbpIyGuhHoQsdtnWmUIGVQx;

		private int gnsEgIUPDZGSRDOouaeyYVNFYxprA;

		private IEqualityComparer<TKey> toVgbxhYiVFNzBqoRpxaDNzBeHrF;

		private IEqualityComparer<TValue> BWAEIJVQdNILOtNzQeilDQcmiWJBb;

		private KeyCollection mRJsAJSfWTOusfaseyppRkuiypFP;

		private ValueCollection VePwhFxSBkhXLQKWMwBJJwSoAsVl;

		private readonly object YmPJVmEIVpGMAdftFocwGnzawvaZb;

		private static readonly bool xZKbNABvFicyafZagjtMHeawbvWPb;

		private static readonly bool BPkiiTlArwbipfwUHrbxCyzAuCsy;

		private const string FEHSYqJUHgdMQREzOqNogNTrQMlb = "Version";

		private const string JtEctPpMbgGoSaONyyZNUGsVexXm = "HashSize";

		private const string NiHfTUhZZPBSvxDirOSSUbNqpkwFb = "KeyValuePairs";

		private const string HlUAtFSnxTEPvqADfXeSFTCTKfnK = "Comparer";

		public int Count => 0;

		public KeyCollection Keys => null;

		public ValueCollection Values => null;

		public TValue this[TKey key]
		{
			get => default;
			set { }
		}

		ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

		ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		ICollection IDictionary.Keys => null;

		ICollection IDictionary.Values => null;

		object IDictionary.this[object key]
		{
			get => null;
			set { }
		}

		public ADictionary()
		{
		}

		public ADictionary(int P_0)
		{
		}

		public ADictionary(int P_0, IEqualityComparer<TKey> P_1)
		{
		}

		public ADictionary(int P_0, IEqualityComparer<TKey> P_1, IEqualityComparer<TValue> P_2)
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void Clear()
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool ContainsValue(TValue value)
		{
			return false;
		}

		public Enumerator GetEnumerator()
		{
			return default;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		public TValue GetValueSafe(TKey key)
		{
			return default;
		}

		public int IndexOfKey(TKey key)
		{
			return 0;
		}

		public int IndexOfValue(TValue value)
		{
			return 0;
		}

		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		private void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(int P_0)
		{
		}

		private void PcDQXUadsLAlVcLLblWJXXzcEHhCA(TKey P_0, TValue P_1, bool P_2)
		{
		}

		private void tDOYzectlTkeiSukMnmpKmfTjmIr()
		{
		}

		private void tDOYzectlTkeiSukMnmpKmfTjmIr(int P_0, bool P_1)
		{
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return null;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> P_0)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> P_0)
		{
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> P_0)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] P_0, int P_1)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
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

		private static bool kiujzptUwmTvUnXAMFvmoCuUpoDe(object P_0)
		{
			return false;
		}

		private static void iGUAMOJZDehgdBroHNKeJJmGumDBA<_0001>(object P_0, string P_1)
		{
		}
	}
}
