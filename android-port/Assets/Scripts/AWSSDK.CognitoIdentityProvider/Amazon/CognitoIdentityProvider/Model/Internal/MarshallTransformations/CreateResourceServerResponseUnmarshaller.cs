using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001B3")]
	public class CreateResourceServerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x0")]
		private static CreateResourceServerResponseUnmarshaller _instance;

		[Token(Token = "0x1700034D")]
		public static CreateResourceServerResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E87")]
			[Address(RVA = "0x10F07E4", Offset = "0x10F07E4", VA = "0x10F07E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x10EFE1C", Offset = "0x10EFE1C", VA = "0x10EFE1C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x10EFFA8", Offset = "0x10EFFA8", VA = "0x10EFFA8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x10F0780", Offset = "0x10F0780", VA = "0x10F0780")]
		internal static CreateResourceServerResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x10F0848", Offset = "0x10F0848", VA = "0x10F0848")]
		public CreateResourceServerResponseUnmarshaller()
		{
		}
	}
}
