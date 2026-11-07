using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200004B")]
	public class DescribeDatasetResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeDatasetResponseUnmarshaller _instance;

		[Token(Token = "0x17000083")]
		public static DescribeDatasetResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x11961B4", Offset = "0x11961B4", VA = "0x11961B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x11958D0", Offset = "0x11958D0", VA = "0x11958D0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1195A58", Offset = "0x1195A58", VA = "0x1195A58", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1196150", Offset = "0x1196150", VA = "0x1196150")]
		internal static DescribeDatasetResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1196218", Offset = "0x1196218", VA = "0x1196218")]
		public DescribeDatasetResponseUnmarshaller()
		{
		}
	}
}
