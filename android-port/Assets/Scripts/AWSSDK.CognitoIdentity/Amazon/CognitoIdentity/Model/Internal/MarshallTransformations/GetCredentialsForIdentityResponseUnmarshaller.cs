using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000068")]
	public class GetCredentialsForIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		private static GetCredentialsForIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x170000B7")]
		public static GetCredentialsForIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1085C50", Offset = "0x1085C50", VA = "0x1085C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1084F68", Offset = "0x1084F68", VA = "0x1084F68", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x10851B4", Offset = "0x10851B4", VA = "0x10851B4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1085BEC", Offset = "0x1085BEC", VA = "0x1085BEC")]
		internal static GetCredentialsForIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1085CB4", Offset = "0x1085CB4", VA = "0x1085CB4")]
		public GetCredentialsForIdentityResponseUnmarshaller()
		{
		}
	}
}
