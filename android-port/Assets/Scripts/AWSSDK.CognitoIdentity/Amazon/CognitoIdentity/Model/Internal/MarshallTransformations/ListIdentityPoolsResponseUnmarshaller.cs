using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007A")]
	public class ListIdentityPoolsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x0")]
		private static ListIdentityPoolsResponseUnmarshaller _instance;

		[Token(Token = "0x170000C9")]
		public static ListIdentityPoolsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1090C24", Offset = "0x1090C24", VA = "0x1090C24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x10901C8", Offset = "0x10901C8", VA = "0x10901C8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x10904C4", Offset = "0x10904C4", VA = "0x10904C4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1090BC0", Offset = "0x1090BC0", VA = "0x1090BC0")]
		internal static ListIdentityPoolsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1090C88", Offset = "0x1090C88", VA = "0x1090C88")]
		public ListIdentityPoolsResponseUnmarshaller()
		{
		}
	}
}
