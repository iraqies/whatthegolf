using System;
using Il2CppDummyDll;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[Token(Token = "0x2000312")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x191E78", Offset = "0x191E78")]
	public abstract class CustomControllerElementTargetSet
	{
		[Token(Token = "0x17000651")]
		internal abstract int targetCount
		{
			[Token(Token = "0x60017AE")]
			get;
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000652")]
		[Token(Token = "0x60017AF")]
		internal abstract CustomControllerElementTarget get_Item(int index);

		[Token(Token = "0x60017B0")]
		internal abstract void ClearElementCaches();

		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x2374C3C", Offset = "0x2374C3C", VA = "0x2374C3C")]
		protected CustomControllerElementTargetSet()
		{
		}
	}
}
