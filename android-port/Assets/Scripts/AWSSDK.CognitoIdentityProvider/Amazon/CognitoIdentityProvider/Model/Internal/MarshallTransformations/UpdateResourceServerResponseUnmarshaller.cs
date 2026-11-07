using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000278")]
	public class UpdateResourceServerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateResourceServerResponseUnmarshaller _instance;

		[Token(Token = "0x170003FB")]
		public static UpdateResourceServerResponseUnmarshaller Instance
		{
			[Token(Token = "0x60012A8")]
			[Address(RVA = "0x1167374", Offset = "0x1167374", VA = "0x1167374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x1166A7C", Offset = "0x1166A7C", VA = "0x1166A7C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x1166C08", Offset = "0x1166C08", VA = "0x1166C08", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x1167310", Offset = "0x1167310", VA = "0x1167310")]
		internal static UpdateResourceServerResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x11673D8", Offset = "0x11673D8", VA = "0x11673D8")]
		public UpdateResourceServerResponseUnmarshaller()
		{
		}
	}
}
