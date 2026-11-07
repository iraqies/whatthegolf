using Il2CppDummyDll;
using Rewired.Internal;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000174")]
	internal interface IElementIdentifierTool
	{
		[Token(Token = "0x6000C33")]
		void Initialize(GUIText guiText);

		[Token(Token = "0x6000C34")]
		void Start();

		[Token(Token = "0x6000C35")]
		void Update();

		[Token(Token = "0x6000C36")]
		void OnDestroy();
	}
}
