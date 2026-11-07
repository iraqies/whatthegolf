using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x200000A")]
	public interface IAmazonCognitoSync : IAmazonService, IDisposable
	{
		[Token(Token = "0x6000052")]
		Task<BulkPublishResponse> BulkPublishAsync(BulkPublishRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000053")]
		Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000054")]
		Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000055")]
		Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(string identityPoolId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000056")]
		Task<DescribeIdentityPoolUsageResponse> DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000057")]
		Task<DescribeIdentityUsageResponse> DescribeIdentityUsageAsync(DescribeIdentityUsageRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000058")]
		Task<GetBulkPublishDetailsResponse> GetBulkPublishDetailsAsync(GetBulkPublishDetailsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000059")]
		Task<GetCognitoEventsResponse> GetCognitoEventsAsync(GetCognitoEventsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600005A")]
		Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(string identityPoolId, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600005B")]
		Task<GetIdentityPoolConfigurationResponse> GetIdentityPoolConfigurationAsync(GetIdentityPoolConfigurationRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600005C")]
		Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600005D")]
		Task<ListIdentityPoolUsageResponse> ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600005E")]
		Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600005F")]
		Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000060")]
		Task<SetCognitoEventsResponse> SetCognitoEventsAsync(SetCognitoEventsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000061")]
		Task<SetIdentityPoolConfigurationResponse> SetIdentityPoolConfigurationAsync(SetIdentityPoolConfigurationRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000062")]
		Task<SubscribeToDatasetResponse> SubscribeToDatasetAsync(SubscribeToDatasetRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000063")]
		Task<UnsubscribeFromDatasetResponse> UnsubscribeFromDatasetAsync(UnsubscribeFromDatasetRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000064")]
		Task<UpdateRecordsResponse> UpdateRecordsAsync(UpdateRecordsRequest request, [Optional] CancellationToken cancellationToken);
	}
}
