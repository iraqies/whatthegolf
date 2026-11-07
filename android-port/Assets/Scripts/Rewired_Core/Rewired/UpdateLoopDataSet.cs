using System;
using Il2CppDummyDll;
using Rewired.Config;

namespace Rewired
{
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x190964", Offset = "0x190964")]
	internal class UpdateLoopDataSet<T> where T : class
	{
		[Token(Token = "0x2000022")]
		private class xsMJBGmRwWlPzYApiztwYCiVQxLi
		{
			[Token(Token = "0x40000B3")]
			[FieldOffset(Offset = "0x0")]
			public readonly UpdateLoopType PiEdbgjMHSsksYjRKSGckYZEsfAE;

			[Token(Token = "0x40000B4")]
			[FieldOffset(Offset = "0x0")]
			public T lPMziJCFRnvinaKeGNwjXRpuzYwf;

			[Token(Token = "0x60000C5")]
			public xsMJBGmRwWlPzYApiztwYCiVQxLi(UpdateLoopType P_0)
			{
			}
		}

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x0")]
		private xsMJBGmRwWlPzYApiztwYCiVQxLi dQvTvZqdFSzAQjIiXjyfRtrnHABD;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		private int BnPuTevKonSCNieJesLlCkEZXpqL;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x0")]
		public readonly int fixedUpdateSetIndex;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x0")]
		private readonly int[] IKaHcMMMReldkZgFUUrjWQfbHzQi;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		private readonly xsMJBGmRwWlPzYApiztwYCiVQxLi[] TIBkwaYFfrlorrgEzKrMTlQMftSC;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x0")]
		private UpdateLoopType VrMfQjbtWyjujWgdTnMyJaEVdoEy;

		[Token(Token = "0x17000042")]
		public T Current
		{
			[Token(Token = "0x60000BB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public int Count
		{
			[Token(Token = "0x60000BC")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000044")]
		[Token(Token = "0x60000BD")]
		public T get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		public void set_Item(int index, T value)
		{
		}

		[Token(Token = "0x60000BF")]
		public UpdateLoopDataSet(UpdateLoopSetting P_0)
		{
		}

		[Token(Token = "0x60000C0")]
		public UpdateLoopDataSet(UpdateLoopSetting P_0, Func<T> P_1)
		{
		}

		[Token(Token = "0x60000C1")]
		public void SetUpdateLoop(UpdateLoopType updateLoop)
		{
		}

		[Token(Token = "0x60000C2")]
		public T Get(int index)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		public T Get(UpdateLoopType updateLoop)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		public UpdateLoopType GetUpdateLoopType(int index)
		{
			return default;
		}
	}
}
