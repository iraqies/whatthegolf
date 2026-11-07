using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008D")]
	public class TagResourceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		private static TagResourceResponseUnmarshaller _instance;

		[Token(Token = "0x170000D9")]
		public static TagResourceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1181920", Offset = "0x1181920", VA = "0x1181920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x118115C", Offset = "0x118115C", VA = "0x118115C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x11811B4", Offset = "0x11811B4", VA = "0x11811B4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x11818BC", Offset = "0x11818BC", VA = "0x11818BC")]
		internal static TagResourceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1181984", Offset = "0x1181984", VA = "0x1181984")]
		public TagResourceResponseUnmarshaller()
		{
		}
	}
}
