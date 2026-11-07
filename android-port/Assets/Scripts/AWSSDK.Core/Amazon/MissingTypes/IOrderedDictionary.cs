using System.Collections;
using Il2CppDummyDll;

namespace Amazon.MissingTypes
{
	[Token(Token = "0x2000258")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x26070", Offset = "0x26070")]
	public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable
	{
		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000461")]
		[Token(Token = "0x60011B4")]
		object get_Item(int index);

		[Token(Token = "0x60011B5")]
		void set_Item(int index, object value);

		[Token(Token = "0x60011B6")]
		new IDictionaryEnumerator GetEnumerator();

		[Token(Token = "0x60011B7")]
		void Insert(int index, object key, object value);

		[Token(Token = "0x60011B8")]
		void RemoveAt(int index);
	}
}
