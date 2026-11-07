using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200004B")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x182E6C", Offset = "0x182E6C")]
	[Attribute(Name = "NullableAttribute", RVA = "0x182E6C", Offset = "0x182E6C")]
	internal class DynamicProxy<T>
	{
		[Token(Token = "0x600021A")]
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		public DynamicProxy()
		{
		}
	}
}
