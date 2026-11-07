using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000078")]
	public class ListIdentitiesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x0")]
		private static ListIdentitiesResponseUnmarshaller _instance;

		[Token(Token = "0x170000C7")]
		public static ListIdentitiesResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x108F3BC", Offset = "0x108F3BC", VA = "0x108F3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x108E8B0", Offset = "0x108E8B0", VA = "0x108E8B0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x108EC5C", Offset = "0x108EC5C", VA = "0x108EC5C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x108F358", Offset = "0x108F358", VA = "0x108F358")]
		internal static ListIdentitiesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x108F420", Offset = "0x108F420", VA = "0x108F420")]
		public ListIdentitiesResponseUnmarshaller()
		{
		}
	}
}
