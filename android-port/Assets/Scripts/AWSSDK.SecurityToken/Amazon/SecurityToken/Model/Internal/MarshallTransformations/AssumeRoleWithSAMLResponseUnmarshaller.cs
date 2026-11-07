using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000036")]
	public class AssumeRoleWithSAMLResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x0")]
		private static AssumeRoleWithSAMLResponseUnmarshaller _instance;

		[Token(Token = "0x17000057")]
		public static AssumeRoleWithSAMLResponseUnmarshaller Instance
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x12DAA04", Offset = "0x12DAA04", VA = "0x12DAA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x12D95C4", Offset = "0x12D95C4", VA = "0x12D95C4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x12D97D4", Offset = "0x12D97D4", VA = "0x12D97D4")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, AssumeRoleWithSAMLResponse response)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x12D9E88", Offset = "0x12D9E88", VA = "0x12D9E88", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x12DA9A0", Offset = "0x12DA9A0", VA = "0x12DA9A0")]
		internal static AssumeRoleWithSAMLResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x12DAA68", Offset = "0x12DAA68", VA = "0x12DAA68")]
		public AssumeRoleWithSAMLResponseUnmarshaller()
		{
		}
	}
}
