using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000043")]
	public sealed class CustomController : ControllerWithAxes
	{
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x158")]
		private int iaffKOkGQHfQnQXgmjxXCjrvpuxu;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x160")]
		private Func<int, float> LPxLRwuenJKjnaUGDRRTfKoDurIn;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x168")]
		private Func<int, bool> rnFmbfHEOUgFMmBQOWoxCxIWMJZD;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x170")]
		private bool yzcKsJMDeIRHgPciVraqzlyRLviv;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x174")]
		private Guid guGxXkQdSCnhDedSVaPzhraGphmHA;

		[Token(Token = "0x17000098")]
		public int sourceControllerId
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x2370C74", Offset = "0x2370C74", VA = "0x2370C74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000099")]
		public override Guid deviceInstanceGuid
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2370C7C", Offset = "0x2370C7C", VA = "0x2370C7C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2370D68", Offset = "0x2370D68", VA = "0x2370D68")]
		internal CustomController(LDGblTyVuNxcqdmvXxXJqAlXAiYR P_0)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2370E54", Offset = "0x2370E54", VA = "0x2370E54")]
		private CustomController(int P_0, int P_1, Guid P_2, InputSource P_3, string P_4, string P_5, string P_6, int P_7, int P_8, HardwareControllerMap_Game P_9, Extension P_10, ControllerDataUpdater P_11)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2370FCC", Offset = "0x2370FCC", VA = "0x2370FCC")]
		internal void pPRJisySYxBqxxleQgjLYfheiyTx()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2371108", Offset = "0x2371108", VA = "0x2371108")]
		public void SetAxisValue(int index, float value)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2371268", Offset = "0x2371268", VA = "0x2371268")]
		public void SetButtonValue(int index, bool value)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x23713BC", Offset = "0x23713BC", VA = "0x23713BC")]
		public void SetAxisUpdateCallback(Func<int, float> callback)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2371484", Offset = "0x2371484", VA = "0x2371484")]
		public void SetButtonUpdateCallback(Func<int, bool> callback)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x237154C", Offset = "0x237154C", VA = "0x237154C")]
		public void ClearAxisValue(int index)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x23716C0", Offset = "0x23716C0", VA = "0x23716C0")]
		public void ClearButtonValue(int index)
		{
		}
	}
}
