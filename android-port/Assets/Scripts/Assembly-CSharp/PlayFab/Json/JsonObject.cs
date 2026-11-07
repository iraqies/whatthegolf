using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlayFab.Json
{
	[EditorBrowsable]
	public class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private readonly Dictionary<string, object> _members;

		public ICollection<string> Keys => null;

		public ICollection<object> Values => null;

		public object this[string key]
		{
			get => _members != null && _members.TryGetValue(key, out var v) ? v : null;
			set { if (_members != null) _members[key] = value; }
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public void Add(string key, object value)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out object value)
		{
			value = null;
			return false;
		}

		public void Add(KeyValuePair<string, object> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(KeyValuePair<string, object> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<string, object> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
