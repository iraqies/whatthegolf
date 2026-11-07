using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[Token(Token = "0x2000313")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x191EB0", Offset = "0x191EB0")]
	public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet
	{
		[Token(Token = "0x400102E")]
		private const int FEYqngSpWHCylzGRtugricMIeqFB = 1;

		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CustomControllerElementTarget _target;

		[Token(Token = "0x17000653")]
		public CustomControllerElementTarget target
		{
			[Token(Token = "0x60017B2")]
			[Address(RVA = "0x2374C44", Offset = "0x2374C44", VA = "0x2374C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000654")]
		internal override int targetCount
		{
			[Token(Token = "0x60017B3")]
			[Address(RVA = "0x2374C4C", Offset = "0x2374C4C", VA = "0x2374C4C", Slot = "4")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000655")]
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x2374C54", Offset = "0x2374C54", VA = "0x2374C54", Slot = "5")]
		internal override CustomControllerElementTarget get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x2374CA0", Offset = "0x2374CA0", VA = "0x2374CA0")]
		internal CustomControllerElementTargetSetForBoolean()
		{
		}

		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x2374D7C", Offset = "0x2374D7C", VA = "0x2374D7C", Slot = "6")]
		internal override void ClearElementCaches()
		{
		}
	}
}
