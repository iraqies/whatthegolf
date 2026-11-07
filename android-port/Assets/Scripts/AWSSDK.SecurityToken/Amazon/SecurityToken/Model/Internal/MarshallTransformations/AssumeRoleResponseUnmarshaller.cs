using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000034")]
	public class AssumeRoleResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x0")]
		private static AssumeRoleResponseUnmarshaller _instance;

		[Token(Token = "0x17000055")]
		public static AssumeRoleResponseUnmarshaller Instance
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x12D823C", Offset = "0x12D823C", VA = "0x12D823C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x12D6CB8", Offset = "0x12D6CB8", VA = "0x12D6CB8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12D6EC8", Offset = "0x12D6EC8", VA = "0x12D6EC8")]
		private static void UnmarshallResult(XmlUnmarshallerContext context, AssumeRoleResponse response)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x12D7918", Offset = "0x12D7918", VA = "0x12D7918", Slot = "13")]
		public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x12D81D8", Offset = "0x12D81D8", VA = "0x12D81D8")]
		internal static AssumeRoleResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x12D82A0", Offset = "0x12D82A0", VA = "0x12D82A0")]
		public AssumeRoleResponseUnmarshaller()
		{
		}
	}
}
