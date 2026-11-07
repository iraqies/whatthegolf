using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006E")]
	public class GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x0")]
		private static GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x170000BD")]
		public static GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x108ABE4", Offset = "0x108ABE4", VA = "0x108ABE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x108A0C4", Offset = "0x108A0C4", VA = "0x108A0C4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x108A2F4", Offset = "0x108A2F4", VA = "0x108A2F4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x108AB80", Offset = "0x108AB80", VA = "0x108AB80")]
		internal static GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x108AC48", Offset = "0x108AC48", VA = "0x108AC48")]
		public GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller()
		{
		}
	}
}
