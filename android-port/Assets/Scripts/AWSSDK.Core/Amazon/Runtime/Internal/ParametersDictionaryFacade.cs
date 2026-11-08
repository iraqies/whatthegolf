using System.Collections;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public class ParametersDictionaryFacade : IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		private readonly ParameterCollection _parameterCollection;

		public int Count => 0;

		public string this[string key]
		{
			get => null;
			set { }
		}

		public ICollection<string> Keys => null;

		public ICollection<string> Values => null;

		public bool IsReadOnly => false;

		public ParametersDictionaryFacade(ParameterCollection collection)
		{
		}

		private static string ParameterValueToString(ParameterValue pv)
		{
			return null;
		}

		private static void UpdateParameterValue(ParameterValue pv, string newValue)
		{
		}

		public void Add(string key, string value)
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

		public bool TryGetValue(string key, out string value)
		{
			value = null;
			return false;
		}

		public bool Remove(KeyValuePair<string, string> item)
		{
			return false;
		}

		public void Add(KeyValuePair<string, string> item)
		{
		}

		public bool Contains(KeyValuePair<string, string> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
