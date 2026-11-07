using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000002")]
	public sealed class ControllerStatusChangedEventArgs : EventArgs
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private string hEJFspqWqeBOdedbqHNRpPNEbfBG;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private int UceKlChkUHGjQaNwpAzeqaieFMpt;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x1C")]
		private ControllerType KHkewZTAeuvHVDDJaWvnQRRxxDiF;

		[Token(Token = "0x17000001")]
		public int controllerId
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x23686F4", Offset = "0x23686F4", VA = "0x23686F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000002")]
		public ControllerType controllerType
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x23686FC", Offset = "0x23686FC", VA = "0x23686FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2368704", Offset = "0x2368704", VA = "0x2368704")]
		public ControllerStatusChangedEventArgs(string P_0, int P_1, ControllerType P_2)
		{
		}
	}
}
