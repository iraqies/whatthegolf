using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public class ParameterCollection : SortedDictionary<string, ParameterValue>
	{
		public void Add(string key, string value)
		{
		}

		public void Add(string key, List<string> values)
		{
		}

		public List<KeyValuePair<string, string>> GetSortedParametersList()
		{
			return null;
		}

		private IEnumerable<KeyValuePair<string, string>> GetParametersEnumerable()
		{
			return null;
		}
	}
}
