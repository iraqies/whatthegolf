using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001C5")]
	public class DeleteUserAttributesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteUserAttributesResponseUnmarshaller _instance;

		[Token(Token = "0x1700035E")]
		public static DeleteUserAttributesResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0x10FF8F0", Offset = "0x10FF8F0", VA = "0x10FF8F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x10FEEC4", Offset = "0x10FEEC4", VA = "0x10FEEC4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x10FEF1C", Offset = "0x10FEF1C", VA = "0x10FEF1C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x10FF88C", Offset = "0x10FF88C", VA = "0x10FF88C")]
		internal static DeleteUserAttributesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x10FF954", Offset = "0x10FF954", VA = "0x10FF954")]
		public DeleteUserAttributesResponseUnmarshaller()
		{
		}
	}
}
