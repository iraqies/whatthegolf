using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amazon.Runtime.SharedInterfaces
{
	public interface ICoreAmazonKMS : IDisposable
	{
		GenerateDataKeyResult GenerateDataKey(string keyID, Dictionary<string, string> encryptionContext, string keySpec);

		byte[] Decrypt(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext);

		Task<GenerateDataKeyResult> GenerateDataKeyAsync(string keyID, Dictionary<string, string> encryptionContext, string keySpec);

		Task<byte[]> DecryptAsync(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext);
	}
}
