using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000043")]
	public class GetFederationTokenResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x0")]
		private static GetFederationTokenResponseUnmarshaller _instance;

		[Token(Token = "0x17000064")]
		public static GetFederationTokenResponseUnmarshaller Instance
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x12E2670", Offset = "0x12E2670", VA = "0x12E2670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x12E1B24", Offset = "0x12E1B24", VA = "0x12E1B24", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x12E1D34", Offset = "0x12E1D34", VA = "0x12E1D34")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, GetFederationTokenResponse response)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x12E20A0", Offset = "0x12E20A0", VA = "0x12E20A0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x12E260C", Offset = "0x12E260C", VA = "0x12E260C")]
		internal static GetFederationTokenResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x12E26D4", Offset = "0x12E26D4", VA = "0x12E26D4")]
		public GetFederationTokenResponseUnmarshaller()
		{
		}
	}
}
