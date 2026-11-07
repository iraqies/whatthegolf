using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200005E")]
	internal class PaginatedResource<U> : IEnumerable<U>, IEnumerable
	{
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x0")]
		internal Func<string, Marker<U>> fetcher;

		[Token(Token = "0x6000360")]
		internal PaginatedResource(Func<string, Marker<U>> fetcher)
		{
		}

		[Token(Token = "0x6000361")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		public IEnumerator<U> GetEnumerator()
		{
			return null;
		}
	}
}
