using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Exceptions
{
	[Token(Token = "0x2000014")]
	public class UnknownResourceProviderException : ResourceManagerException
	{
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D78", Offset = "0x1B7D78")]
		private IResourceLocation Location__BackingField;

		[Token(Token = "0x1700001D")]
		public IResourceLocation Location
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2A71AB0", Offset = "0x2A71AB0", VA = "0x2A71AB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8424", Offset = "0x1B8424")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2A71AB8", Offset = "0x2A71AB8", VA = "0x2A71AB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8434", Offset = "0x1B8434")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public override string Message
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2A71D20", Offset = "0x2A71D20", VA = "0x2A71D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2A6DB78", Offset = "0x2A6DB78", VA = "0x2A6DB78")]
		public UnknownResourceProviderException(IResourceLocation location)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2A71AC0", Offset = "0x2A71AC0", VA = "0x2A71AC0")]
		public UnknownResourceProviderException()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2A71B3C", Offset = "0x2A71B3C", VA = "0x2A71B3C")]
		public UnknownResourceProviderException(string message)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2A71BC8", Offset = "0x2A71BC8", VA = "0x2A71BC8")]
		public UnknownResourceProviderException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2A71C6C", Offset = "0x2A71C6C", VA = "0x2A71C6C")]
		protected UnknownResourceProviderException(SerializationInfo message, StreamingContext context)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2A71F58", Offset = "0x2A71F58", VA = "0x2A71F58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
