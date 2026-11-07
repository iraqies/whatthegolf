using System.Collections;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000049")]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		[Token(Token = "0x1700005B")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18EB0C", Offset = "0x18EB0C")]
		object UnderlyingDictionary
		{
			[Token(Token = "0x6000219")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x188D94", Offset = "0x188D94")]
			get;
		}
	}
}
