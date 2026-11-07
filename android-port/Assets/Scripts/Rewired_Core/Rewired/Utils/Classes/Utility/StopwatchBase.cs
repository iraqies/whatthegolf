using Il2CppDummyDll;

namespace Rewired.Utils.Classes.Utility
{
	[Token(Token = "0x2000361")]
	internal abstract class StopwatchBase
	{
		[Token(Token = "0x170006C0")]
		public abstract double offsetSeconds
		{
			[Token(Token = "0x60019D7")]
			get;
		}

		[Token(Token = "0x170006C1")]
		public abstract long offsetTicks
		{
			[Token(Token = "0x60019D8")]
			get;
		}

		[Token(Token = "0x170006C2")]
		public abstract double elapsedSeconds
		{
			[Token(Token = "0x60019D9")]
			get;
		}

		[Token(Token = "0x60019DA")]
		public abstract void Start();

		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x241ADD8", Offset = "0x241ADD8", VA = "0x241ADD8")]
		protected StopwatchBase()
		{
		}
	}
}
