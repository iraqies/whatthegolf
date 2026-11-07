using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x200017B")]
	internal interface IControllerTemplateElementIdentifier_Editor : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier
	{
		[Token(Token = "0x17000377")]
		string scriptingName
		{
			[Token(Token = "0x6000C48")]
			get;
		}

		[Token(Token = "0x17000378")]
		string alternateScriptingName
		{
			[Token(Token = "0x6000C49")]
			get;
		}
	}
}
