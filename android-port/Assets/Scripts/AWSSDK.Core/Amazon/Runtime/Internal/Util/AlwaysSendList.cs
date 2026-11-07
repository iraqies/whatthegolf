using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001BA")]
	internal class AlwaysSendList<T> : List<T>
	{
		[Token(Token = "0x6000DBE")]
		public AlwaysSendList()
		{
		}

		[Token(Token = "0x6000DBF")]
		public AlwaysSendList(IEnumerable<T> collection)
		{
		}
	}
}
