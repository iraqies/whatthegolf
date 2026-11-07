using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001EE")]
	public class GetCSVHeaderResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x0")]
		private static GetCSVHeaderResponseUnmarshaller _instance;

		[Token(Token = "0x17000384")]
		public static GetCSVHeaderResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000FD2")]
			[Address(RVA = "0x1119020", Offset = "0x1119020", VA = "0x1119020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x11185CC", Offset = "0x11185CC", VA = "0x11185CC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x11188B8", Offset = "0x11188B8", VA = "0x11188B8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x1118FBC", Offset = "0x1118FBC", VA = "0x1118FBC")]
		internal static GetCSVHeaderResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x1119084", Offset = "0x1119084", VA = "0x1119084")]
		public GetCSVHeaderResponseUnmarshaller()
		{
		}
	}
}
