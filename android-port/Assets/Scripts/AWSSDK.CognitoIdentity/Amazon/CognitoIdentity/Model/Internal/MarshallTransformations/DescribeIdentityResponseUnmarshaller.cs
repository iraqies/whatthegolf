using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000064")]
	public class DescribeIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x170000B3")]
		public static DescribeIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1083878", Offset = "0x1083878", VA = "0x1083878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1082C2C", Offset = "0x1082C2C", VA = "0x1082C2C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1083118", Offset = "0x1083118", VA = "0x1083118", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1083814", Offset = "0x1083814", VA = "0x1083814")]
		internal static DescribeIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x10838DC", Offset = "0x10838DC", VA = "0x10838DC")]
		public DescribeIdentityResponseUnmarshaller()
		{
		}
	}
}
