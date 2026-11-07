using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000008")]
	public struct ElementAssignment
	{
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		public ElementAssignmentType type;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x4")]
		public int elementMapId;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x8")]
		public int elementIdentifierId;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xC")]
		public AxisRange axisRange;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x10")]
		public KeyCode keyboardKey;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x14")]
		public ModifierKeyFlags modifierKeyFlags;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x18")]
		public int actionId;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x1C")]
		public Pole axisContribution;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		public bool invert;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x23C93C8", Offset = "0x23C93C8", VA = "0x23C93C8")]
		public ElementAssignment(ElementAssignmentType P_0, int P_1, AxisRange P_2, KeyCode P_3, ModifierKeyFlags P_4, int P_5, Pole P_6, bool P_7, int P_8)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x23C93E8", Offset = "0x23C93E8", VA = "0x23C93E8")]
		public ElementAssignment(ControllerType P_0, ControllerElementType P_1, int P_2, AxisRange P_3, KeyCode P_4, ModifierKeyFlags P_5, int P_6, Pole P_7, bool P_8, int P_9)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x23C946C", Offset = "0x23C946C", VA = "0x23C946C")]
		public ElementAssignment(ControllerType P_0, ControllerElementType P_1, int P_2, AxisRange P_3, KeyCode P_4, ModifierKeyFlags P_5, int P_6, Pole P_7, bool P_8)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x23C94E8", Offset = "0x23C94E8", VA = "0x23C94E8")]
		public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck()
		{
			return default;
		}
	}
}
