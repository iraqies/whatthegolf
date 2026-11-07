using Il2CppDummyDll;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200007A")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x13FD000", Offset = "0x13FD000", VA = "0x13FD000", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x13FD014", Offset = "0x13FD014", VA = "0x13FD014", Slot = "5")]
		public override bool GetButtonDown(string name)
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x13FD020", Offset = "0x13FD020", VA = "0x13FD020", Slot = "6")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x13FD074", Offset = "0x13FD074", VA = "0x13FD074", Slot = "7")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x13FD0C8", Offset = "0x13FD0C8", VA = "0x13FD0C8", Slot = "8")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x13FD11C", Offset = "0x13FD11C", VA = "0x13FD11C", Slot = "9")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x13FD170", Offset = "0x13FD170", VA = "0x13FD170", Slot = "10")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x13FD1C4", Offset = "0x13FD1C4", VA = "0x13FD1C4", Slot = "11")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x13FD218", Offset = "0x13FD218", VA = "0x13FD218")]
		public StandaloneInput()
		{
		}
	}
}
