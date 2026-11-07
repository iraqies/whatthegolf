using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000222")]
	public class ListUserPoolsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x0")]
		private static ListUserPoolsResponseUnmarshaller _instance;

		[Token(Token = "0x170003B6")]
		public static ListUserPoolsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010F6")]
			[Address(RVA = "0x1139544", Offset = "0x1139544", VA = "0x1139544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x1138BA8", Offset = "0x1138BA8", VA = "0x1138BA8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x1138EA4", Offset = "0x1138EA4", VA = "0x1138EA4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x11394E0", Offset = "0x11394E0", VA = "0x11394E0")]
		internal static ListUserPoolsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010F7")]
		[Address(RVA = "0x11395A8", Offset = "0x11395A8", VA = "0x11395A8")]
		public ListUserPoolsResponseUnmarshaller()
		{
		}
	}
}
