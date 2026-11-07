using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D.Animation
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B07E8", Offset = "0x1B07E8")]
	internal struct NativeCustomSlice<T> where T : struct
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public IntPtr data;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public int stride;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000005")]
		[Token(Token = "0x6000017")]
		public T get_Item(int index)
		{
			return (T)null;
		}

		[Token(Token = "0x6000016")]
		public NativeCustomSlice(NativeSlice<byte> slice, int length, int stride)
		{
		}
	}
}
