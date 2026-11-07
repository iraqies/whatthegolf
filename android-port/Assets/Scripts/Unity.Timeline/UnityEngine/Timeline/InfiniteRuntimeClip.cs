using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200001F")]
	internal class InfiniteRuntimeClip : RuntimeElement
	{
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x18")]
		private Playable m_Playable;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long kIntervalEnd;

		[Token(Token = "0x17000075")]
		public override long intervalStart
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x2AE7E68", Offset = "0x2AE7E68", VA = "0x2AE7E68", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000076")]
		public override long intervalEnd
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x2AE7E70", Offset = "0x2AE7E70", VA = "0x2AE7E70", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000077")]
		public override bool enable
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x2AE7ED4", Offset = "0x2AE7ED4", VA = "0x2AE7ED4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2AE5928", Offset = "0x2AE5928", VA = "0x2AE5928")]
		public InfiniteRuntimeClip(Playable playable)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2AE7F58", Offset = "0x2AE7F58", VA = "0x2AE7F58", Slot = "9")]
		public override void EvaluateAt(double localTime, FrameData frameData)
		{
		}
	}
}
