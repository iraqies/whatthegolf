using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Exceptions
{
	[Token(Token = "0x2000013")]
	public class ResourceManagerException : Exception
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2A703A4", Offset = "0x2A703A4", VA = "0x2A703A4")]
		public ResourceManagerException()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2A70420", Offset = "0x2A70420", VA = "0x2A70420")]
		public ResourceManagerException(string message)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2A704AC", Offset = "0x2A704AC", VA = "0x2A704AC")]
		public ResourceManagerException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2A70550", Offset = "0x2A70550", VA = "0x2A70550")]
		protected ResourceManagerException(SerializationInfo message, StreamingContext context)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2A70604", Offset = "0x2A70604", VA = "0x2A70604", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
