using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000069")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x130CA84", Offset = "0x130CA84", VA = "0x130CA84")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x130CAFC", Offset = "0x130CAFC", VA = "0x130CAFC")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x130CB74", Offset = "0x130CB74", VA = "0x130CB74")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x130CBEC", Offset = "0x130CBEC", VA = "0x130CBEC")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x130CC64", Offset = "0x130CC64", VA = "0x130CC64")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x130CCDC", Offset = "0x130CCDC", VA = "0x130CCDC")]
		public ButtonHandler()
		{
		}
	}
}
