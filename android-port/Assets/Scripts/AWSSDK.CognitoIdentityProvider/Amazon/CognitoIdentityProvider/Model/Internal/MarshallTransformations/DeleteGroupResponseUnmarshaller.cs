using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001BF")]
	public class DeleteGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteGroupResponseUnmarshaller _instance;

		[Token(Token = "0x17000358")]
		public static DeleteGroupResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000ECB")]
			[Address(RVA = "0x10FB7FC", Offset = "0x10FB7FC", VA = "0x10FB7FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x10FB034", Offset = "0x10FB034", VA = "0x10FB034", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x10FB08C", Offset = "0x10FB08C", VA = "0x10FB08C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x10FB798", Offset = "0x10FB798", VA = "0x10FB798")]
		internal static DeleteGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x10FB860", Offset = "0x10FB860", VA = "0x10FB860")]
		public DeleteGroupResponseUnmarshaller()
		{
		}
	}
}
