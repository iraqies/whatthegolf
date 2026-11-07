using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001DB")]
	public class Timing : IMetricsTiming
	{
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x10")]
		private long startTime;

		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x18")]
		private long endTime;

		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x279C8", Offset = "0x279C8")]
		private bool IsFinished__BackingField;

		[Token(Token = "0x170003B5")]
		public bool IsFinished
		{
			[Token(Token = "0x6000EA6")]
			[Address(RVA = "0x127CE3C", Offset = "0x127CE3C", VA = "0x127CE3C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B7D4", Offset = "0x2B7D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000EA7")]
			[Address(RVA = "0x127CE44", Offset = "0x127CE44", VA = "0x127CE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B7E4", Offset = "0x2B7E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170003B6")]
		public long ElapsedTicks
		{
			[Token(Token = "0x6000EA8")]
			[Address(RVA = "0x127CE4C", Offset = "0x127CE4C", VA = "0x127CE4C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003B7")]
		public TimeSpan ElapsedTime
		{
			[Token(Token = "0x6000EA9")]
			[Address(RVA = "0x127CE6C", Offset = "0x127CE6C", VA = "0x127CE6C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x127CDCC", Offset = "0x127CDCC", VA = "0x127CDCC")]
		public Timing()
		{
		}

		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x127CDFC", Offset = "0x127CDFC", VA = "0x127CDFC")]
		public Timing(long currentTime)
		{
		}

		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x127CE2C", Offset = "0x127CE2C", VA = "0x127CE2C")]
		public void Stop(long currentTime)
		{
		}
	}
}
