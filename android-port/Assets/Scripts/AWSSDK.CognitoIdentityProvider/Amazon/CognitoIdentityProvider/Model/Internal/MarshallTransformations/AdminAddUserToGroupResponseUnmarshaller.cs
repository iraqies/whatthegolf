using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200015D")]
	public class AdminAddUserToGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x0")]
		private static AdminAddUserToGroupResponseUnmarshaller _instance;

		[Token(Token = "0x170002FE")]
		public static AdminAddUserToGroupResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x109C108", Offset = "0x109C108", VA = "0x109C108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x109B874", Offset = "0x109B874", VA = "0x109B874", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x109B8CC", Offset = "0x109B8CC", VA = "0x109B8CC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x109C0A4", Offset = "0x109C0A4", VA = "0x109C0A4")]
		internal static AdminAddUserToGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x109C16C", Offset = "0x109C16C", VA = "0x109C16C")]
		public AdminAddUserToGroupResponseUnmarshaller()
		{
		}
	}
}
