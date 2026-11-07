using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200004D")]
	public class DescribeIdentityPoolUsageResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeIdentityPoolUsageResponseUnmarshaller _instance;

		[Token(Token = "0x17000085")]
		public static DescribeIdentityPoolUsageResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1197660", Offset = "0x1197660", VA = "0x1197660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x11968F8", Offset = "0x11968F8", VA = "0x11968F8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1196F04", Offset = "0x1196F04", VA = "0x1196F04", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x11975FC", Offset = "0x11975FC", VA = "0x11975FC")]
		internal static DescribeIdentityPoolUsageResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x11976C4", Offset = "0x11976C4", VA = "0x11976C4")]
		public DescribeIdentityPoolUsageResponseUnmarshaller()
		{
		}
	}
}
