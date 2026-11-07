using System;
using System.Net;
using System.Text;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x200009E")]
	public class AmazonUnmarshallingException : AmazonServiceException
	{
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26798", Offset = "0x26798")]
		private string LastKnownLocation__BackingField;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x267A8", Offset = "0x267A8")]
		private string ResponseBody__BackingField;

		[Token(Token = "0x1700016C")]
		public string LastKnownLocation
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x11CD510", Offset = "0x11CD510", VA = "0x11CD510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C0C", Offset = "0x28C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x11CD518", Offset = "0x11CD518", VA = "0x11CD518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C1C", Offset = "0x28C1C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public string ResponseBody
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x11CD520", Offset = "0x11CD520", VA = "0x11CD520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C2C", Offset = "0x28C2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x11CD528", Offset = "0x11CD528", VA = "0x11CD528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28C3C", Offset = "0x28C3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public override string Message
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x11CD530", Offset = "0x11CD530", VA = "0x11CD530", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x11C9640", Offset = "0x11C9640", VA = "0x11C9640")]
		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, Exception innerException)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x11C97E4", Offset = "0x11C97E4", VA = "0x11C97E4")]
		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, Exception innerException)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x11C98E0", Offset = "0x11C98E0", VA = "0x11C98E0")]
		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, string message, Exception innerException)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x11CD364", Offset = "0x11CD364", VA = "0x11CD364")]
		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, Exception innerException, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x11CD434", Offset = "0x11CD434", VA = "0x11CD434")]
		public AmazonUnmarshallingException(string requestId, string lastKnownLocation, string responseBody, Exception innerException, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x11CD704", Offset = "0x11CD704", VA = "0x11CD704")]
		private static void AppendFormat(StringBuilder sb, string format, string value)
		{
		}
	}
}
