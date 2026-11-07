using System;
using System.IO;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000222")]
	public abstract class JsonResponseUnmarshaller : ResponseUnmarshaller
	{
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x1235740", Offset = "0x1235740", VA = "0x1235740", Slot = "9")]
		public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
		{
			return null;
		}

		[Token(Token = "0x6001053")]
		[Address(RVA = "0x1235A4C", Offset = "0x1235A4C", VA = "0x1235A4C", Slot = "8")]
		public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001054")]
		public abstract AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext input);

		[Token(Token = "0x6001055")]
		public abstract AmazonServiceException UnmarshallException(JsonUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode);

		[Token(Token = "0x6001056")]
		[Address(RVA = "0x1235C14", Offset = "0x1235C14", VA = "0x1235C14", Slot = "10")]
		protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException)
		{
			return null;
		}

		[Token(Token = "0x6001057")]
		[Address(RVA = "0x1236048", Offset = "0x1236048", VA = "0x1236048", Slot = "11")]
		protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
		{
			return default;
		}

		[Token(Token = "0x6001058")]
		[Address(RVA = "0x1236140", Offset = "0x1236140", VA = "0x1236140")]
		protected JsonResponseUnmarshaller()
		{
		}
	}
}
