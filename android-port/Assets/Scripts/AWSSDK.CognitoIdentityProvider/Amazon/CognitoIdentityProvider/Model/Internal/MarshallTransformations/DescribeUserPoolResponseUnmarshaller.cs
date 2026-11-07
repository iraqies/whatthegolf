using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001DB")]
	public class DescribeUserPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeUserPoolResponseUnmarshaller _instance;

		[Token(Token = "0x17000374")]
		public static DescribeUserPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F73")]
			[Address(RVA = "0x110E5D0", Offset = "0x110E5D0", VA = "0x110E5D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x110DC08", Offset = "0x110DC08", VA = "0x110DC08", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x110DD94", Offset = "0x110DD94", VA = "0x110DD94", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x110E56C", Offset = "0x110E56C", VA = "0x110E56C")]
		internal static DescribeUserPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x110E634", Offset = "0x110E634", VA = "0x110E634")]
		public DescribeUserPoolResponseUnmarshaller()
		{
		}
	}
}
