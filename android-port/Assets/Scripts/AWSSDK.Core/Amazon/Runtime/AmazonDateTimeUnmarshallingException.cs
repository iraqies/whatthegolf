using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x2000099")]
	public class AmazonDateTimeUnmarshallingException : AmazonUnmarshallingException
	{
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26718", Offset = "0x26718")]
		private string InvalidDateTimeToken__BackingField;

		[Token(Token = "0x1700015E")]
		public string InvalidDateTimeToken
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x11C9560", Offset = "0x11C9560", VA = "0x11C9560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28AAC", Offset = "0x28AAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x11C9568", Offset = "0x11C9568", VA = "0x11C9568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28ABC", Offset = "0x28ABC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x11C9570", Offset = "0x11C9570", VA = "0x11C9570")]
		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string invalidDateTimeToken, Exception innerException)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x11C9708", Offset = "0x11C9708", VA = "0x11C9708")]
		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, Exception innerException)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x11C98B0", Offset = "0x11C98B0", VA = "0x11C98B0")]
		public AmazonDateTimeUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string invalidDateTimeToken, string message, Exception innerException)
		{
		}
	}
}
