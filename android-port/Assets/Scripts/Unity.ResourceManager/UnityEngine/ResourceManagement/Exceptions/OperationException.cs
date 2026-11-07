using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Exceptions
{
	[Token(Token = "0x2000015")]
	public class OperationException : Exception
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2A67CF0", Offset = "0x2A67CF0", VA = "0x2A67CF0")]
		public OperationException(string message, [Optional] Exception innerException)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2A6AED0", Offset = "0x2A6AED0", VA = "0x2A6AED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
