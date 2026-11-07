namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	public static class KinesisActionIdentifiers
	{
		public static readonly ActionIdentifier AllKinesisActions;

		public static readonly ActionIdentifier CreateStream;

		public static readonly ActionIdentifier DeleteStream;

		public static readonly ActionIdentifier DescribeStream;

		public static readonly ActionIdentifier ListStreams;

		public static readonly ActionIdentifier PutRecord;

		public static readonly ActionIdentifier GetShardIterator;

		public static readonly ActionIdentifier GetRecords;

		public static readonly ActionIdentifier MergeShards;

		public static readonly ActionIdentifier SplitShard;
	}
}
