using System;
using System.Collections;
using System.Collections.Generic;

namespace Amazon.Util
{
	internal class PaginationEnumerator<U> : IEnumerator<U>, IEnumerator, IDisposable
	{
		private PaginatedResource<U> paginatedResource;

		private int position;

		private static Marker<U> blankSpot;

		private Marker<U> currentSpot;

		private bool started;

		object IEnumerator.Current => null;

		public U Current => default;

		internal PaginationEnumerator(PaginatedResource<U> paginatedResource)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}
}
