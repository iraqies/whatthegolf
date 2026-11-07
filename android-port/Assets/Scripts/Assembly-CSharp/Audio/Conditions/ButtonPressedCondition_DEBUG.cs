using UnityEngine;

namespace Audio.Conditions
{
	public class ButtonPressedCondition_DEBUG : AudioCondition
	{
		public KeyCode Keycode;

		public override bool CheckCondition()
		{
			return false;
		}
	}
}
