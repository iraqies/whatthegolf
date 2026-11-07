using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001D3")]
	public class DescribeRiskConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeRiskConfigurationResponseUnmarshaller _instance;

		[Token(Token = "0x1700036C")]
		public static DescribeRiskConfigurationResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F43")]
			[Address(RVA = "0x1108C80", Offset = "0x1108C80", VA = "0x1108C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x11082B8", Offset = "0x11082B8", VA = "0x11082B8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x1108444", Offset = "0x1108444", VA = "0x1108444", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x1108C1C", Offset = "0x1108C1C", VA = "0x1108C1C")]
		internal static DescribeRiskConfigurationResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x1108CE4", Offset = "0x1108CE4", VA = "0x1108CE4")]
		public DescribeRiskConfigurationResponseUnmarshaller()
		{
		}
	}
}
