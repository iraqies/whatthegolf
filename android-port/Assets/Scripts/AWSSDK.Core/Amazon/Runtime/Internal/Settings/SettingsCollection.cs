using System.Collections;
using System.Collections.Generic;
using System.IO;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Settings
{
	public class SettingsCollection : IEnumerable<SettingsCollection.ObjectSettings>, IEnumerable
	{
		public class ObjectSettings
		{
			private string _uniqueKey;

			private Dictionary<string, object> _values;

			public string UniqueKey => null;

			// C# has no syntax for parameterized property 'Item'.
			public string get_Item(string key)
			{
				return null;
			}

			public void set_Item(string key, string value)
			{
			}

			public bool IsEmpty => false;

			public IEnumerable<string> Keys => null;

			internal ObjectSettings(string uniqueKey, Dictionary<string, object> values)
			{
			}

			public string GetValueOrDefault(string key, string defaultValue)
			{
				return null;
			}

			public void Remove(string key)
			{
			}

			public void Clear()
			{
			}

			internal void WriteToJson(JsonWriter writer)
			{
			}
		}

		private Dictionary<string, Dictionary<string, object>> _values;

		public int Count => 0;

		public bool InitializedEmpty { get; private set; }

		// C# has no syntax for parameterized property 'Item'.
		public ObjectSettings get_Item(string key)
		{
			return null;
		}

		public SettingsCollection()
		{
		}

		public SettingsCollection(Dictionary<string, Dictionary<string, object>> values)
		{
		}

		internal void Persist(StreamWriter writer)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<ObjectSettings> GetEnumerator()
		{
			return null;
		}

		public ObjectSettings NewObjectSettings()
		{
			return null;
		}

		public ObjectSettings NewObjectSettings(string uniqueKey)
		{
			return null;
		}

		public void Remove(string uniqueKey)
		{
		}

		public void Clear()
		{
		}
	}
}
