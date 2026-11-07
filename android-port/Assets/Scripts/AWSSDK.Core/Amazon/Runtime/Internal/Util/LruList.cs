namespace Amazon.Runtime.Internal.Util
{
	public class LruList<TKey, TValue>
	{
		public LruListItem<TKey, TValue> Head { get; private set; }

		public LruListItem<TKey, TValue> Tail { get; private set; }

		public void Add(LruListItem<TKey, TValue> item)
		{
		}

		public void Remove(LruListItem<TKey, TValue> item)
		{
		}

		public void Touch(LruListItem<TKey, TValue> item)
		{
		}

		public TKey EvictOldest()
		{
			return default;
		}

		internal void Clear()
		{
		}
	}
}
