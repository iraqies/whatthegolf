using System;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000059")]
	public class JitteredDelay
	{
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x10")]
		private TimeSpan _maxDelay;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x18")]
		private TimeSpan _variance;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x20")]
		private TimeSpan _baseIncrement;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x28")]
		private Random _rand;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x30")]
		private int _count;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x121EBB8", Offset = "0x121EBB8", VA = "0x121EBB8")]
		public JitteredDelay(TimeSpan baseIncrement, TimeSpan variance)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x121EC68", Offset = "0x121EC68", VA = "0x121EC68")]
		public JitteredDelay(TimeSpan baseIncrement, TimeSpan variance, TimeSpan maxDelay)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x121ECF4", Offset = "0x121ECF4", VA = "0x121ECF4")]
		public TimeSpan GetRetryDelay(int attemptCount)
		{
			return default;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x121EDC4", Offset = "0x121EDC4", VA = "0x121EDC4")]
		public TimeSpan Next()
		{
			return default;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x121EE0C", Offset = "0x121EE0C", VA = "0x121EE0C")]
		public void Reset()
		{
		}
	}
}
