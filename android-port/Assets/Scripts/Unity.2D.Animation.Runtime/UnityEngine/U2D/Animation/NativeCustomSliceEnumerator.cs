using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x2000005")]
	internal struct NativeCustomSliceEnumerator<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : struct
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x0")]
		private NativeCustomSlice<T> nativeCustomSlice;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x0")]
		private int index;

		[Token(Token = "0x17000006")]
		public T Current
		{
			[Token(Token = "0x600001D")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600001E")]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000018")]
		internal NativeCustomSliceEnumerator(NativeSlice<byte> slice, int length, int stride)
		{
		}

		[Token(Token = "0x6000019")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		public bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600001C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600001E")]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		private void System_002EIDisposable_002EDispose()
		{
		}
	}
}
