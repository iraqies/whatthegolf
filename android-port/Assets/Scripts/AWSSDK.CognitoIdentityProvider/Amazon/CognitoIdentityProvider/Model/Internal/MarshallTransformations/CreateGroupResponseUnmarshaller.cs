using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001AF")]
	public class CreateGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x0")]
		private static CreateGroupResponseUnmarshaller _instance;

		[Token(Token = "0x17000349")]
		public static CreateGroupResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000E6F")]
			[Address(RVA = "0x10ECCF4", Offset = "0x10ECCF4", VA = "0x10ECCF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x10EC260", Offset = "0x10EC260", VA = "0x10EC260", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x10EC3EC", Offset = "0x10EC3EC", VA = "0x10EC3EC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x10ECC90", Offset = "0x10ECC90", VA = "0x10ECC90")]
		internal static CreateGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x10ECD58", Offset = "0x10ECD58", VA = "0x10ECD58")]
		public CreateGroupResponseUnmarshaller()
		{
		}
	}
}
