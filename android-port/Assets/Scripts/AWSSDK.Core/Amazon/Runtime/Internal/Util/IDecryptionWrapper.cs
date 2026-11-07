using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001FF")]
	public interface IDecryptionWrapper
	{
		[Token(Token = "0x170003F6")]
		ICryptoTransform Transformer
		{
			[Token(Token = "0x6000FA2")]
			get;
		}

		[Token(Token = "0x6000FA3")]
		void SetDecryptionData(byte[] key, byte[] IV);

		[Token(Token = "0x6000FA4")]
		void CreateDecryptor();
	}
}
