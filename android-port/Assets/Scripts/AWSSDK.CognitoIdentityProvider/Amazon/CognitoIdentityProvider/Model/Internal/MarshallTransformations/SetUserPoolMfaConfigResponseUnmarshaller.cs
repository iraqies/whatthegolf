using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000251")]
	public class SetUserPoolMfaConfigResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x0")]
		private static SetUserPoolMfaConfigResponseUnmarshaller _instance;

		[Token(Token = "0x170003DA")]
		public static SetUserPoolMfaConfigResponseUnmarshaller Instance
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x11521AC", Offset = "0x11521AC", VA = "0x11521AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x115110C", Offset = "0x115110C", VA = "0x115110C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x11518AC", Offset = "0x11518AC", VA = "0x11518AC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x1152148", Offset = "0x1152148", VA = "0x1152148")]
		internal static SetUserPoolMfaConfigResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x1152210", Offset = "0x1152210", VA = "0x1152210")]
		public SetUserPoolMfaConfigResponseUnmarshaller()
		{
		}
	}
}
