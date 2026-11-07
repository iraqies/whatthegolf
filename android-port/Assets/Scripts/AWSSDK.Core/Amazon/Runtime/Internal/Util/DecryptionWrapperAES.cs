using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001F0")]
	public class DecryptionWrapperAES : DecryptionWrapper
	{
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x11ED640", Offset = "0x11ED640", VA = "0x11ED640")]
		public DecryptionWrapperAES()
		{
		}

		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x11ED678", Offset = "0x11ED678", VA = "0x11ED678", Slot = "7")]
		protected override SymmetricAlgorithm CreateAlgorithm()
		{
			return null;
		}
	}
}
