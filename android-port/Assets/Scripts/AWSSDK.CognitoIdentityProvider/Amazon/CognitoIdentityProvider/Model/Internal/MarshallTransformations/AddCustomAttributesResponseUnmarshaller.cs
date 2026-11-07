using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200015B")]
	public class AddCustomAttributesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x0")]
		private static AddCustomAttributesResponseUnmarshaller _instance;

		[Token(Token = "0x170002FC")]
		public static AddCustomAttributesResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x109ABF8", Offset = "0x109ABF8", VA = "0x109ABF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x109A364", Offset = "0x109A364", VA = "0x109A364", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x109A3BC", Offset = "0x109A3BC", VA = "0x109A3BC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x109AB94", Offset = "0x109AB94", VA = "0x109AB94")]
		internal static AddCustomAttributesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x109AC5C", Offset = "0x109AC5C", VA = "0x109AC5C")]
		public AddCustomAttributesResponseUnmarshaller()
		{
		}
	}
}
