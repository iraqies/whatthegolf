using Chronos;
using Il2CppDummyDll;

namespace Puzzle
{
	[Token(Token = "0x200103D")]
	public interface ITimedPuzzleObject
	{
		[Token(Token = "0x60048CE")]
		void SetClock(LocalClock clock);
	}
}
