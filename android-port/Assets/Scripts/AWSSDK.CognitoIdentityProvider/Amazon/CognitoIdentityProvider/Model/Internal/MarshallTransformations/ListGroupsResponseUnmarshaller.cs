using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000216")]
	public class ListGroupsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x0")]
		private static ListGroupsResponseUnmarshaller _instance;

		[Token(Token = "0x170003AA")]
		public static ListGroupsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010AE")]
			[Address(RVA = "0x11301B0", Offset = "0x11301B0", VA = "0x11301B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x112F74C", Offset = "0x112F74C", VA = "0x112F74C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x112FA48", Offset = "0x112FA48", VA = "0x112FA48", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x113014C", Offset = "0x113014C", VA = "0x113014C")]
		internal static ListGroupsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x1130214", Offset = "0x1130214", VA = "0x1130214")]
		public ListGroupsResponseUnmarshaller()
		{
		}
	}
}
