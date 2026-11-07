using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000197")]
	public class AssociateSoftwareTokenResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x0")]
		private static AssociateSoftwareTokenResponseUnmarshaller _instance;

		[Token(Token = "0x17000335")]
		public static AssociateSoftwareTokenResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0x10DE170", Offset = "0x10DE170", VA = "0x10DE170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x10DD7D0", Offset = "0x10DD7D0", VA = "0x10DD7D0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x10DDA00", Offset = "0x10DDA00", VA = "0x10DDA00", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x10DE10C", Offset = "0x10DE10C", VA = "0x10DE10C")]
		internal static AssociateSoftwareTokenResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x10DE1D4", Offset = "0x10DE1D4", VA = "0x10DE1D4")]
		public AssociateSoftwareTokenResponseUnmarshaller()
		{
		}
	}
}
