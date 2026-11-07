using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x200000C")]
	public interface IAmazonKinesis : IAmazonService, IDisposable
	{
		[Token(Token = "0x600006F")]
		Task<AddTagsToStreamResponse> AddTagsToStreamAsync(AddTagsToStreamRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000070")]
		Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000071")]
		Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000072")]
		Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000073")]
		Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000074")]
		Task<DeregisterStreamConsumerResponse> DeregisterStreamConsumerAsync(DeregisterStreamConsumerRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000075")]
		Task<DescribeLimitsResponse> DescribeLimitsAsync(DescribeLimitsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000076")]
		Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000077")]
		Task<DescribeStreamConsumerResponse> DescribeStreamConsumerAsync(DescribeStreamConsumerRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000078")]
		Task<DescribeStreamSummaryResponse> DescribeStreamSummaryAsync(DescribeStreamSummaryRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000079")]
		Task<DisableEnhancedMonitoringResponse> DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600007A")]
		Task<EnableEnhancedMonitoringResponse> EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600007B")]
		Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600007C")]
		Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600007D")]
		Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600007E")]
		Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600007F")]
		Task<ListShardsResponse> ListShardsAsync(ListShardsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000080")]
		Task<ListStreamConsumersResponse> ListStreamConsumersAsync(ListStreamConsumersRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000081")]
		Task<ListStreamsResponse> ListStreamsAsync([Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000082")]
		Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000083")]
		Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000084")]
		Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000085")]
		Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000086")]
		Task<PutRecordsResponse> PutRecordsAsync(PutRecordsRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000087")]
		Task<RegisterStreamConsumerResponse> RegisterStreamConsumerAsync(RegisterStreamConsumerRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000088")]
		Task<RemoveTagsFromStreamResponse> RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x6000089")]
		Task<SplitShardResponse> SplitShardAsync(SplitShardRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600008A")]
		Task<StartStreamEncryptionResponse> StartStreamEncryptionAsync(StartStreamEncryptionRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600008B")]
		Task<StopStreamEncryptionResponse> StopStreamEncryptionAsync(StopStreamEncryptionRequest request, [Optional] CancellationToken cancellationToken);

		[Token(Token = "0x600008C")]
		Task<UpdateShardCountResponse> UpdateShardCountAsync(UpdateShardCountRequest request, [Optional] CancellationToken cancellationToken);
	}
}
