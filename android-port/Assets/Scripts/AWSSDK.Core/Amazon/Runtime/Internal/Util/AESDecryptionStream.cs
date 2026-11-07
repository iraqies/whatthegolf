using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001F4")]
	public class AESDecryptionStream : DecryptStream<DecryptionWrapperAES>
	{
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x11AF550", Offset = "0x11AF550", VA = "0x11AF550")]
		public AESDecryptionStream(Stream baseStream, byte[] key, byte[] IV)
		{
		}
	}
}
