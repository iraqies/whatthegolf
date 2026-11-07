using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200003F")]
	public class GetAccessKeyInfoResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		private static GetAccessKeyInfoResponseUnmarshaller _instance;

		[Token(Token = "0x17000060")]
		public static GetAccessKeyInfoResponseUnmarshaller Instance
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x12DF730", Offset = "0x12DF730", VA = "0x12DF730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x12DF070", Offset = "0x12DF070", VA = "0x12DF070", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x12DF280", Offset = "0x12DF280", VA = "0x12DF280")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, GetAccessKeyInfoResponse response)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x12DF414", Offset = "0x12DF414", VA = "0x12DF414", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x12DF6CC", Offset = "0x12DF6CC", VA = "0x12DF6CC")]
		internal static GetAccessKeyInfoResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x12DF794", Offset = "0x12DF794", VA = "0x12DF794")]
		public GetAccessKeyInfoResponseUnmarshaller()
		{
		}
	}
}
