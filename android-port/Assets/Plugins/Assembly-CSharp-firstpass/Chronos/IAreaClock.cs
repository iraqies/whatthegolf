using Il2CppDummyDll;

namespace Chronos
{
	[Token(Token = "0x200028B")]
	public interface IAreaClock
	{
		[Token(Token = "0x170001FF")]
		ClockBlend innerBlend
		{
			[Token(Token = "0x60010C6")]
			get;
		}

		[Token(Token = "0x60010C4")]
		void Release(Timeline timeline);

		[Token(Token = "0x60010C5")]
		float TimeScale(Timeline timeline);
	}
}
