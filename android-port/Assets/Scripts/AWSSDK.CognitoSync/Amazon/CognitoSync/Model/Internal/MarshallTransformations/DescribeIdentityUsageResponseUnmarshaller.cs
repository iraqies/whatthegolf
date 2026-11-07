using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200004F")]
	public class DescribeIdentityUsageResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeIdentityUsageResponseUnmarshaller _instance;

		[Token(Token = "0x17000087")]
		public static DescribeIdentityUsageResponseUnmarshaller Instance
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x1198D04", Offset = "0x1198D04", VA = "0x1198D04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1197EB0", Offset = "0x1197EB0", VA = "0x1197EB0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x11985A8", Offset = "0x11985A8", VA = "0x11985A8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1198CA0", Offset = "0x1198CA0", VA = "0x1198CA0")]
		internal static DescribeIdentityUsageResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1198D68", Offset = "0x1198D68", VA = "0x1198D68")]
		public DescribeIdentityUsageResponseUnmarshaller()
		{
		}
	}
}
