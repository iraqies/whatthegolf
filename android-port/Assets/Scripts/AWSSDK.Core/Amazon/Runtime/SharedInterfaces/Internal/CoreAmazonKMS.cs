using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amazon.Runtime.SharedInterfaces.Internal
{
	public class CoreAmazonKMS : ICoreAmazonKMS, IDisposable
	{
		private object wrappedClientLock;

		private ICoreAmazonKMS wrappedClient;

		private AmazonServiceClient existingClient;

		private string feature;

		private bool disposed;

		public CoreAmazonKMS(AmazonServiceClient existingClient, string feature)
		{
		}

		public byte[] Decrypt(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext)
		{
			return null;
		}

		public GenerateDataKeyResult GenerateDataKey(string keyID, Dictionary<string, string> encryptionContext, string keySpec)
		{
			return null;
		}

		public Task<byte[]> DecryptAsync(byte[] ciphertextBlob, Dictionary<string, string> encryptionContext)
		{
			return null;
		}

		public Task<GenerateDataKeyResult> GenerateDataKeyAsync(string keyID, Dictionary<string, string> encryptionContext, string keySpec)
		{
			return null;
		}

		private void EnsureWrappedClientIsInstantiated()
		{
		}

		private static ICoreAmazonKMS CreateFromExistingClient(AmazonServiceClient existingClient, string feature)
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
