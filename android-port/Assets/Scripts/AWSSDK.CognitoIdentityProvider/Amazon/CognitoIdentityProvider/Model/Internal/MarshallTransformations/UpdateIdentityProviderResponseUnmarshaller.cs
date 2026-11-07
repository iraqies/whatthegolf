using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000276")]
	public class UpdateIdentityProviderResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateIdentityProviderResponseUnmarshaller _instance;

		[Token(Token = "0x170003F9")]
		public static UpdateIdentityProviderResponseUnmarshaller Instance
		{
			[Token(Token = "0x600129C")]
			[Address(RVA = "0x1165A8C", Offset = "0x1165A8C", VA = "0x1165A8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001299")]
		[Address(RVA = "0x11650CC", Offset = "0x11650CC", VA = "0x11650CC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600129A")]
		[Address(RVA = "0x1165258", Offset = "0x1165258", VA = "0x1165258", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600129B")]
		[Address(RVA = "0x1165A28", Offset = "0x1165A28", VA = "0x1165A28")]
		internal static UpdateIdentityProviderResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600129D")]
		[Address(RVA = "0x1165AF0", Offset = "0x1165AF0", VA = "0x1165AF0")]
		public UpdateIdentityProviderResponseUnmarshaller()
		{
		}
	}
}
