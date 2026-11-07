using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000169")]
	public class AdminDisableProviderForUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x0")]
		private static AdminDisableProviderForUserResponseUnmarshaller _instance;

		[Token(Token = "0x17000309")]
		public static AdminDisableProviderForUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x10A549C", Offset = "0x10A549C", VA = "0x10A549C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x10A4B3C", Offset = "0x10A4B3C", VA = "0x10A4B3C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x10A4B94", Offset = "0x10A4B94", VA = "0x10A4B94", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x10A5438", Offset = "0x10A5438", VA = "0x10A5438")]
		internal static AdminDisableProviderForUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x10A5500", Offset = "0x10A5500", VA = "0x10A5500")]
		public AdminDisableProviderForUserResponseUnmarshaller()
		{
		}
	}
}
