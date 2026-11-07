using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000298")]
	public class VerifySoftwareTokenResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x0")]
		private static VerifySoftwareTokenResponseUnmarshaller _instance;

		[Token(Token = "0x17000416")]
		public static VerifySoftwareTokenResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001348")]
			[Address(RVA = "0x117CA28", Offset = "0x117CA28", VA = "0x117CA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001345")]
		[Address(RVA = "0x117BA94", Offset = "0x117BA94", VA = "0x117BA94", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001346")]
		[Address(RVA = "0x117BD08", Offset = "0x117BD08", VA = "0x117BD08", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001347")]
		[Address(RVA = "0x117C9C4", Offset = "0x117C9C4", VA = "0x117C9C4")]
		internal static VerifySoftwareTokenResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001349")]
		[Address(RVA = "0x117CA8C", Offset = "0x117CA8C", VA = "0x117CA8C")]
		public VerifySoftwareTokenResponseUnmarshaller()
		{
		}
	}
}
