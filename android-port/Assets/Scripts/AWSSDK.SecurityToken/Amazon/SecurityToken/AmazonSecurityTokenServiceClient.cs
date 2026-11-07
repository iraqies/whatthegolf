using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x2000002")]
	public class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService, IDisposable, ICoreAmazonSTS, ICoreAmazonSTS_SAML, IAmazonService, ICoreAmazonSTS_WebIdentity
	{
		[Serializable]
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30A10", Offset = "0x30A10")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, PolicyDescriptorType> _003C_003E9__1_0;

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x12E69B4", Offset = "0x12E69B4", VA = "0x12E69B4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x12E69BC", Offset = "0x12E69BC", VA = "0x12E69BC")]
			internal PolicyDescriptorType _003CSetupAssumeRoleWithWebIdentityRequest_003Eb__1_0(string arn)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30A20", Offset = "0x30A20")]
		private struct _003CAmazon_002DRuntime_002DSharedInterfaces_002DICoreAmazonSTS_WebIdentity_002DCredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AssumeRoleImmutableCredentials> _003C_003Et__builder;

			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AmazonSecurityTokenServiceClient _003C_003E4__this;

			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string webIdentityToken;

			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string roleArn;

			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string roleSessionName;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public AssumeRoleWithWebIdentityCredentialsOptions options;

			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<AssumeRoleWithWebIdentityResponse>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x12E6A2C", Offset = "0x12E6A2C", VA = "0x12E6A2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x12E6F2C", Offset = "0x12E6F2C", VA = "0x12E6F2C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IServiceMetadata serviceMetadata;

		[Token(Token = "0x17000001")]
		protected override IServiceMetadata ServiceMetadata
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x12D2BF0", Offset = "0x12D2BF0", VA = "0x12D2BF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x12D041C", Offset = "0x12D041C", VA = "0x12D041C", Slot = "23")]
		private SAMLImmutableCredentials Amazon_002ERuntime_002ESharedInterfaces_002EICoreAmazonSTS_SAML_002ECredentialsFromSAMLAuthentication(string endpoint, string authenticationType, string roleARN, TimeSpan credentialDuration, ICredentials userCredential)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x12D110C", Offset = "0x12D110C", VA = "0x12D110C")]
		private AssumeRoleWithWebIdentityRequest SetupAssumeRoleWithWebIdentityRequest(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x12D14D0", Offset = "0x12D14D0", VA = "0x12D14D0", Slot = "25")]
		private AssumeRoleImmutableCredentials Amazon_002ERuntime_002ESharedInterfaces_002EICoreAmazonSTS_WebIdentity_002ECredentialsFromAssumeRoleWithWebIdentityAuthentication(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x12D17DC", Offset = "0x12D17DC", VA = "0x12D17DC", Slot = "26")]
		private Task<AssumeRoleImmutableCredentials> Amazon_002ERuntime_002ESharedInterfaces_002EICoreAmazonSTS_WebIdentity_002ECredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(string webIdentityToken, string roleArn, string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x12D1918", Offset = "0x12D1918", VA = "0x12D1918", Slot = "22")]
		private AssumeRoleImmutableCredentials Amazon_002ERuntime_002ESharedInterfaces_002EICoreAmazonSTS_002ECredentialsFromAssumeRoleAuthentication(string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x12D1E6C", Offset = "0x12D1E6C", VA = "0x12D1E6C", Slot = "12")]
		protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x12D22EC", Offset = "0x12D22EC", VA = "0x12D22EC")]
		public AmazonSecurityTokenServiceClient()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x12D26EC", Offset = "0x12D26EC", VA = "0x12D26EC")]
		public AmazonSecurityTokenServiceClient(RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x12D27AC", Offset = "0x12D27AC", VA = "0x12D27AC")]
		public AmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x12D282C", Offset = "0x12D282C", VA = "0x12D282C")]
		public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x12D28A4", Offset = "0x12D28A4", VA = "0x12D28A4")]
		public AmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x12D289C", Offset = "0x12D289C", VA = "0x12D289C")]
		public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x12D2938", Offset = "0x12D2938", VA = "0x12D2938")]
		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x12D29C0", Offset = "0x12D29C0", VA = "0x12D29C0")]
		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x12D29B8", Offset = "0x12D29B8", VA = "0x12D29B8")]
		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x12D2A5C", Offset = "0x12D2A5C", VA = "0x12D2A5C")]
		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x12D2AEC", Offset = "0x12D2AEC", VA = "0x12D2AEC")]
		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x12D2AE4", Offset = "0x12D2AE4", VA = "0x12D2AE4")]
		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityTokenServiceConfig clientConfig)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x12D2B98", Offset = "0x12D2B98", VA = "0x12D2B98", Slot = "11")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x12D2C54", Offset = "0x12D2C54", VA = "0x12D2C54", Slot = "10")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x12D2C5C", Offset = "0x12D2C5C", VA = "0x12D2C5C", Slot = "27")]
		internal virtual AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x12D2DF4", Offset = "0x12D2DF4", VA = "0x12D2DF4", Slot = "28")]
		public virtual Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x12D2F94", Offset = "0x12D2F94", VA = "0x12D2F94", Slot = "29")]
		internal virtual AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x12D312C", Offset = "0x12D312C", VA = "0x12D312C", Slot = "30")]
		public virtual Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x12D32CC", Offset = "0x12D32CC", VA = "0x12D32CC", Slot = "31")]
		internal virtual AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x12D3464", Offset = "0x12D3464", VA = "0x12D3464", Slot = "32")]
		public virtual Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x12D3604", Offset = "0x12D3604", VA = "0x12D3604", Slot = "33")]
		internal virtual DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x12D379C", Offset = "0x12D379C", VA = "0x12D379C", Slot = "34")]
		public virtual Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x12D393C", Offset = "0x12D393C", VA = "0x12D393C", Slot = "35")]
		internal virtual GetAccessKeyInfoResponse GetAccessKeyInfo(GetAccessKeyInfoRequest request)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x12D3AD4", Offset = "0x12D3AD4", VA = "0x12D3AD4", Slot = "36")]
		public virtual Task<GetAccessKeyInfoResponse> GetAccessKeyInfoAsync(GetAccessKeyInfoRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x12D3C74", Offset = "0x12D3C74", VA = "0x12D3C74", Slot = "37")]
		internal virtual GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x12D3E0C", Offset = "0x12D3E0C", VA = "0x12D3E0C", Slot = "38")]
		public virtual Task<GetCallerIdentityResponse> GetCallerIdentityAsync(GetCallerIdentityRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x12D3FAC", Offset = "0x12D3FAC", VA = "0x12D3FAC", Slot = "39")]
		internal virtual GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x12D4144", Offset = "0x12D4144", VA = "0x12D4144", Slot = "40")]
		public virtual Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x12D42E4", Offset = "0x12D42E4", VA = "0x12D42E4", Slot = "41")]
		internal virtual GetSessionTokenResponse GetSessionToken()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x12D4360", Offset = "0x12D4360", VA = "0x12D4360", Slot = "42")]
		internal virtual GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x12D44F8", Offset = "0x12D44F8", VA = "0x12D44F8", Slot = "43")]
		public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x12D4574", Offset = "0x12D4574", VA = "0x12D4574", Slot = "44")]
		public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x12D4798", Offset = "0x12D4798", VA = "0x12D4798", Slot = "24")]
		private IClientConfig Amazon_002ERuntime_002EIAmazonService_002Eget_Config()
		{
			return null;
		}
	}
}
