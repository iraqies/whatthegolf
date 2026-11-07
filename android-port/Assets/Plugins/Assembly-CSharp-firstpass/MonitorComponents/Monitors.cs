using System.Collections.Generic;
using Il2CppDummyDll;

namespace MonitorComponents
{
	[Token(Token = "0x2000274")]
	public class Monitors
	{
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x0")]
		private static Monitors instance;

		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x10")]
		private List<Monitor> monitors;

		[Token(Token = "0x170001F2")]
		public static Monitors Instance
		{
			[Token(Token = "0x600103D")]
			[Address(RVA = "0x13AE66C", Offset = "0x13AE66C", VA = "0x13AE66C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600103E")]
		[Address(RVA = "0x13AE74C", Offset = "0x13AE74C", VA = "0x13AE74C")]
		public void Add(Monitor monitor)
		{
		}

		[Token(Token = "0x600103F")]
		[Address(RVA = "0x13AE9E4", Offset = "0x13AE9E4", VA = "0x13AE9E4")]
		public void Remove(Monitor monitor)
		{
		}

		[Token(Token = "0x6001040")]
		[Address(RVA = "0x13B4B14", Offset = "0x13B4B14", VA = "0x13B4B14")]
		public Monitors()
		{
		}
	}
}
