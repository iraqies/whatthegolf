using System.IO;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200005D")]
	public interface ICryptoUtil
	{
		[Token(Token = "0x6000359")]
		string HMACSign(string data, string key, SigningAlgorithm algorithmName);

		[Token(Token = "0x600035A")]
		string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName);

		[Token(Token = "0x600035B")]
		byte[] ComputeSHA256Hash(byte[] data);

		[Token(Token = "0x600035C")]
		byte[] ComputeSHA256Hash(Stream steam);

		[Token(Token = "0x600035D")]
		byte[] ComputeMD5Hash(byte[] data);

		[Token(Token = "0x600035E")]
		byte[] ComputeMD5Hash(Stream steam);

		[Token(Token = "0x600035F")]
		byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName);
	}
}
