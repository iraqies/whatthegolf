using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000041")]
	public class GetCallerIdentityResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x0")]
		private static GetCallerIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x17000062")]
		public static GetCallerIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x12E0520", Offset = "0x12E0520", VA = "0x12E0520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x12DFD10", Offset = "0x12DFD10", VA = "0x12DFD10", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x12DFF20", Offset = "0x12DFF20", VA = "0x12DFF20")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, GetCallerIdentityResponse response)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x12E0204", Offset = "0x12E0204", VA = "0x12E0204", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x12E04BC", Offset = "0x12E04BC", VA = "0x12E04BC")]
		internal static GetCallerIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x12E0584", Offset = "0x12E0584", VA = "0x12E0584")]
		public GetCallerIdentityResponseUnmarshaller()
		{
		}
	}
}
