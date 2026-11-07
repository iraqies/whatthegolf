namespace Rewired.Interfaces
{
	internal interface IControllerAssigner
	{
		bool CanHandleAssignment(ControllerType controllerType, Controller controller);

		void AssignController(ControllerType controllerType, Controller controller);
	}
}
