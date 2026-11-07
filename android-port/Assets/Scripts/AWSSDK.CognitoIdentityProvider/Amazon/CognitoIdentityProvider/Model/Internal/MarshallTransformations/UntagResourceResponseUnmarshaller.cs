using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200026E")]
	public class UntagResourceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x0")]
		private static UntagResourceResponseUnmarshaller _instance;

		[Token(Token = "0x170003F1")]
		public static UntagResourceResponseUnmarshaller Instance
		{
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x115F1CC", Offset = "0x115F1CC", VA = "0x115F1CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001269")]
		[Address(RVA = "0x115EA08", Offset = "0x115EA08", VA = "0x115EA08", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600126A")]
		[Address(RVA = "0x115EA60", Offset = "0x115EA60", VA = "0x115EA60", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600126B")]
		[Address(RVA = "0x115F168", Offset = "0x115F168", VA = "0x115F168")]
		internal static UntagResourceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600126D")]
		[Address(RVA = "0x115F230", Offset = "0x115F230", VA = "0x115F230")]
		public UntagResourceResponseUnmarshaller()
		{
		}
	}
}
