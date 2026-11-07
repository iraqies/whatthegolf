using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000004")]
	public struct InputActionEventData
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private ItaEjuKtoATtafYloiocFOanqPQc ztqcsjQogOGkbcfdohylerMDCirk;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		private InputActionEventType vMNdyFbeFKZgkjkoYtuNxpwHfmqv;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0xC")]
		public readonly int playerId;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		public readonly int actionId;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x14")]
		public readonly UpdateLoopType updateLoop;

		[Token(Token = "0x17000003")]
		internal InputActionEventType eventType
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x23D2A0C", Offset = "0x23D2A0C", VA = "0x23D2A0C")]
			set
			{
				oENTcUXnbQVTSxraqICAInUKNXhK(inputActionEventType);
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x23D2A0C", Offset = "0x23D2A0C", VA = "0x23D2A0C")]
		internal void oENTcUXnbQVTSxraqICAInUKNXhK(InputActionEventType P_0)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x23D2A14", Offset = "0x23D2A14", VA = "0x23D2A14")]
		internal InputActionEventData(ItaEjuKtoATtafYloiocFOanqPQc P_0, int P_1, int P_2, UpdateLoopType P_3)
		{
		}
	}
}
