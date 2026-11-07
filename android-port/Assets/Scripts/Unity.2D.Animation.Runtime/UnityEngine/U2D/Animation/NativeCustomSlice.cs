using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D.Animation
{
	internal struct NativeCustomSlice<T> where T : struct
	{
		[NativeDisableUnsafePtrRestriction]
		public IntPtr data;

		public int length;

		public int stride;

		// C# has no syntax for parameterized property 'Item'.
		public T get_Item(int index)
		{
			return default;
		}

		public NativeCustomSlice(NativeSlice<byte> slice, int length, int stride)
		{
			data = (IntPtr)0;
			this.length = 0;
			this.stride = 0;
		}
	}
}
