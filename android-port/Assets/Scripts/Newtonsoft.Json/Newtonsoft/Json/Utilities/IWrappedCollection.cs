using System.Collections;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200003E")]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		[Token(Token = "0x17000058")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18EAF8", Offset = "0x18EAF8")]
		object UnderlyingCollection
		{
			[Token(Token = "0x60001D5")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x188D28", Offset = "0x188D28")]
			get;
		}
	}
}
