using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000045")]
	public class GetSessionTokenResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x0")]
		private static GetSessionTokenResponseUnmarshaller _instance;

		[Token(Token = "0x17000066")]
		public static GetSessionTokenResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x12E3944", Offset = "0x12E3944", VA = "0x12E3944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x12E3164", Offset = "0x12E3164", VA = "0x12E3164", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x12E3374", Offset = "0x12E3374", VA = "0x12E3374")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, GetSessionTokenResponse response)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x12E3504", Offset = "0x12E3504", VA = "0x12E3504", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x12E38E0", Offset = "0x12E38E0", VA = "0x12E38E0")]
		internal static GetSessionTokenResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x12E39A8", Offset = "0x12E39A8", VA = "0x12E39A8")]
		public GetSessionTokenResponseUnmarshaller()
		{
		}
	}
}
