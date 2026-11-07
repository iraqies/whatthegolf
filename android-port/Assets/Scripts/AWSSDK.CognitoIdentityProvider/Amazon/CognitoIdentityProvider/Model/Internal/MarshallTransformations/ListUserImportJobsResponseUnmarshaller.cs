using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200021E")]
	public class ListUserImportJobsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x0")]
		private static ListUserImportJobsResponseUnmarshaller _instance;

		[Token(Token = "0x170003B2")]
		public static ListUserImportJobsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010DE")]
			[Address(RVA = "0x11362D8", Offset = "0x11362D8", VA = "0x11362D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x1135874", Offset = "0x1135874", VA = "0x1135874", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x1135B70", Offset = "0x1135B70", VA = "0x1135B70", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x1136274", Offset = "0x1136274", VA = "0x1136274")]
		internal static ListUserImportJobsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x113633C", Offset = "0x113633C", VA = "0x113633C")]
		public ListUserImportJobsResponseUnmarshaller()
		{
		}
	}
}
