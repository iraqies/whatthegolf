using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x200024A")]
	public class AWS3Signer : AbstractAWSSigner
	{
		[Token(Token = "0x4000852")]
		private const string HTTP_SCHEME = "AWS3";

		[Token(Token = "0x4000853")]
		private const string HTTPS_SCHEME = "AWS3-HTTPS";

		[Token(Token = "0x4000854")]
		private const string Slash = "/";

		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27CC8", Offset = "0x27CC8")]
		private bool UseAws3Https__BackingField;

		[Token(Token = "0x1700044F")]
		private bool UseAws3Https
		{
			[Token(Token = "0x600114C")]
			[Address(RVA = "0x11AF70C", Offset = "0x11AF70C", VA = "0x11AF70C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFD0", Offset = "0x2BFD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600114D")]
			[Address(RVA = "0x11AF714", Offset = "0x11AF714", VA = "0x11AF714")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFE0", Offset = "0x2BFE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000450")]
		public override ClientProtocol Protocol
		{
			[Token(Token = "0x6001150")]
			[Address(RVA = "0x11AF74C", Offset = "0x11AF74C", VA = "0x11AF74C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600114E")]
		[Address(RVA = "0x11AF6E0", Offset = "0x11AF6E0", VA = "0x11AF6E0")]
		public AWS3Signer(bool useAws3Https)
		{
		}

		[Token(Token = "0x600114F")]
		[Address(RVA = "0x11AF724", Offset = "0x11AF724", VA = "0x11AF724")]
		public AWS3Signer()
		{
		}

		[Token(Token = "0x6001151")]
		[Address(RVA = "0x11AF754", Offset = "0x11AF754", VA = "0x11AF754", Slot = "4")]
		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6001152")]
		[Address(RVA = "0x11AF8C8", Offset = "0x11AF8C8", VA = "0x11AF8C8")]
		private static void SignHttps(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6001153")]
		[Address(RVA = "0x11AFFF4", Offset = "0x11AFFF4", VA = "0x11AFFF4")]
		private static void SignHttp(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6001154")]
		[Address(RVA = "0x11B11F4", Offset = "0x11B11F4", VA = "0x11B11F4")]
		private static string GetCanonicalizedResourcePath(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x6001155")]
		[Address(RVA = "0x11B107C", Offset = "0x11B107C", VA = "0x11B107C")]
		private static bool IsHttpsRequest(IRequest request)
		{
			return default;
		}

		[Token(Token = "0x6001156")]
		[Address(RVA = "0x11B16B8", Offset = "0x11B16B8", VA = "0x11B16B8")]
		private static string GetCanonicalizedQueryString(IDictionary<string, string> parameters)
		{
			return null;
		}

		[Token(Token = "0x6001157")]
		[Address(RVA = "0x11B234C", Offset = "0x11B234C", VA = "0x11B234C")]
		private static string GetRequestPayload(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x6001158")]
		[Address(RVA = "0x11B2790", Offset = "0x11B2790", VA = "0x11B2790")]
		private static string GetSignedHeadersComponent(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x6001159")]
		[Address(RVA = "0x11B2B18", Offset = "0x11B2B18", VA = "0x11B2B18")]
		private static List<string> GetHeadersForStringToSign(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x600115A")]
		[Address(RVA = "0x11B1C68", Offset = "0x11B1C68", VA = "0x11B1C68")]
		private static string GetCanonicalizedHeadersForStringToSign(IRequest request)
		{
			return null;
		}
	}
}
