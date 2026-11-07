using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200024F")]
	public class SetUserMFAPreferenceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x0")]
		private static SetUserMFAPreferenceResponseUnmarshaller _instance;

		[Token(Token = "0x170003D8")]
		public static SetUserMFAPreferenceResponseUnmarshaller Instance
		{
			[Token(Token = "0x60011CF")]
			[Address(RVA = "0x114FF48", Offset = "0x114FF48", VA = "0x114FF48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x114F5F4", Offset = "0x114F5F4", VA = "0x114F5F4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x114F64C", Offset = "0x114F64C", VA = "0x114F64C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x114FEE4", Offset = "0x114FEE4", VA = "0x114FEE4")]
		internal static SetUserMFAPreferenceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x114FFAC", Offset = "0x114FFAC", VA = "0x114FFAC")]
		public SetUserMFAPreferenceResponseUnmarshaller()
		{
		}
	}
}
