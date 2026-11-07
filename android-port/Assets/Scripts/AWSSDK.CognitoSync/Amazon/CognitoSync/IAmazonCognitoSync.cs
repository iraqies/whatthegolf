using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoSync.Model;
using Amazon.Runtime;

namespace Amazon.CognitoSync
{
	public interface IAmazonCognitoSync : IAmazonService, IDisposable
	{
		Task<BulkPublishResponse> BulkPublishAsync(BulkPublishRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeIdentityUsageResponse> DescribeIdentityUsageAsync(DescribeIdentityUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetBulkPublishDetailsResponse> GetBulkPublishDetailsAsync(GetBulkPublishDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetCognitoEventsResponse> GetCognitoEventsAsync(GetCognitoEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(string identityPoolId, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(GetIdentityPoolConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListIdentityPoolUsageResponse> ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetCognitoEventsResponse> SetCognitoEventsAsync(SetCognitoEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SetIdentityPoolConfigurationResponse> SetIdentityPoolConfigurationAsync(SetIdentityPoolConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SubscribeToDatasetResponse> SubscribeToDatasetAsync(SubscribeToDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UnsubscribeFromDatasetResponse> UnsubscribeFromDatasetAsync(UnsubscribeFromDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateRecordsResponse> UpdateRecordsAsync(UpdateRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));
	}
}
