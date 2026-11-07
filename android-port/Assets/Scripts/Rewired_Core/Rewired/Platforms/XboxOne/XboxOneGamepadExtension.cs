using Il2CppDummyDll;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

namespace Rewired.Platforms.XboxOne
{
	[Token(Token = "0x200019D")]
	public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator
	{
		[Token(Token = "0x200019E")]
		private class rKYRURQbUzdxQHxIhEXtftnHBdHw : IControllerExtensionSource
		{
			[Token(Token = "0x400095B")]
			[FieldOffset(Offset = "0x10")]
			public OCxnhoeHJSmdQcYpgnyghAYbUGqI althziZnBCLwxMViIeGJaEFtrKgM;

			[Token(Token = "0x400095C")]
			[FieldOffset(Offset = "0x28")]
			public readonly IXboxOneInputSource GcmEfGWGpZLjOdiyIOEjPeAmuYvC;

			[Token(Token = "0x400095D")]
			[FieldOffset(Offset = "0x30")]
			public readonly bool BMKmLgTjByiExXMvsepaerGfBiXH;

			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x239CCC8", Offset = "0x239CCC8", VA = "0x239CCC8")]
			public rKYRURQbUzdxQHxIhEXtftnHBdHw(bool P_0, IXboxOneInputSource P_1, OCxnhoeHJSmdQcYpgnyghAYbUGqI P_2)
			{
			}
		}

		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x28")]
		private rKYRURQbUzdxQHxIhEXtftnHBdHw rmMLNGpqXVBSkkjZadentyrvdrgtA;

		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x30")]
		private TimerAbs[] IfVBCqaFujeIzJMUNQBcBKnduRXLA;

		[Token(Token = "0x1700037B")]
		private Joystick chcOLBMXAtWUArFXncgBETOGbAnFb
		{
			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x243F438", Offset = "0x243F438", VA = "0x243F438")]
			get
			{
				return NKJBdAZFtaZFYonWmdsDGqkWMUMxA();
			}
		}

		[Token(Token = "0x1700037C")]
		public ulong xboxOneJoystickId
		{
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x243F490", Offset = "0x243F490", VA = "0x243F490")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700037D")]
		public int vibrationMotorCount
		{
			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x243F7BC", Offset = "0x243F7BC", VA = "0x243F7BC", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x243F438", Offset = "0x243F438", VA = "0x243F438")]
		private Joystick NKJBdAZFtaZFYonWmdsDGqkWMUMxA()
		{
			return null;
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x243F5EC", Offset = "0x243F5EC", VA = "0x243F5EC")]
		internal XboxOneGamepadExtension(bool P_0, IXboxOneInputSource P_1)
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x243F724", Offset = "0x243F724", VA = "0x243F724")]
		private XboxOneGamepadExtension(XboxOneGamepadExtension P_0)
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x243F86C", Offset = "0x243F86C", VA = "0x243F86C", Slot = "9")]
		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x243F9C4", Offset = "0x243F9C4", VA = "0x243F9C4", Slot = "12")]
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x243F874", Offset = "0x243F874", VA = "0x243F874", Slot = "10")]
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x243FBF0", Offset = "0x243FBF0", VA = "0x243FBF0", Slot = "11")]
		public void StopVibration()
		{
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x243F9CC", Offset = "0x243F9CC", VA = "0x243F9CC")]
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x243FF5C", Offset = "0x243FF5C", VA = "0x243FF5C", Slot = "6")]
		internal void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x243FFFC", Offset = "0x243FFFC", VA = "0x243FFFC", Slot = "5")]
		internal void EJfWkXMMYTRfEHNEnCEaDzBnFICoA(IControllerExtensionSource P_0)
		{
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x2440088", Offset = "0x2440088", VA = "0x2440088", Slot = "7")]
		internal Controller.Extension vpHGhDFXfrFPnKJBKRFCgbudEJvBB()
		{
			return null;
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x243FF60", Offset = "0x243FF60", VA = "0x243FF60")]
		private void RkjJWtCPffqNHKYZiSpumVKUPDFy()
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x243FE3C", Offset = "0x243FE3C", VA = "0x243FE3C")]
		private void uLJgIUZWcYRvIJfnwylMTtjINIBA(XboxOneGamepadMotorType P_0, float P_1, float P_2)
		{
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x243FD1C", Offset = "0x243FD1C", VA = "0x243FD1C")]
		private void eFuFKyJtpUZgMpxZDmhhdBiyfABcb()
		{
		}
	}
}
