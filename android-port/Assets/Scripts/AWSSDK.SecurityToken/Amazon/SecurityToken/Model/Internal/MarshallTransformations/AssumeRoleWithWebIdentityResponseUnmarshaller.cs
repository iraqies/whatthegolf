using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000038")]
	public class AssumeRoleWithWebIdentityResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x0")]
		private static AssumeRoleWithWebIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x17000059")]
		public static AssumeRoleWithWebIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x12DCF54", Offset = "0x12DCF54", VA = "0x12DCF54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x12DBDC4", Offset = "0x12DBDC4", VA = "0x12DBDC4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x12DBFD4", Offset = "0x12DBFD4", VA = "0x12DBFD4")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, AssumeRoleWithWebIdentityResponse response)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x12DC548", Offset = "0x12DC548", VA = "0x12DC548", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x12DCEF0", Offset = "0x12DCEF0", VA = "0x12DCEF0")]
		internal static AssumeRoleWithWebIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x12DCFB8", Offset = "0x12DCFB8", VA = "0x12DCFB8")]
		public AssumeRoleWithWebIdentityResponseUnmarshaller()
		{
		}
	}
}
