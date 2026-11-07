using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoSync
{
	public class AmazonCognitoSyncClient : AmazonServiceClient, IAmazonCognitoSync, IAmazonService, IDisposable
	{
		private static IServiceMetadata serviceMetadata;

		protected override IServiceMetadata ServiceMetadata => null;

		IClientConfig IAmazonService.Config => null;

		public AmazonCognitoSyncClient()
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(AmazonCognitoSyncConfig config)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(AWSCredentials credentials)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(AWSCredentials credentials, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(AWSCredentials credentials, AmazonCognitoSyncConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoSyncConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoSyncConfig clientConfig)
			: base(null, null)
		{
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal virtual BulkPublishResponse BulkPublish(BulkPublishRequest request)
		{
			return null;
		}

		public virtual Task<BulkPublishResponse> BulkPublishAsync(BulkPublishRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
		{
			return null;
		}

		public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
		{
			return null;
		}

		public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request)
		{
			return null;
		}

		public virtual Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeIdentityUsageResponse DescribeIdentityUsage(DescribeIdentityUsageRequest request)
		{
			return null;
		}

		public virtual Task<DescribeIdentityUsageResponse> DescribeIdentityUsageAsync(DescribeIdentityUsageRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetBulkPublishDetailsResponse GetBulkPublishDetails(GetBulkPublishDetailsRequest request)
		{
			return null;
		}

		public virtual Task<GetBulkPublishDetailsResponse> GetBulkPublishDetailsAsync(GetBulkPublishDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetCognitoEventsResponse GetCognitoEvents(GetCognitoEventsRequest request)
		{
			return null;
		}

		public virtual Task<GetCognitoEventsResponse> GetCognitoEventsAsync(GetCognitoEventsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetIdentityPoolConfigurationResponse GetIdentityPoolConfiguration(GetIdentityPoolConfigurationRequest request)
		{
			return null;
		}

		public virtual Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(GetIdentityPoolConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
		{
			return null;
		}

		public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListIdentityPoolUsageResponse ListIdentityPoolUsage(ListIdentityPoolUsageRequest request)
		{
			return null;
		}

		public virtual Task<ListIdentityPoolUsageResponse> ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListRecordsResponse ListRecords(ListRecordsRequest request)
		{
			return null;
		}

		public virtual Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
		{
			return null;
		}

		public virtual Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetCognitoEventsResponse SetCognitoEvents(SetCognitoEventsRequest request)
		{
			return null;
		}

		public virtual Task<SetCognitoEventsResponse> SetCognitoEventsAsync(SetCognitoEventsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SetIdentityPoolConfigurationResponse SetIdentityPoolConfiguration(SetIdentityPoolConfigurationRequest request)
		{
			return null;
		}

		public virtual Task<SetIdentityPoolConfigurationResponse> SetIdentityPoolConfigurationAsync(SetIdentityPoolConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SubscribeToDatasetResponse SubscribeToDataset(SubscribeToDatasetRequest request)
		{
			return null;
		}

		public virtual Task<SubscribeToDatasetResponse> SubscribeToDatasetAsync(SubscribeToDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UnsubscribeFromDatasetResponse UnsubscribeFromDataset(UnsubscribeFromDatasetRequest request)
		{
			return null;
		}

		public virtual Task<UnsubscribeFromDatasetResponse> UnsubscribeFromDatasetAsync(UnsubscribeFromDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateRecordsResponse UpdateRecords(UpdateRecordsRequest request)
		{
			return null;
		}

		public virtual Task<UpdateRecordsResponse> UpdateRecordsAsync(UpdateRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
