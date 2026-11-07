using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[Token(Token = "0x2000314")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x191EE8", Offset = "0x191EE8")]
	public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet
	{
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _splitValue;

		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CustomControllerElementTarget _target;

		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CustomControllerElementTarget _positiveTarget;

		[Token(Token = "0x4001033")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CustomControllerElementTarget _negativeTarget;

		[Token(Token = "0x17000656")]
		public bool splitValue
		{
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x2374D98", Offset = "0x2374D98", VA = "0x2374D98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000657")]
		public CustomControllerElementTarget target
		{
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x2374DA0", Offset = "0x2374DA0", VA = "0x2374DA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000658")]
		public CustomControllerElementTarget positiveTarget
		{
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x2374DA8", Offset = "0x2374DA8", VA = "0x2374DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000659")]
		public CustomControllerElementTarget negativeTarget
		{
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x2374DB0", Offset = "0x2374DB0", VA = "0x2374DB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065A")]
		internal override int targetCount
		{
			[Token(Token = "0x60017BB")]
			[Address(RVA = "0x2374DB8", Offset = "0x2374DB8", VA = "0x2374DB8", Slot = "4")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700065B")]
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x2374DCC", Offset = "0x2374DCC", VA = "0x2374DCC", Slot = "5")]
		internal override CustomControllerElementTarget get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x2374E4C", Offset = "0x2374E4C", VA = "0x2374E4C")]
		internal CustomControllerElementTargetSetForFloat()
		{
		}

		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x2375004", Offset = "0x2375004", VA = "0x2375004")]
		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget P_0)
		{
		}

		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x23751CC", Offset = "0x23751CC", VA = "0x23751CC", Slot = "6")]
		internal override void ClearElementCaches()
		{
		}
	}
}
