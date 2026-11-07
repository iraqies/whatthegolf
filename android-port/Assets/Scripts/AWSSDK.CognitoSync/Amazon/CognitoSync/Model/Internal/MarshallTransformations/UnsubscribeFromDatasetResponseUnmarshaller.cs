using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000076")]
	public class UnsubscribeFromDatasetResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x0")]
		private static UnsubscribeFromDatasetResponseUnmarshaller _instance;

		[Token(Token = "0x170000AC")]
		public static UnsubscribeFromDatasetResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x11ACB80", Offset = "0x11ACB80", VA = "0x11ACB80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x11AC304", Offset = "0x11AC304", VA = "0x11AC304", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x11AC35C", Offset = "0x11AC35C", VA = "0x11AC35C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x11ACB1C", Offset = "0x11ACB1C", VA = "0x11ACB1C")]
		internal static UnsubscribeFromDatasetResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x11ACBE4", Offset = "0x11ACBE4", VA = "0x11ACBE4")]
		public UnsubscribeFromDatasetResponseUnmarshaller()
		{
		}
	}
}
