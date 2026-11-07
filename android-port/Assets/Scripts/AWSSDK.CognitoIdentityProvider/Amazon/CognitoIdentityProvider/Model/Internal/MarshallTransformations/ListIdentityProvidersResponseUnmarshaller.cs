using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000218")]
	public class ListIdentityProvidersResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x0")]
		private static ListIdentityProvidersResponseUnmarshaller _instance;

		[Token(Token = "0x170003AC")]
		public static ListIdentityProvidersResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010BA")]
			[Address(RVA = "0x1131AAC", Offset = "0x1131AAC", VA = "0x1131AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x1131048", Offset = "0x1131048", VA = "0x1131048", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x1131344", Offset = "0x1131344", VA = "0x1131344", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x1131A48", Offset = "0x1131A48", VA = "0x1131A48")]
		internal static ListIdentityProvidersResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x1131B10", Offset = "0x1131B10", VA = "0x1131B10")]
		public ListIdentityProvidersResponseUnmarshaller()
		{
		}
	}
}
