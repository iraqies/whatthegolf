using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x200017F")]
	internal interface IControllerAssigner
	{
		[Token(Token = "0x6000C55")]
		bool CanHandleAssignment(ControllerType controllerType, Controller controller);

		[Token(Token = "0x6000C56")]
		void AssignController(ControllerType controllerType, Controller controller);
	}
}
