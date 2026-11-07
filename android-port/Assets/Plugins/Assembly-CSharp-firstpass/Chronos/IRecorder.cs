using Il2CppDummyDll;

namespace Chronos
{
	[Token(Token = "0x20002A3")]
	public interface IRecorder
	{
		[Token(Token = "0x600116C")]
		void Reset();

		[Token(Token = "0x600116D")]
		int EstimateMemoryUsage();
	}
}
