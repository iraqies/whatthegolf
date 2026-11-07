using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000B2")]
	public class ECSTaskCredentials : URIBasedRefreshingCredentialHelper
	{
		[Token(Token = "0x400030C")]
		public const string ContainerCredentialsURIEnvVariable = "AWS_CONTAINER_CREDENTIALS_RELATIVE_URI";

		[Token(Token = "0x400030D")]
		public const string EndpointAddress = "http://169.254.170.2";

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x38")]
		private string Uri;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x40")]
		private string Server;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x0")]
		private static int MaxRetries;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x48")]
		private IWebProxy Proxy;

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x11F885C", Offset = "0x11F885C", VA = "0x11F885C")]
		public ECSTaskCredentials()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x11F8864", Offset = "0x11F8864", VA = "0x11F8864")]
		public ECSTaskCredentials(IWebProxy proxy)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x11F8920", Offset = "0x11F8920", VA = "0x11F8920", Slot = "8")]
		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}
	}
}
