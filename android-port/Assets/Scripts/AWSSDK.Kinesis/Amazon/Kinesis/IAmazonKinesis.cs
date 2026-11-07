using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Kinesis.Model;
using Amazon.Runtime;

namespace Amazon.Kinesis
{
	public interface IAmazonKinesis : IAmazonService, IDisposable
	{
		Task<AddTagsToStreamResponse> AddTagsToStreamAsync(AddTagsToStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, CancellationToken cancellationToken = default(CancellationToken));

		Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DeregisterStreamConsumerResponse> DeregisterStreamConsumerAsync(DeregisterStreamConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeLimitsResponse> DescribeLimitsAsync(DescribeLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeStreamConsumerResponse> DescribeStreamConsumerAsync(DescribeStreamConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DescribeStreamSummaryResponse> DescribeStreamSummaryAsync(DescribeStreamSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<DisableEnhancedMonitoringResponse> DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<EnableEnhancedMonitoringResponse> EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, CancellationToken cancellationToken = default(CancellationToken));

		Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListShardsResponse> ListShardsAsync(ListShardsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListStreamConsumersResponse> ListStreamConsumersAsync(ListStreamConsumersRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListStreamsResponse> ListStreamsAsync(CancellationToken cancellationToken = default(CancellationToken));

		Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<PutRecordsResponse> PutRecordsAsync(PutRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<RegisterStreamConsumerResponse> RegisterStreamConsumerAsync(RegisterStreamConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<RemoveTagsFromStreamResponse> RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<SplitShardResponse> SplitShardAsync(SplitShardRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<StartStreamEncryptionResponse> StartStreamEncryptionAsync(StartStreamEncryptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<StopStreamEncryptionResponse> StopStreamEncryptionAsync(StopStreamEncryptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

		Task<UpdateShardCountResponse> UpdateShardCountAsync(UpdateShardCountRequest request, CancellationToken cancellationToken = default(CancellationToken));
	}
}
