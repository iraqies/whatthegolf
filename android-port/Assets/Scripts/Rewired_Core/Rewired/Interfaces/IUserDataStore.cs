namespace Rewired.Interfaces
{
	public interface IUserDataStore
	{
		void Save();

		void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

		void SaveControllerData(ControllerType controllerType, int controllerId);

		void Load();

		void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

		void LoadControllerData(ControllerType controllerType, int controllerId);
	}
}
