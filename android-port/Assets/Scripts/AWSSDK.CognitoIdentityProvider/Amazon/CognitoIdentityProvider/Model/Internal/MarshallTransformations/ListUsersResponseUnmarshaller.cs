using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000226")]
	public class ListUsersResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x0")]
		private static ListUsersResponseUnmarshaller _instance;

		[Token(Token = "0x170003BA")]
		public static ListUsersResponseUnmarshaller Instance
		{
			[Token(Token = "0x600110E")]
			[Address(RVA = "0x113CB24", Offset = "0x113CB24", VA = "0x113CB24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600110B")]
		[Address(RVA = "0x113C0C0", Offset = "0x113C0C0", VA = "0x113C0C0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600110C")]
		[Address(RVA = "0x113C3BC", Offset = "0x113C3BC", VA = "0x113C3BC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600110D")]
		[Address(RVA = "0x113CAC0", Offset = "0x113CAC0", VA = "0x113CAC0")]
		internal static ListUsersResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600110F")]
		[Address(RVA = "0x113CB88", Offset = "0x113CB88", VA = "0x113CB88")]
		public ListUsersResponseUnmarshaller()
		{
		}
	}
}
