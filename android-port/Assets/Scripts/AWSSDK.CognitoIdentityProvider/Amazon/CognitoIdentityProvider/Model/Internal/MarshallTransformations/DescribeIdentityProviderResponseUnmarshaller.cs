using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001CF")]
	public class DescribeIdentityProviderResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeIdentityProviderResponseUnmarshaller _instance;

		[Token(Token = "0x17000368")]
		public static DescribeIdentityProviderResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F2B")]
			[Address(RVA = "0x110619C", Offset = "0x110619C", VA = "0x110619C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x11058A0", Offset = "0x11058A0", VA = "0x11058A0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x1105A2C", Offset = "0x1105A2C", VA = "0x1105A2C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x1106138", Offset = "0x1106138", VA = "0x1106138")]
		internal static DescribeIdentityProviderResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x1106200", Offset = "0x1106200", VA = "0x1106200")]
		public DescribeIdentityProviderResponseUnmarshaller()
		{
		}
	}
}
