using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001CB")]
	public class MD5Stream : HashStream<HashingWrapperMD5>
	{
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x58")]
		private Logger _logger;

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x123CE6C", Offset = "0x123CE6C", VA = "0x123CE6C")]
		public MD5Stream(Stream baseStream, byte[] expectedHash, long expectedLength)
		{
		}
	}
}
