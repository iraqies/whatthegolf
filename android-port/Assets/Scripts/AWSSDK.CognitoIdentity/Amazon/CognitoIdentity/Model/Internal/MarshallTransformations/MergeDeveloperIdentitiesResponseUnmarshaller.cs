using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000082")]
	public class MergeDeveloperIdentitiesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x0")]
		private static MergeDeveloperIdentitiesResponseUnmarshaller _instance;

		[Token(Token = "0x170000D0")]
		public static MergeDeveloperIdentitiesResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1096100", Offset = "0x1096100", VA = "0x1096100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x109574C", Offset = "0x109574C", VA = "0x109574C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x10958D8", Offset = "0x10958D8", VA = "0x10958D8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x109609C", Offset = "0x109609C", VA = "0x109609C")]
		internal static MergeDeveloperIdentitiesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1096164", Offset = "0x1096164", VA = "0x1096164")]
		public MergeDeveloperIdentitiesResponseUnmarshaller()
		{
		}
	}
}
