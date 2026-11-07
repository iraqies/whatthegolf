using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200017D")]
	public class AdminListUserAuthEventsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x0")]
		private static AdminListUserAuthEventsResponseUnmarshaller _instance;

		[Token(Token = "0x1700031D")]
		public static AdminListUserAuthEventsResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D61")]
			[Address(RVA = "0x10B6004", Offset = "0x10B6004", VA = "0x10B6004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x10B5400", Offset = "0x10B5400", VA = "0x10B5400", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x10B56FC", Offset = "0x10B56FC", VA = "0x10B56FC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x10B5FA0", Offset = "0x10B5FA0", VA = "0x10B5FA0")]
		internal static AdminListUserAuthEventsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x10B6068", Offset = "0x10B6068", VA = "0x10B6068")]
		public AdminListUserAuthEventsResponseUnmarshaller()
		{
		}
	}
}
