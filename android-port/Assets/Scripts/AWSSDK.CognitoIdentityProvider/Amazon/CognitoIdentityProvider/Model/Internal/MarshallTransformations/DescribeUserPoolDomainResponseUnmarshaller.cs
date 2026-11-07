using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001D9")]
	public class DescribeUserPoolDomainResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeUserPoolDomainResponseUnmarshaller _instance;

		[Token(Token = "0x17000372")]
		public static DescribeUserPoolDomainResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x110D084", Offset = "0x110D084", VA = "0x110D084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x110C21C", Offset = "0x110C21C", VA = "0x110C21C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x110C9E0", Offset = "0x110C9E0", VA = "0x110C9E0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x110D020", Offset = "0x110D020", VA = "0x110D020")]
		internal static DescribeUserPoolDomainResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x110D0E8", Offset = "0x110D0E8", VA = "0x110D0E8")]
		public DescribeUserPoolDomainResponseUnmarshaller()
		{
		}
	}
}
