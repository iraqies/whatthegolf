using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001FA")]
	public class AESEncryptionPutObjectStream : EncryptStream<EncryptionWrapperAES>
	{
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x11AF5C8", Offset = "0x11AF5C8", VA = "0x11AF5C8")]
		public AESEncryptionPutObjectStream(Stream baseStream, byte[] key, byte[] IV)
		{
		}
	}
}
