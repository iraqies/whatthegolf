namespace Rewired.Interfaces
{
	public interface IControllerMapStore
	{
		ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId);
	}
}
