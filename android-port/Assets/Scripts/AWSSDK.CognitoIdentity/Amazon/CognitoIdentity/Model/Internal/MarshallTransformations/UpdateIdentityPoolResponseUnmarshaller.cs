using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000097")]
	public class UpdateIdentityPoolResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateIdentityPoolResponseUnmarshaller _instance;

		[Token(Token = "0x170000E3")]
		public static UpdateIdentityPoolResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1189CE8", Offset = "0x1189CE8", VA = "0x1189CE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x11887C4", Offset = "0x11887C4", VA = "0x11887C4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1189318", Offset = "0x1189318", VA = "0x1189318", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1189C84", Offset = "0x1189C84", VA = "0x1189C84")]
		internal static UpdateIdentityPoolResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1189D4C", Offset = "0x1189D4C", VA = "0x1189D4C")]
		public UpdateIdentityPoolResponseUnmarshaller()
		{
		}
	}
}
