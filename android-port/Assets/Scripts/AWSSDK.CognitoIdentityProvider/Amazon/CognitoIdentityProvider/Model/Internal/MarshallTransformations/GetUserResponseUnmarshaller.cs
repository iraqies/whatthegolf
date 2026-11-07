using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001FE")]
	public class GetUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x0")]
		private static GetUserResponseUnmarshaller _instance;

		[Token(Token = "0x17000394")]
		public static GetUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001032")]
			[Address(RVA = "0x1125E7C", Offset = "0x1125E7C", VA = "0x1125E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600102F")]
		[Address(RVA = "0x1124F48", Offset = "0x1124F48", VA = "0x1124F48", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001030")]
		[Address(RVA = "0x11254B0", Offset = "0x11254B0", VA = "0x11254B0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001031")]
		[Address(RVA = "0x1125E18", Offset = "0x1125E18", VA = "0x1125E18")]
		internal static GetUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001033")]
		[Address(RVA = "0x1125EE0", Offset = "0x1125EE0", VA = "0x1125EE0")]
		public GetUserResponseUnmarshaller()
		{
		}
	}
}
