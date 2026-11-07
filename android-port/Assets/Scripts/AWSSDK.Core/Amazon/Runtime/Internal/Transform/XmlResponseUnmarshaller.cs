using System;
using System.IO;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000220")]
	public abstract class XmlResponseUnmarshaller : ResponseUnmarshaller
	{
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x128337C", Offset = "0x128337C", VA = "0x128337C", Slot = "9")]
		public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
		{
			return null;
		}

		[Token(Token = "0x600104A")]
		[Address(RVA = "0x1283828", Offset = "0x1283828", VA = "0x1283828", Slot = "8")]
		public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600104B")]
		public abstract AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext input);

		[Token(Token = "0x600104C")]
		public abstract AmazonServiceException UnmarshallException(XmlUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode);

		[Token(Token = "0x600104D")]
		[Address(RVA = "0x1283928", Offset = "0x1283928", VA = "0x1283928", Slot = "10")]
		protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException)
		{
			return null;
		}

		[Token(Token = "0x600104E")]
		[Address(RVA = "0x1283B9C", Offset = "0x1283B9C", VA = "0x1283B9C")]
		protected XmlResponseUnmarshaller()
		{
		}
	}
}
