using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000177")]
	public class AdminLinkProviderForUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x0")]
		private static AdminLinkProviderForUserResponseUnmarshaller _instance;

		[Token(Token = "0x17000317")]
		public static AdminLinkProviderForUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x10B1024", Offset = "0x10B1024", VA = "0x10B1024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x10B05F8", Offset = "0x10B05F8", VA = "0x10B05F8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x10B0650", Offset = "0x10B0650", VA = "0x10B0650", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x10B0FC0", Offset = "0x10B0FC0", VA = "0x10B0FC0")]
		internal static AdminLinkProviderForUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x10B1088", Offset = "0x10B1088", VA = "0x10B1088")]
		public AdminLinkProviderForUserResponseUnmarshaller()
		{
		}
	}
}
