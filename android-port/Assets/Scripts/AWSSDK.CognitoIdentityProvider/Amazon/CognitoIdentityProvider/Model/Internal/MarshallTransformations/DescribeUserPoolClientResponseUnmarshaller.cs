using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001D7")]
	public class DescribeUserPoolClientResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeUserPoolClientResponseUnmarshaller _instance;

		[Token(Token = "0x17000370")]
		public static DescribeUserPoolClientResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x110B698", Offset = "0x110B698", VA = "0x110B698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x110AD9C", Offset = "0x110AD9C", VA = "0x110AD9C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x110AF28", Offset = "0x110AF28", VA = "0x110AF28", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x110B634", Offset = "0x110B634", VA = "0x110B634")]
		internal static DescribeUserPoolClientResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x110B6FC", Offset = "0x110B6FC", VA = "0x110B6FC")]
		public DescribeUserPoolClientResponseUnmarshaller()
		{
		}
	}
}
