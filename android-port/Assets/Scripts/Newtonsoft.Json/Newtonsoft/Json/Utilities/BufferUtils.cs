using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000063")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183218", Offset = "0x183218")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183218", Offset = "0x183218")]
	internal static class BufferUtils
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x22ADD00", Offset = "0x22ADD00", VA = "0x22ADD00")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x189010", Offset = "0x189010")]
		public static char[] RentBuffer([Attribute(Name = "NullableAttribute", RVA = "0x18BF0C", Offset = "0x18BF0C")] IArrayPool<char> bufferPool, int minSize)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x22ADDE8", Offset = "0x22ADDE8", VA = "0x22ADDE8")]
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x22ADEB8", Offset = "0x22ADEB8", VA = "0x22ADEB8")]
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer)
		{
			return null;
		}
	}
}
