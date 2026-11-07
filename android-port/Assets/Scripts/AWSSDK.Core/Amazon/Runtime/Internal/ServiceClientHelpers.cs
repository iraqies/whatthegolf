using System.Reflection;
using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200016C")]
	public static class ServiceClientHelpers
	{
		[Token(Token = "0x200016D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D10", Offset = "0x25D10")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x400058A")]
			[FieldOffset(Offset = "0x10")]
			public string assemblyName;

			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x1296044", Offset = "0x1296044", VA = "0x1296044")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x129604C", Offset = "0x129604C", VA = "0x129604C")]
			internal bool _003CGetSDKAssembly_003Eb__0(Assembly x)
			{
				return default;
			}
		}

		[Token(Token = "0x4000583")]
		public const string S3_ASSEMBLY_NAME = "AWSSDK.S3";

		[Token(Token = "0x4000584")]
		public const string S3_SERVICE_CLASS_NAME = "Amazon.S3.AmazonS3Client";

		[Token(Token = "0x4000585")]
		public const string STS_ASSEMBLY_NAME = "AWSSDK.SecurityToken";

		[Token(Token = "0x4000586")]
		public const string STS_SERVICE_CLASS_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient";

		[Token(Token = "0x4000587")]
		public const string STS_SERVICE_CONFIG_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceConfig";

		[Token(Token = "0x4000588")]
		public const string KMS_ASSEMBLY_NAME = "AWSSDK.KeyManagementService";

		[Token(Token = "0x4000589")]
		public const string KMS_SERVICE_CLASS_NAME = "Amazon.KeyManagementService.AmazonKeyManagementServiceClient";

		[Token(Token = "0x6000B97")]
		public static TClient CreateServiceFromAnother<TClient, TConfig>(AmazonServiceClient originalServiceClient) where TClient : AmazonServiceClient where TConfig : ClientConfig, new()
		{
			return null;
		}

		[Token(Token = "0x6000B98")]
		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, RegionEndpoint region) where TClient : class
		{
			return null;
		}

		[Token(Token = "0x6000B99")]
		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, AWSCredentials credentials, RegionEndpoint region) where TClient : class
		{
			return null;
		}

		[Token(Token = "0x6000B9A")]
		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, AWSCredentials credentials, ClientConfig config) where TClient : class
		{
			return null;
		}

		[Token(Token = "0x6000B9B")]
		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, AmazonServiceClient originalServiceClient) where TClient : class
		{
			return null;
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x1270E00", Offset = "0x1270E00", VA = "0x1270E00")]
		public static ClientConfig CreateServiceConfig(string assemblyName, string serviceConfigClassName)
		{
			return null;
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x127101C", Offset = "0x127101C", VA = "0x127101C")]
		private static ITypeInfo LoadServiceClientType(string assemblyName, string serviceClientClassName)
		{
			return null;
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x1270F80", Offset = "0x1270F80", VA = "0x1270F80")]
		private static ITypeInfo LoadServiceConfigType(string assemblyName, string serviceConfigClassName)
		{
			return null;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x12710B8", Offset = "0x12710B8", VA = "0x12710B8")]
		private static Assembly GetSDKAssembly(string assemblyName)
		{
			return null;
		}
	}
}
