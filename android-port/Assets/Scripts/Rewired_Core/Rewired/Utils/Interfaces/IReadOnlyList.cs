using Il2CppDummyDll;

namespace Rewired.Utils.Interfaces
{
	[Token(Token = "0x2000396")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x192294", Offset = "0x192294")]
	internal interface IReadOnlyList
	{
		[Token(Token = "0x17000732")]
		int Count
		{
			[Token(Token = "0x6001B9B")]
			get;
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000733")]
		[Token(Token = "0x6001B9C")]
		object get_Item(int index);
	}
}
