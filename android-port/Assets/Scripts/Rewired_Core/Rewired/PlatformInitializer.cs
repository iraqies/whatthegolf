using Il2CppDummyDll;
using Rewired.Data;
using Rewired.Interfaces;

namespace Rewired
{
	[Token(Token = "0x2000017")]
	internal abstract class PlatformInitializer
	{
		[Token(Token = "0x600008D")]
		public abstract object Initialize(IConfigVars_Internal configVars);

		[Token(Token = "0x600008E")]
		public abstract IElementIdentifierTool CreateTool(string inputSourceString);
	}
}
