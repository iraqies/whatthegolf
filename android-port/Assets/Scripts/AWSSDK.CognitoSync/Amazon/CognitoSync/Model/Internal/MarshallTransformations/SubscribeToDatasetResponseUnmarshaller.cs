using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000073")]
	public class SubscribeToDatasetResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x0")]
		private static SubscribeToDatasetResponseUnmarshaller _instance;

		[Token(Token = "0x170000A9")]
		public static SubscribeToDatasetResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x11AB730", Offset = "0x11AB730", VA = "0x11AB730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x11AAEB4", Offset = "0x11AAEB4", VA = "0x11AAEB4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x11AAF0C", Offset = "0x11AAF0C", VA = "0x11AAF0C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x11AB6CC", Offset = "0x11AB6CC", VA = "0x11AB6CC")]
		internal static SubscribeToDatasetResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x11AB794", Offset = "0x11AB794", VA = "0x11AB794")]
		public SubscribeToDatasetResponseUnmarshaller()
		{
		}
	}
}
