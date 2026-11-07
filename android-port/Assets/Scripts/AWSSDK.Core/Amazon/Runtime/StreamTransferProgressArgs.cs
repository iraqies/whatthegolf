using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x2000106")]
	public class StreamTransferProgressArgs : EventArgs
	{
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x10")]
		private long _incrementTransferred;

		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x18")]
		private long _total;

		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x20")]
		private long _transferred;

		[Token(Token = "0x17000260")]
		public int PercentDone
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x127C1C8", Offset = "0x127C1C8", VA = "0x127C1C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000261")]
		public long IncrementTransferred
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x127C1DC", Offset = "0x127C1DC", VA = "0x127C1DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000262")]
		public long TransferredBytes
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x127C1E4", Offset = "0x127C1E4", VA = "0x127C1E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000263")]
		public long TotalBytes
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x127C1EC", Offset = "0x127C1EC", VA = "0x127C1EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x127C110", Offset = "0x127C110", VA = "0x127C110")]
		public StreamTransferProgressArgs(long incrementTransferred, long transferred, long total)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x127C1F4", Offset = "0x127C1F4", VA = "0x127C1F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
