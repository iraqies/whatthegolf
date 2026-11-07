using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001F6")]
	public class EncryptionWrapperAES : EncryptionWrapper
	{
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x11FB874", Offset = "0x11FB874", VA = "0x11FB874")]
		public EncryptionWrapperAES()
		{
		}

		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x11FB8AC", Offset = "0x11FB8AC", VA = "0x11FB8AC", Slot = "9")]
		protected override SymmetricAlgorithm CreateAlgorithm()
		{
			return null;
		}
	}
}
