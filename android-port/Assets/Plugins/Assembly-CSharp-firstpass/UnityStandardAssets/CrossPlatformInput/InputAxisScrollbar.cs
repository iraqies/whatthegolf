using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200006D")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x139D684", Offset = "0x139D684", VA = "0x139D684")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x139D714", Offset = "0x139D714", VA = "0x139D714")]
		public InputAxisScrollbar()
		{
		}
	}
}
