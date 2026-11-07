using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces
{
	[Token(Token = "0x2000109")]
	public interface ICoreAmazonKMS : IDisposable
	{
		[Token(Token = "0x60008DC")]
		GenerateDataKeyResult GenerateDataKey(string keyID, Dictionary<string, string> encryptionContext, string keySpec);

		[Token(Token = "0x60008DD")]
		byte[] Decrypt(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext);

		[Token(Token = "0x60008DE")]
		Task<GenerateDataKeyResult> GenerateDataKeyAsync(string keyID, Dictionary<string, string> encryptionContext, string keySpec);

		[Token(Token = "0x60008DF")]
		Task<byte[]> DecryptAsync(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext);
	}
}
