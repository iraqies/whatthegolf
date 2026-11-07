namespace ZXing.PDF417
{
	public sealed class PDF417MacroMetadata
	{
		public int SegmentIndex { get; }

		public string FileId { get; }

		public int SegmentCount { get; }

		public string Sender { get; }

		public string Addressee { get; }

		public string FileName { get; }

		public long? FileSize { get; }

		public int? Checksum { get; }

		public long? Timestamp { get; }
	}
}
