using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000280")]
	public class UpdateUserPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateUserPoolResponseUnmarshaller _instance;

		[Token(Token = "0x17000403")]
		public static UpdateUserPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x60012D8")]
			[Address(RVA = "0x1172010", Offset = "0x1172010", VA = "0x1172010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x11711C4", Offset = "0x11711C4", VA = "0x11711C4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x117121C", Offset = "0x117121C", VA = "0x117121C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x1171FAC", Offset = "0x1171FAC", VA = "0x1171FAC")]
		internal static UpdateUserPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x1172074", Offset = "0x1172074", VA = "0x1172074")]
		public UpdateUserPoolResponseUnmarshaller()
		{
		}
	}
}
