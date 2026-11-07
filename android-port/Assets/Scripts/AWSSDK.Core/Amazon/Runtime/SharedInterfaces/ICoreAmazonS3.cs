using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces
{
	[Token(Token = "0x200010B")]
	public interface ICoreAmazonS3
	{
		[Token(Token = "0x60008E5")]
		string GeneratePreSignedURL(string bucketName, string objectKey, DateTime expiration, IDictionary<string, object> additionalProperties);

		[Token(Token = "0x60008E6")]
		Task<IList<string>> GetAllObjectKeysAsync(string bucketName, string prefix, IDictionary<string, object> additionalProperties);

		[Token(Token = "0x60008E7")]
		Task UploadObjectFromStreamAsync(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60008E8")]
		Task DeleteAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60008E9")]
		Task DeletesAsync(string bucketName, IEnumerable<string> objectKeys, IDictionary<string, object> additionalProperties, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60008EA")]
		Task<Stream> GetObjectStreamAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60008EB")]
		Task UploadObjectFromFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60008EC")]
		Task DownloadToFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x60008ED")]
		Task MakeObjectPublicAsync(string bucketName, string objectKey, bool enable);

		[Token(Token = "0x60008EE")]
		Task EnsureBucketExistsAsync(string bucketName);

		[Token(Token = "0x60008EF")]
		Task<bool> DoesS3BucketExistAsync(string bucketName);
	}
}
