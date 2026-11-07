namespace ZXing.QrCode.Internal
{
	internal sealed class BlockPair
	{
		private readonly byte[] dataBytes;

		private readonly byte[] errorCorrectionBytes;

		public byte[] DataBytes => null;

		public byte[] ErrorCorrectionBytes => null;

		public BlockPair(byte[] data, byte[] errorCorrection)
		{
		}
	}
}
