using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x2000009")]
	public class AmazonCognitoSyncClient : AmazonServiceClient, IAmazonCognitoSync, IAmazonService, IDisposable
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IServiceMetadata serviceMetadata;

		[Token(Token = "0x17000004")]
		protected override IServiceMetadata ServiceMetadata
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x118CCC0", Offset = "0x118CCC0", VA = "0x118CCC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x118C594", Offset = "0x118C594", VA = "0x118C594")]
		public AmazonCognitoSyncClient()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x118C700", Offset = "0x118C700", VA = "0x118C700")]
		public AmazonCognitoSyncClient(RegionEndpoint region)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x118C7C0", Offset = "0x118C7C0", VA = "0x118C7C0")]
		public AmazonCognitoSyncClient(AmazonCognitoSyncConfig config)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x118C840", Offset = "0x118C840", VA = "0x118C840")]
		public AmazonCognitoSyncClient(AWSCredentials credentials)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x118C8B8", Offset = "0x118C8B8", VA = "0x118C8B8")]
		public AmazonCognitoSyncClient(AWSCredentials credentials, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x118C8B0", Offset = "0x118C8B0", VA = "0x118C8B0")]
		public AmazonCognitoSyncClient(AWSCredentials credentials, AmazonCognitoSyncConfig clientConfig)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x118C94C", Offset = "0x118C94C", VA = "0x118C94C")]
		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x118C9D4", Offset = "0x118C9D4", VA = "0x118C9D4")]
		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x118C9CC", Offset = "0x118C9CC", VA = "0x118C9CC")]
		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoSyncConfig clientConfig)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x118CA70", Offset = "0x118CA70", VA = "0x118CA70")]
		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x118CB00", Offset = "0x118CB00", VA = "0x118CB00")]
		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x118CAF8", Offset = "0x118CAF8", VA = "0x118CAF8")]
		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoSyncConfig clientConfig)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x118CBAC", Offset = "0x118CBAC", VA = "0x118CBAC", Slot = "11")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x118CC04", Offset = "0x118CC04", VA = "0x118CC04", Slot = "12")]
		protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x118CD24", Offset = "0x118CD24", VA = "0x118CD24", Slot = "10")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x118CD2C", Offset = "0x118CD2C", VA = "0x118CD2C", Slot = "33")]
		internal virtual BulkPublishResponse BulkPublish(BulkPublishRequest request)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x118CEC4", Offset = "0x118CEC4", VA = "0x118CEC4", Slot = "34")]
		public virtual Task<BulkPublishResponse> BulkPublishAsync(BulkPublishRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x118D064", Offset = "0x118D064", VA = "0x118D064", Slot = "35")]
		internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x118D1FC", Offset = "0x118D1FC", VA = "0x118D1FC", Slot = "36")]
		public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x118D39C", Offset = "0x118D39C", VA = "0x118D39C", Slot = "37")]
		internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x118D534", Offset = "0x118D534", VA = "0x118D534", Slot = "38")]
		public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x118D6D4", Offset = "0x118D6D4", VA = "0x118D6D4", Slot = "39")]
		internal virtual DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x118D86C", Offset = "0x118D86C", VA = "0x118D86C", Slot = "40")]
		public virtual Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(string identityPoolId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x118D908", Offset = "0x118D908", VA = "0x118D908", Slot = "41")]
		public virtual Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x118DAA8", Offset = "0x118DAA8", VA = "0x118DAA8", Slot = "42")]
		internal virtual DescribeIdentityUsageResponse DescribeIdentityUsage(DescribeIdentityUsageRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x118DC40", Offset = "0x118DC40", VA = "0x118DC40", Slot = "43")]
		public virtual Task<DescribeIdentityUsageResponse> DescribeIdentityUsageAsync(DescribeIdentityUsageRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x118DDE0", Offset = "0x118DDE0", VA = "0x118DDE0", Slot = "44")]
		internal virtual GetBulkPublishDetailsResponse GetBulkPublishDetails(GetBulkPublishDetailsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x118DF78", Offset = "0x118DF78", VA = "0x118DF78", Slot = "45")]
		public virtual Task<GetBulkPublishDetailsResponse> GetBulkPublishDetailsAsync(GetBulkPublishDetailsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x118E118", Offset = "0x118E118", VA = "0x118E118", Slot = "46")]
		internal virtual GetCognitoEventsResponse GetCognitoEvents(GetCognitoEventsRequest request)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x118E2B0", Offset = "0x118E2B0", VA = "0x118E2B0", Slot = "47")]
		public virtual Task<GetCognitoEventsResponse> GetCognitoEventsAsync(GetCognitoEventsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x118E450", Offset = "0x118E450", VA = "0x118E450", Slot = "48")]
		internal virtual GetIdentityPoolConfigurationResponse GetIdentityPoolConfiguration(GetIdentityPoolConfigurationRequest request)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x118E5E8", Offset = "0x118E5E8", VA = "0x118E5E8", Slot = "49")]
		public virtual Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(string identityPoolId, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x118E684", Offset = "0x118E684", VA = "0x118E684", Slot = "50")]
		public virtual Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(GetIdentityPoolConfigurationRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x118E824", Offset = "0x118E824", VA = "0x118E824", Slot = "51")]
		internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x118E9BC", Offset = "0x118E9BC", VA = "0x118E9BC", Slot = "52")]
		public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x118EB5C", Offset = "0x118EB5C", VA = "0x118EB5C", Slot = "53")]
		internal virtual ListIdentityPoolUsageResponse ListIdentityPoolUsage(ListIdentityPoolUsageRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x118ECF4", Offset = "0x118ECF4", VA = "0x118ECF4", Slot = "54")]
		public virtual Task<ListIdentityPoolUsageResponse> ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x118EE94", Offset = "0x118EE94", VA = "0x118EE94", Slot = "55")]
		internal virtual ListRecordsResponse ListRecords(ListRecordsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x118F02C", Offset = "0x118F02C", VA = "0x118F02C", Slot = "56")]
		public virtual Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x118F1CC", Offset = "0x118F1CC", VA = "0x118F1CC", Slot = "57")]
		internal virtual RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x118F364", Offset = "0x118F364", VA = "0x118F364", Slot = "58")]
		public virtual Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x118F504", Offset = "0x118F504", VA = "0x118F504", Slot = "59")]
		internal virtual SetCognitoEventsResponse SetCognitoEvents(SetCognitoEventsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x118F69C", Offset = "0x118F69C", VA = "0x118F69C", Slot = "60")]
		public virtual Task<SetCognitoEventsResponse> SetCognitoEventsAsync(SetCognitoEventsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x118F83C", Offset = "0x118F83C", VA = "0x118F83C", Slot = "61")]
		internal virtual SetIdentityPoolConfigurationResponse SetIdentityPoolConfiguration(SetIdentityPoolConfigurationRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x118F9D4", Offset = "0x118F9D4", VA = "0x118F9D4", Slot = "62")]
		public virtual Task<SetIdentityPoolConfigurationResponse> SetIdentityPoolConfigurationAsync(SetIdentityPoolConfigurationRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x118FB74", Offset = "0x118FB74", VA = "0x118FB74", Slot = "63")]
		internal virtual SubscribeToDatasetResponse SubscribeToDataset(SubscribeToDatasetRequest request)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x118FD0C", Offset = "0x118FD0C", VA = "0x118FD0C", Slot = "64")]
		public virtual Task<SubscribeToDatasetResponse> SubscribeToDatasetAsync(SubscribeToDatasetRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x118FEAC", Offset = "0x118FEAC", VA = "0x118FEAC", Slot = "65")]
		internal virtual UnsubscribeFromDatasetResponse UnsubscribeFromDataset(UnsubscribeFromDatasetRequest request)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1190044", Offset = "0x1190044", VA = "0x1190044", Slot = "66")]
		public virtual Task<UnsubscribeFromDatasetResponse> UnsubscribeFromDatasetAsync(UnsubscribeFromDatasetRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x11901E4", Offset = "0x11901E4", VA = "0x11901E4", Slot = "67")]
		internal virtual UpdateRecordsResponse UpdateRecords(UpdateRecordsRequest request)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x119037C", Offset = "0x119037C", VA = "0x119037C", Slot = "68")]
		public virtual Task<UpdateRecordsResponse> UpdateRecordsAsync(UpdateRecordsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x11905A0", Offset = "0x11905A0", VA = "0x11905A0", Slot = "32")]
		private IClientConfig Amazon_002ERuntime_002EIAmazonService_002Eget_Config()
		{
			return null;
		}
	}
}
