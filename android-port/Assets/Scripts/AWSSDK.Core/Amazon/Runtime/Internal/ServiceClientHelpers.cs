using System.Reflection;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal
{
	public static class ServiceClientHelpers
	{
		public const string S3_ASSEMBLY_NAME = "AWSSDK.S3";

		public const string S3_SERVICE_CLASS_NAME = "Amazon.S3.AmazonS3Client";

		public const string STS_ASSEMBLY_NAME = "AWSSDK.SecurityToken";

		public const string STS_SERVICE_CLASS_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceClient";

		public const string STS_SERVICE_CONFIG_NAME = "Amazon.SecurityToken.AmazonSecurityTokenServiceConfig";

		public const string KMS_ASSEMBLY_NAME = "AWSSDK.KeyManagementService";

		public const string KMS_SERVICE_CLASS_NAME = "Amazon.KeyManagementService.AmazonKeyManagementServiceClient";

		public static TClient CreateServiceFromAnother<TClient, TConfig>(AmazonServiceClient originalServiceClient) where TClient : AmazonServiceClient where TConfig : ClientConfig, new()
		{
			return null;
		}

		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, RegionEndpoint region) where TClient : class
		{
			return null;
		}

		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, AWSCredentials credentials, RegionEndpoint region) where TClient : class
		{
			return null;
		}

		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, AWSCredentials credentials, ClientConfig config) where TClient : class
		{
			return null;
		}

		public static TClient CreateServiceFromAssembly<TClient>(string assemblyName, string serviceClientClassName, AmazonServiceClient originalServiceClient) where TClient : class
		{
			return null;
		}

		public static ClientConfig CreateServiceConfig(string assemblyName, string serviceConfigClassName)
		{
			return null;
		}

		private static ITypeInfo LoadServiceClientType(string assemblyName, string serviceClientClassName)
		{
			return null;
		}

		private static ITypeInfo LoadServiceConfigType(string assemblyName, string serviceConfigClassName)
		{
			return null;
		}

		private static Assembly GetSDKAssembly(string assemblyName)
		{
			return null;
		}
	}
}
