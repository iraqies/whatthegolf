using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000220")]
	public class ListUserPoolClientsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x0")]
		private static ListUserPoolClientsResponseUnmarshaller _instance;

		[Token(Token = "0x170003B4")]
		public static ListUserPoolClientsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x1137D9C", Offset = "0x1137D9C", VA = "0x1137D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x1137170", Offset = "0x1137170", VA = "0x1137170", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x113746C", Offset = "0x113746C", VA = "0x113746C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x1137D38", Offset = "0x1137D38", VA = "0x1137D38")]
		internal static ListUserPoolClientsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x1137E00", Offset = "0x1137E00", VA = "0x1137E00")]
		public ListUserPoolClientsResponseUnmarshaller()
		{
		}
	}
}
