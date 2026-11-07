using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001F2")]
	public class GetGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x0")]
		private static GetGroupResponseUnmarshaller _instance;

		[Token(Token = "0x17000388")]
		public static GetGroupResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x111C3B4", Offset = "0x111C3B4", VA = "0x111C3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x111B460", Offset = "0x111B460", VA = "0x111B460", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x111BC4C", Offset = "0x111BC4C", VA = "0x111BC4C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x111C350", Offset = "0x111C350", VA = "0x111C350")]
		internal static GetGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x111C418", Offset = "0x111C418", VA = "0x111C418")]
		public GetGroupResponseUnmarshaller()
		{
		}
	}
}
