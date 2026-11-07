using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000167")]
	public class AdminDeleteUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x0")]
		private static AdminDeleteUserResponseUnmarshaller _instance;

		[Token(Token = "0x17000307")]
		public static AdminDeleteUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x10A3EDC", Offset = "0x10A3EDC", VA = "0x10A3EDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x10A3648", Offset = "0x10A3648", VA = "0x10A3648", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x10A36A0", Offset = "0x10A36A0", VA = "0x10A36A0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x10A3E78", Offset = "0x10A3E78", VA = "0x10A3E78")]
		internal static AdminDeleteUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x10A3F40", Offset = "0x10A3F40", VA = "0x10A3F40")]
		public AdminDeleteUserResponseUnmarshaller()
		{
		}
	}
}
