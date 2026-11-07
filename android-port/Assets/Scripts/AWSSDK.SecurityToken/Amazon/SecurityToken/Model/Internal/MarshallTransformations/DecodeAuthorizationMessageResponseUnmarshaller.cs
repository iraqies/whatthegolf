using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200003B")]
	public class DecodeAuthorizationMessageResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x0")]
		private static DecodeAuthorizationMessageResponseUnmarshaller _instance;

		[Token(Token = "0x1700005C")]
		public static DecodeAuthorizationMessageResponseUnmarshaller Instance
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x12DE3CC", Offset = "0x12DE3CC", VA = "0x12DE3CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x12DDACC", Offset = "0x12DDACC", VA = "0x12DDACC", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x12DDCDC", Offset = "0x12DDCDC", VA = "0x12DDCDC")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, DecodeAuthorizationMessageResponse response)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x12DDE70", Offset = "0x12DDE70", VA = "0x12DDE70", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x12DE368", Offset = "0x12DE368", VA = "0x12DE368")]
		internal static DecodeAuthorizationMessageResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x12DE430", Offset = "0x12DE430", VA = "0x12DE430")]
		public DecodeAuthorizationMessageResponseUnmarshaller()
		{
		}
	}
}
