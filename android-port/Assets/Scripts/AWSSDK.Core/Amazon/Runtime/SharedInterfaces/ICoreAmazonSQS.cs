using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces
{
	[Token(Token = "0x200010C")]
	public interface ICoreAmazonSQS
	{
		[Token(Token = "0x60008F0")]
		Task<Dictionary<string, string>> GetAttributesAsync(string queueUrl);

		[Token(Token = "0x60008F1")]
		Task SetAttributesAsync(string queueUrl, Dictionary<string, string> attributes);
	}
}
