using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000062")]
	public class DescribeIdentityPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeIdentityPoolResponseUnmarshaller _instance;

		[Token(Token = "0x170000B1")]
		public static DescribeIdentityPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1081DE8", Offset = "0x1081DE8", VA = "0x1081DE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1080B34", Offset = "0x1080B34", VA = "0x1080B34", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1081688", Offset = "0x1081688", VA = "0x1081688", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1081D84", Offset = "0x1081D84", VA = "0x1081D84")]
		internal static DescribeIdentityPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1081E4C", Offset = "0x1081E4C", VA = "0x1081E4C")]
		public DescribeIdentityPoolResponseUnmarshaller()
		{
		}
	}
}
