using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001FE")]
	public class AESEncryptionUploadPartStream : EncryptUploadPartStream<EncryptionWrapperAES>
	{
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x11AF640", Offset = "0x11AF640", VA = "0x11AF640")]
		public AESEncryptionUploadPartStream(Stream baseStream, byte[] key, byte[] IV)
		{
		}
	}
}
