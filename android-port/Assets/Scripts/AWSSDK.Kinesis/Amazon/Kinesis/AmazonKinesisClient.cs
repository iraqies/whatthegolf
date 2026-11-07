using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Kinesis
{
	[Token(Token = "0x200000B")]
	public class AmazonKinesisClient : AmazonServiceClient, IAmazonKinesis, IAmazonService, IDisposable
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IServiceMetadata serviceMetadata;

		[Token(Token = "0x17000004")]
		protected override IServiceMetadata ServiceMetadata
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x129BD40", Offset = "0x129BD40", VA = "0x129BD40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x129B6D0", Offset = "0x129B6D0", VA = "0x129B6D0")]
		public AmazonKinesisClient()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x129B83C", Offset = "0x129B83C", VA = "0x129B83C")]
		public AmazonKinesisClient(RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x129B8FC", Offset = "0x129B8FC", VA = "0x129B8FC")]
		public AmazonKinesisClient(AmazonKinesisConfig config)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x129B97C", Offset = "0x129B97C", VA = "0x129B97C")]
		public AmazonKinesisClient(AWSCredentials credentials)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x129B9F4", Offset = "0x129B9F4", VA = "0x129B9F4")]
		public AmazonKinesisClient(AWSCredentials credentials, RegionEndpoint region)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x129B9EC", Offset = "0x129B9EC", VA = "0x129B9EC")]
		public AmazonKinesisClient(AWSCredentials credentials, AmazonKinesisConfig clientConfig)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x129BA88", Offset = "0x129BA88", VA = "0x129BA88")]
		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x129BB10", Offset = "0x129BB10", VA = "0x129BB10")]
		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x129BB08", Offset = "0x129BB08", VA = "0x129BB08")]
		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisConfig clientConfig)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x129BBAC", Offset = "0x129BBAC", VA = "0x129BBAC")]
		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x129BC3C", Offset = "0x129BC3C", VA = "0x129BC3C")]
		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x129BC34", Offset = "0x129BC34", VA = "0x129BC34")]
		public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisConfig clientConfig)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x129BCE8", Offset = "0x129BCE8", VA = "0x129BCE8", Slot = "11")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x129BDA4", Offset = "0x129BDA4", VA = "0x129BDA4", Slot = "10")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x129BDAC", Offset = "0x129BDAC", VA = "0x129BDAC", Slot = "44")]
		internal virtual AddTagsToStreamResponse AddTagsToStream(AddTagsToStreamRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x129BF44", Offset = "0x129BF44", VA = "0x129BF44", Slot = "45")]
		public virtual Task<AddTagsToStreamResponse> AddTagsToStreamAsync(AddTagsToStreamRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x129C0E4", Offset = "0x129C0E4", VA = "0x129C0E4", Slot = "46")]
		internal virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x129C27C", Offset = "0x129C27C", VA = "0x129C27C", Slot = "47")]
		public virtual Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x129C41C", Offset = "0x129C41C", VA = "0x129C41C", Slot = "48")]
		internal virtual DecreaseStreamRetentionPeriodResponse DecreaseStreamRetentionPeriod(DecreaseStreamRetentionPeriodRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x129C5B4", Offset = "0x129C5B4", VA = "0x129C5B4", Slot = "49")]
		public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x129C718", Offset = "0x129C718", VA = "0x129C718", Slot = "50")]
		public virtual Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x129C8B8", Offset = "0x129C8B8", VA = "0x129C8B8", Slot = "51")]
		internal virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x129CA50", Offset = "0x129CA50", VA = "0x129CA50", Slot = "52")]
		public virtual Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x129CBF0", Offset = "0x129CBF0", VA = "0x129CBF0", Slot = "53")]
		internal virtual DeregisterStreamConsumerResponse DeregisterStreamConsumer(DeregisterStreamConsumerRequest request)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x129CD88", Offset = "0x129CD88", VA = "0x129CD88", Slot = "54")]
		public virtual Task<DeregisterStreamConsumerResponse> DeregisterStreamConsumerAsync(DeregisterStreamConsumerRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x129CF28", Offset = "0x129CF28", VA = "0x129CF28", Slot = "55")]
		internal virtual DescribeLimitsResponse DescribeLimits(DescribeLimitsRequest request)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x129D0C0", Offset = "0x129D0C0", VA = "0x129D0C0", Slot = "56")]
		public virtual Task<DescribeLimitsResponse> DescribeLimitsAsync(DescribeLimitsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x129D260", Offset = "0x129D260", VA = "0x129D260", Slot = "57")]
		internal virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x129D3F8", Offset = "0x129D3F8", VA = "0x129D3F8", Slot = "58")]
		public virtual Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x129D598", Offset = "0x129D598", VA = "0x129D598", Slot = "59")]
		internal virtual DescribeStreamConsumerResponse DescribeStreamConsumer(DescribeStreamConsumerRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x129D730", Offset = "0x129D730", VA = "0x129D730", Slot = "60")]
		public virtual Task<DescribeStreamConsumerResponse> DescribeStreamConsumerAsync(DescribeStreamConsumerRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x129D8D0", Offset = "0x129D8D0", VA = "0x129D8D0", Slot = "61")]
		internal virtual DescribeStreamSummaryResponse DescribeStreamSummary(DescribeStreamSummaryRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x129DA68", Offset = "0x129DA68", VA = "0x129DA68", Slot = "62")]
		public virtual Task<DescribeStreamSummaryResponse> DescribeStreamSummaryAsync(DescribeStreamSummaryRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x129DC08", Offset = "0x129DC08", VA = "0x129DC08", Slot = "63")]
		internal virtual DisableEnhancedMonitoringResponse DisableEnhancedMonitoring(DisableEnhancedMonitoringRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x129DDA0", Offset = "0x129DDA0", VA = "0x129DDA0", Slot = "64")]
		public virtual Task<DisableEnhancedMonitoringResponse> DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x129DF40", Offset = "0x129DF40", VA = "0x129DF40", Slot = "65")]
		internal virtual EnableEnhancedMonitoringResponse EnableEnhancedMonitoring(EnableEnhancedMonitoringRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x129E0D8", Offset = "0x129E0D8", VA = "0x129E0D8", Slot = "66")]
		public virtual Task<EnableEnhancedMonitoringResponse> EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x129E278", Offset = "0x129E278", VA = "0x129E278", Slot = "67")]
		internal virtual GetRecordsResponse GetRecords(GetRecordsRequest request)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x129E410", Offset = "0x129E410", VA = "0x129E410", Slot = "68")]
		public virtual Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x129E5B0", Offset = "0x129E5B0", VA = "0x129E5B0", Slot = "69")]
		internal virtual GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x129E748", Offset = "0x129E748", VA = "0x129E748", Slot = "70")]
		public virtual Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x129E8E8", Offset = "0x129E8E8", VA = "0x129E8E8", Slot = "71")]
		internal virtual IncreaseStreamRetentionPeriodResponse IncreaseStreamRetentionPeriod(IncreaseStreamRetentionPeriodRequest request)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x129EA80", Offset = "0x129EA80", VA = "0x129EA80", Slot = "72")]
		public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x129EBE4", Offset = "0x129EBE4", VA = "0x129EBE4", Slot = "73")]
		public virtual Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x129ED84", Offset = "0x129ED84", VA = "0x129ED84", Slot = "74")]
		internal virtual ListShardsResponse ListShards(ListShardsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x129EF1C", Offset = "0x129EF1C", VA = "0x129EF1C", Slot = "75")]
		public virtual Task<ListShardsResponse> ListShardsAsync(ListShardsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x129F0BC", Offset = "0x129F0BC", VA = "0x129F0BC", Slot = "76")]
		internal virtual ListStreamConsumersResponse ListStreamConsumers(ListStreamConsumersRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x129F254", Offset = "0x129F254", VA = "0x129F254", Slot = "77")]
		public virtual Task<ListStreamConsumersResponse> ListStreamConsumersAsync(ListStreamConsumersRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x129F3F4", Offset = "0x129F3F4", VA = "0x129F3F4", Slot = "78")]
		internal virtual ListStreamsResponse ListStreams()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x129F470", Offset = "0x129F470", VA = "0x129F470", Slot = "79")]
		internal virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x129F608", Offset = "0x129F608", VA = "0x129F608", Slot = "80")]
		public virtual Task<ListStreamsResponse> ListStreamsAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x129F684", Offset = "0x129F684", VA = "0x129F684", Slot = "81")]
		public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x129F824", Offset = "0x129F824", VA = "0x129F824", Slot = "82")]
		internal virtual ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x129F9BC", Offset = "0x129F9BC", VA = "0x129F9BC", Slot = "83")]
		public virtual Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x129FB5C", Offset = "0x129FB5C", VA = "0x129FB5C", Slot = "84")]
		internal virtual MergeShardsResponse MergeShards(MergeShardsRequest request)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x129FCF4", Offset = "0x129FCF4", VA = "0x129FCF4", Slot = "85")]
		public virtual Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x129FE94", Offset = "0x129FE94", VA = "0x129FE94", Slot = "86")]
		internal virtual PutRecordResponse PutRecord(PutRecordRequest request)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x12A002C", Offset = "0x12A002C", VA = "0x12A002C", Slot = "87")]
		public virtual Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x12A01CC", Offset = "0x12A01CC", VA = "0x12A01CC", Slot = "88")]
		internal virtual PutRecordsResponse PutRecords(PutRecordsRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x12A0364", Offset = "0x12A0364", VA = "0x12A0364", Slot = "89")]
		public virtual Task<PutRecordsResponse> PutRecordsAsync(PutRecordsRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x12A0504", Offset = "0x12A0504", VA = "0x12A0504", Slot = "90")]
		internal virtual RegisterStreamConsumerResponse RegisterStreamConsumer(RegisterStreamConsumerRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x12A069C", Offset = "0x12A069C", VA = "0x12A069C", Slot = "91")]
		public virtual Task<RegisterStreamConsumerResponse> RegisterStreamConsumerAsync(RegisterStreamConsumerRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x12A083C", Offset = "0x12A083C", VA = "0x12A083C", Slot = "92")]
		internal virtual RemoveTagsFromStreamResponse RemoveTagsFromStream(RemoveTagsFromStreamRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x12A09D4", Offset = "0x12A09D4", VA = "0x12A09D4", Slot = "93")]
		public virtual Task<RemoveTagsFromStreamResponse> RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x12A0B74", Offset = "0x12A0B74", VA = "0x12A0B74", Slot = "94")]
		internal virtual SplitShardResponse SplitShard(SplitShardRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x12A0D0C", Offset = "0x12A0D0C", VA = "0x12A0D0C", Slot = "95")]
		public virtual Task<SplitShardResponse> SplitShardAsync(SplitShardRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x12A0EAC", Offset = "0x12A0EAC", VA = "0x12A0EAC", Slot = "96")]
		internal virtual StartStreamEncryptionResponse StartStreamEncryption(StartStreamEncryptionRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x12A1044", Offset = "0x12A1044", VA = "0x12A1044", Slot = "97")]
		public virtual Task<StartStreamEncryptionResponse> StartStreamEncryptionAsync(StartStreamEncryptionRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x12A11E4", Offset = "0x12A11E4", VA = "0x12A11E4", Slot = "98")]
		internal virtual StopStreamEncryptionResponse StopStreamEncryption(StopStreamEncryptionRequest request)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x12A137C", Offset = "0x12A137C", VA = "0x12A137C", Slot = "99")]
		public virtual Task<StopStreamEncryptionResponse> StopStreamEncryptionAsync(StopStreamEncryptionRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x12A151C", Offset = "0x12A151C", VA = "0x12A151C", Slot = "100")]
		internal virtual UpdateShardCountResponse UpdateShardCount(UpdateShardCountRequest request)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x12A16B4", Offset = "0x12A16B4", VA = "0x12A16B4", Slot = "101")]
		public virtual Task<UpdateShardCountResponse> UpdateShardCountAsync(UpdateShardCountRequest request, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x12A18D8", Offset = "0x12A18D8", VA = "0x12A18D8", Slot = "43")]
		private IClientConfig Amazon_002ERuntime_002EIAmazonService_002Eget_Config()
		{
			return null;
		}
	}
}
