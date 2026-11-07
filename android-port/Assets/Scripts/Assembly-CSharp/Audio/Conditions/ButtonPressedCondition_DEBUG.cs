using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Conditions
{
	[Token(Token = "0x20013EC")]
	public class ButtonPressedCondition_DEBUG : AudioCondition
	{
		[Token(Token = "0x4006B2E")]
		[FieldOffset(Offset = "0x18")]
		public KeyCode Keycode;

		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0x17DA034", Offset = "0x17DA034", VA = "0x17DA034", Slot = "4")]
		public override bool CheckCondition()
		{
			return default;
		}

		[Token(Token = "0x6005CDC")]
		[Address(RVA = "0x17DA040", Offset = "0x17DA040", VA = "0x17DA040")]
		public ButtonPressedCondition_DEBUG()
		{
		}
	}
}
