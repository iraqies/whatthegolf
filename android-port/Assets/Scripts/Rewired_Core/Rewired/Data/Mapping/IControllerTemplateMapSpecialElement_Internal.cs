using Il2CppDummyDll;

namespace Rewired.Data.Mapping
{
	[Token(Token = "0x20002B6")]
	internal interface IControllerTemplateMapSpecialElement_Internal
	{
		[Token(Token = "0x60013B3")]
		T GetMapping<T>() where T : ControllerTemplateSpecialElementMapping;
	}
}
