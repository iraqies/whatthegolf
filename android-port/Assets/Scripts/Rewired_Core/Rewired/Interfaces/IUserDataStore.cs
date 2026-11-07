using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x200017D")]
	public interface IUserDataStore
	{
		[Token(Token = "0x6000C4E")]
		void Save();

		[Token(Token = "0x6000C4F")]
		void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

		[Token(Token = "0x6000C50")]
		void SaveControllerData(ControllerType controllerType, int controllerId);

		[Token(Token = "0x6000C51")]
		void Load();

		[Token(Token = "0x6000C52")]
		void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

		[Token(Token = "0x6000C53")]
		void LoadControllerData(ControllerType controllerType, int controllerId);
	}
}
