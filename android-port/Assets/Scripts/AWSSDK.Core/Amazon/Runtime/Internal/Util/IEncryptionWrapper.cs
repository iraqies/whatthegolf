using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x2000200")]
	public interface IEncryptionWrapper
	{
		[Token(Token = "0x6000FA5")]
		void Reset();

		[Token(Token = "0x6000FA6")]
		int AppendBlock(byte[] buffer, int offset, int count, byte[] target, int targetOffset);

		[Token(Token = "0x6000FA7")]
		byte[] AppendLastBlock(byte[] buffer, int offset, int count);

		[Token(Token = "0x6000FA8")]
		void SetEncryptionData(byte[] key, byte[] IV);

		[Token(Token = "0x6000FA9")]
		void CreateEncryptor();
	}
}
