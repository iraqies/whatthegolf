using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007E")]
	public class LookupDeveloperIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x0")]
		private static LookupDeveloperIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x170000CD")]
		public static LookupDeveloperIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1093DDC", Offset = "0x1093DDC", VA = "0x1093DDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1093220", Offset = "0x1093220", VA = "0x1093220", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x10935B4", Offset = "0x10935B4", VA = "0x10935B4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1093D78", Offset = "0x1093D78", VA = "0x1093D78")]
		internal static LookupDeveloperIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1093E40", Offset = "0x1093E40", VA = "0x1093E40")]
		public LookupDeveloperIdentityResponseUnmarshaller()
		{
		}
	}
}
