using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Kinesis
{
	public class AmazonKinesisClient : AmazonServiceClient, IAmazonKinesis, IAmazonService, IDisposable
	{
		private static IServiceMetadata serviceMetadata;

		protected override IServiceMetadata ServiceMetadata => null;

		IClientConfig IAmazonService.Config => null;

		public AmazonKinesisClient()
			: base(null, null)
		{
		}

		public AmazonKinesisClient(RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(AmazonKinesisConfig config)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(AWSCredentials credentials)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(AWSCredentials credentials, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(AWSCredentials credentials, AmazonKinesisConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisConfig clientConfig)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
			: base(null, null)
		{
		}

		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisConfig clientConfig)
			: base(null, null)
		{
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal virtual AddTagsToStreamResponse AddTagsToStream(AddTagsToStreamRequest request)
		{
			return null;
		}

		public virtual Task<AddTagsToStreamResponse> AddTagsToStreamAsync(AddTagsToStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
		{
			return null;
		}

		public virtual Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DecreaseStreamRetentionPeriodResponse DecreaseStreamRetentionPeriod(DecreaseStreamRetentionPeriodRequest request)
		{
			return null;
		}

		public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
		{
			return null;
		}

		public virtual Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DeregisterStreamConsumerResponse DeregisterStreamConsumer(DeregisterStreamConsumerRequest request)
		{
			return null;
		}

		public virtual Task<DeregisterStreamConsumerResponse> DeregisterStreamConsumerAsync(DeregisterStreamConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeLimitsResponse DescribeLimits(DescribeLimitsRequest request)
		{
			return null;
		}

		public virtual Task<DescribeLimitsResponse> DescribeLimitsAsync(DescribeLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
		{
			return null;
		}

		public virtual Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeStreamConsumerResponse DescribeStreamConsumer(DescribeStreamConsumerRequest request)
		{
			return null;
		}

		public virtual Task<DescribeStreamConsumerResponse> DescribeStreamConsumerAsync(DescribeStreamConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DescribeStreamSummaryResponse DescribeStreamSummary(DescribeStreamSummaryRequest request)
		{
			return null;
		}

		public virtual Task<DescribeStreamSummaryResponse> DescribeStreamSummaryAsync(DescribeStreamSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual DisableEnhancedMonitoringResponse DisableEnhancedMonitoring(DisableEnhancedMonitoringRequest request)
		{
			return null;
		}

		public virtual Task<DisableEnhancedMonitoringResponse> DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual EnableEnhancedMonitoringResponse EnableEnhancedMonitoring(EnableEnhancedMonitoringRequest request)
		{
			return null;
		}

		public virtual Task<EnableEnhancedMonitoringResponse> EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetRecordsResponse GetRecords(GetRecordsRequest request)
		{
			return null;
		}

		public virtual Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request)
		{
			return null;
		}

		public virtual Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual IncreaseStreamRetentionPeriodResponse IncreaseStreamRetentionPeriod(IncreaseStreamRetentionPeriodRequest request)
		{
			return null;
		}

		public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListShardsResponse ListShards(ListShardsRequest request)
		{
			return null;
		}

		public virtual Task<ListShardsResponse> ListShardsAsync(ListShardsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListStreamConsumersResponse ListStreamConsumers(ListStreamConsumersRequest request)
		{
			return null;
		}

		public virtual Task<ListStreamConsumersResponse> ListStreamConsumersAsync(ListStreamConsumersRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListStreamsResponse ListStreams()
		{
			return null;
		}

		internal virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
		{
			return null;
		}

		public virtual Task<ListStreamsResponse> ListStreamsAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
		{
			return null;
		}

		public virtual Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual MergeShardsResponse MergeShards(MergeShardsRequest request)
		{
			return null;
		}

		public virtual Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual PutRecordResponse PutRecord(PutRecordRequest request)
		{
			return null;
		}

		public virtual Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual PutRecordsResponse PutRecords(PutRecordsRequest request)
		{
			return null;
		}

		public virtual Task<PutRecordsResponse> PutRecordsAsync(PutRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual RegisterStreamConsumerResponse RegisterStreamConsumer(RegisterStreamConsumerRequest request)
		{
			return null;
		}

		public virtual Task<RegisterStreamConsumerResponse> RegisterStreamConsumerAsync(RegisterStreamConsumerRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual RemoveTagsFromStreamResponse RemoveTagsFromStream(RemoveTagsFromStreamRequest request)
		{
			return null;
		}

		public virtual Task<RemoveTagsFromStreamResponse> RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual SplitShardResponse SplitShard(SplitShardRequest request)
		{
			return null;
		}

		public virtual Task<SplitShardResponse> SplitShardAsync(SplitShardRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual StartStreamEncryptionResponse StartStreamEncryption(StartStreamEncryptionRequest request)
		{
			return null;
		}

		public virtual Task<StartStreamEncryptionResponse> StartStreamEncryptionAsync(StartStreamEncryptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual StopStreamEncryptionResponse StopStreamEncryption(StopStreamEncryptionRequest request)
		{
			return null;
		}

		public virtual Task<StopStreamEncryptionResponse> StopStreamEncryptionAsync(StopStreamEncryptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal virtual UpdateShardCountResponse UpdateShardCount(UpdateShardCountRequest request)
		{
			return null;
		}

		public virtual Task<UpdateShardCountResponse> UpdateShardCountAsync(UpdateShardCountRequest request, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
