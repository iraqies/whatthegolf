using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001D5")]
	public class DescribeUserImportJobResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeUserImportJobResponseUnmarshaller _instance;

		[Token(Token = "0x1700036E")]
		public static DescribeUserImportJobResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x110A18C", Offset = "0x110A18C", VA = "0x110A18C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x1109890", Offset = "0x1109890", VA = "0x1109890", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x1109A1C", Offset = "0x1109A1C", VA = "0x1109A1C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x110A128", Offset = "0x110A128", VA = "0x110A128")]
		internal static DescribeUserImportJobResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x110A1F0", Offset = "0x110A1F0", VA = "0x110A1F0")]
		public DescribeUserImportJobResponseUnmarshaller()
		{
		}
	}
}
