using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000266")]
	public class TagResourceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x0")]
		private static TagResourceResponseUnmarshaller _instance;

		[Token(Token = "0x170003E9")]
		public static TagResourceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001242")]
			[Address(RVA = "0x115C7E0", Offset = "0x115C7E0", VA = "0x115C7E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600123F")]
		[Address(RVA = "0x115C01C", Offset = "0x115C01C", VA = "0x115C01C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001240")]
		[Address(RVA = "0x115C074", Offset = "0x115C074", VA = "0x115C074", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001241")]
		[Address(RVA = "0x115C77C", Offset = "0x115C77C", VA = "0x115C77C")]
		internal static TagResourceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001243")]
		[Address(RVA = "0x115C844", Offset = "0x115C844", VA = "0x115C844")]
		public TagResourceResponseUnmarshaller()
		{
		}
	}
}
