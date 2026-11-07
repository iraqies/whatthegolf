using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001D1")]
	public class DescribeResourceServerResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeResourceServerResponseUnmarshaller _instance;

		[Token(Token = "0x1700036A")]
		public static DescribeResourceServerResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x11076A8", Offset = "0x11076A8", VA = "0x11076A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x1106DAC", Offset = "0x1106DAC", VA = "0x1106DAC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x1106F38", Offset = "0x1106F38", VA = "0x1106F38", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x1107644", Offset = "0x1107644", VA = "0x1107644")]
		internal static DescribeResourceServerResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x110770C", Offset = "0x110770C", VA = "0x110770C")]
		public DescribeResourceServerResponseUnmarshaller()
		{
		}
	}
}
