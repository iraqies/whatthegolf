using Il2CppDummyDll;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000079")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x13ADE60", Offset = "0x13ADE60", VA = "0x13ADE60")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x13ADEF8", Offset = "0x13ADEF8", VA = "0x13ADEF8")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x13ADF90", Offset = "0x13ADF90", VA = "0x13ADF90", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x13AE034", Offset = "0x13AE034", VA = "0x13AE034", Slot = "6")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x13AE0D8", Offset = "0x13AE0D8", VA = "0x13AE0D8", Slot = "7")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x13AE17C", Offset = "0x13AE17C", VA = "0x13AE17C", Slot = "8")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x13AE224", Offset = "0x13AE224", VA = "0x13AE224", Slot = "9")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x13AE2CC", Offset = "0x13AE2CC", VA = "0x13AE2CC", Slot = "10")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x13AE370", Offset = "0x13AE370", VA = "0x13AE370", Slot = "11")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x13AE420", Offset = "0x13AE420", VA = "0x13AE420", Slot = "5")]
		public override bool GetButtonDown(string name)
		{
			return default;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x13AE4C4", Offset = "0x13AE4C4", VA = "0x13AE4C4")]
		public MobileInput()
		{
		}
	}
}
