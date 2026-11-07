using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000035")]
	public class DefaultAllocationStrategy : IAllocationStrategy
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2A63BB4", Offset = "0x2A63BB4", VA = "0x2A63BB4", Slot = "4")]
		public object New(Type type, int typeHash)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2A63BC0", Offset = "0x2A63BC0", VA = "0x2A63BC0", Slot = "5")]
		public void Release(int typeHash, object obj)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2A63BC4", Offset = "0x2A63BC4", VA = "0x2A63BC4")]
		public DefaultAllocationStrategy()
		{
		}
	}
}
