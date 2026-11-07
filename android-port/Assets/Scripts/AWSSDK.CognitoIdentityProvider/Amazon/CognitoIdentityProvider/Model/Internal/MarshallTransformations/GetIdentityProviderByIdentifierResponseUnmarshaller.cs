using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001F4")]
	public class GetIdentityProviderByIdentifierResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x0")]
		private static GetIdentityProviderByIdentifierResponseUnmarshaller _instance;

		[Token(Token = "0x1700038A")]
		public static GetIdentityProviderByIdentifierResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000FF6")]
			[Address(RVA = "0x111E108", Offset = "0x111E108", VA = "0x111E108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x111CFC4", Offset = "0x111CFC4", VA = "0x111CFC4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x111D9A0", Offset = "0x111D9A0", VA = "0x111D9A0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x111E0A4", Offset = "0x111E0A4", VA = "0x111E0A4")]
		internal static GetIdentityProviderByIdentifierResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x111E16C", Offset = "0x111E16C", VA = "0x111E16C")]
		public GetIdentityProviderByIdentifierResponseUnmarshaller()
		{
		}
	}
}
