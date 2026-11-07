using UnityEngine;

namespace Rewired
{
	public struct ElementAssignment
	{
		public ElementAssignmentType type;

		public int elementMapId;

		public int elementIdentifierId;

		public AxisRange axisRange;

		public KeyCode keyboardKey;

		public ModifierKeyFlags modifierKeyFlags;

		public int actionId;

		public Pole axisContribution;

		public bool invert;

		public ElementAssignment(ElementAssignmentType P_0, int P_1, AxisRange P_2, KeyCode P_3, ModifierKeyFlags P_4, int P_5, Pole P_6, bool P_7, int P_8)
		{
			type = ElementAssignmentType.FullAxis;
			elementMapId = 0;
			elementIdentifierId = 0;
			axisRange = AxisRange.Full;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			actionId = 0;
			axisContribution = Pole.Positive;
			invert = false;
		}

		public ElementAssignment(ControllerType P_0, ControllerElementType P_1, int P_2, AxisRange P_3, KeyCode P_4, ModifierKeyFlags P_5, int P_6, Pole P_7, bool P_8, int P_9)
		{
			type = ElementAssignmentType.FullAxis;
			elementMapId = 0;
			elementIdentifierId = 0;
			axisRange = AxisRange.Full;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			actionId = 0;
			axisContribution = Pole.Positive;
			invert = false;
		}

		public ElementAssignment(ControllerType P_0, ControllerElementType P_1, int P_2, AxisRange P_3, KeyCode P_4, ModifierKeyFlags P_5, int P_6, Pole P_7, bool P_8)
		{
			type = ElementAssignmentType.FullAxis;
			elementMapId = 0;
			elementIdentifierId = 0;
			axisRange = AxisRange.Full;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			actionId = 0;
			axisContribution = Pole.Positive;
			invert = false;
		}

		public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck()
		{
			return default;
		}
	}
}
