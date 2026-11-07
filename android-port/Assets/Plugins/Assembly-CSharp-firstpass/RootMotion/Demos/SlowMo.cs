using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200025A")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000F7A")]
		[FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x13FBC58", Offset = "0x13FBC58", VA = "0x13FBC58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x13FBC88", Offset = "0x13FBC88", VA = "0x13FBC88")]
		private bool IsSlowMotion()
		{
			return default;
		}

		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x13FBD48", Offset = "0x13FBD48", VA = "0x13FBD48")]
		public SlowMo()
		{
		}
	}
}
