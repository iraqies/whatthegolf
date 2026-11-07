using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000165")]
	public class AdminDeleteUserAttributesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x0")]
		private static AdminDeleteUserAttributesResponseUnmarshaller _instance;

		[Token(Token = "0x17000305")]
		public static AdminDeleteUserAttributesResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x10A2A58", Offset = "0x10A2A58", VA = "0x10A2A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x10A21C4", Offset = "0x10A21C4", VA = "0x10A21C4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x10A221C", Offset = "0x10A221C", VA = "0x10A221C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x10A29F4", Offset = "0x10A29F4", VA = "0x10A29F4")]
		internal static AdminDeleteUserAttributesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x10A2ABC", Offset = "0x10A2ABC", VA = "0x10A2ABC")]
		public AdminDeleteUserAttributesResponseUnmarshaller()
		{
		}
	}
}
