using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000025")]
	internal abstract class RuntimeClipBase : RuntimeElement
	{
		[Token(Token = "0x17000081")]
		public abstract double start
		{
			[Token(Token = "0x60001B4")]
			get;
		}

		[Token(Token = "0x17000082")]
		public abstract double duration
		{
			[Token(Token = "0x60001B5")]
			get;
		}

		[Token(Token = "0x17000083")]
		public override long intervalStart
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x2AEAE88", Offset = "0x2AEAE88", VA = "0x2AEAE88", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000084")]
		public override long intervalEnd
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x2AEAF10", Offset = "0x2AEAF10", VA = "0x2AEAF10", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2AEA2EC", Offset = "0x2AEA2EC", VA = "0x2AEA2EC")]
		protected RuntimeClipBase()
		{
		}
	}
}
