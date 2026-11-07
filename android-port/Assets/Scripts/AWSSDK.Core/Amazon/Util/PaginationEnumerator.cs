using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000060")]
	internal class PaginationEnumerator<U> : IEnumerator<U>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x0")]
		private PaginatedResource<U> paginatedResource;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x0")]
		private int position;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x0")]
		private static Marker<U> blankSpot;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x0")]
		private Marker<U> currentSpot;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x0")]
		private bool started;

		[Token(Token = "0x170000B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000369")]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x170000B1")]
		public U Current
		{
			[Token(Token = "0x600036A")]
			get
			{
				return (U)null;
			}
		}

		[Token(Token = "0x6000366")]
		internal PaginationEnumerator(PaginatedResource<U> paginatedResource)
		{
		}

		[Token(Token = "0x6000367")]
		public bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000368")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000369")]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		public void Dispose()
		{
		}
	}
}
