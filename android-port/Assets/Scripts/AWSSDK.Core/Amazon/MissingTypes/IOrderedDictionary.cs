using System.Collections;

namespace Amazon.MissingTypes
{
	public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable
	{
		// C# has no syntax for parameterized property 'Item'.
		object get_Item(int index);

		void set_Item(int index, object value);

		new IDictionaryEnumerator GetEnumerator();

		void Insert(int index, object key, object value);

		void RemoveAt(int index);
	}
}
