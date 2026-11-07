using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.U2D.Animation
{
	internal struct NativeCustomSliceEnumerator<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : struct
	{
		private NativeCustomSlice<T> nativeCustomSlice;

		private int index;

		public T Current => default;

		object IEnumerator.Current => null;

		internal NativeCustomSliceEnumerator(NativeSlice<byte> slice, int length, int stride)
		{
			nativeCustomSlice = default;
			index = 0;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
