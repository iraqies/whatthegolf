using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x200017E")]
	public interface IControllerMapStore
	{
		[Token(Token = "0x6000C54")]
		ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId);
	}
}
