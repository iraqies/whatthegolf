using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000163")]
	public class AdminCreateUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x0")]
		private static AdminCreateUserResponseUnmarshaller _instance;

		[Token(Token = "0x17000303")]
		public static AdminCreateUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x10A1304", Offset = "0x10A1304", VA = "0x10A1304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x10A0140", Offset = "0x10A0140", VA = "0x10A0140", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x10A02CC", Offset = "0x10A02CC", VA = "0x10A02CC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x10A12A0", Offset = "0x10A12A0", VA = "0x10A12A0")]
		internal static AdminCreateUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x10A1368", Offset = "0x10A1368", VA = "0x10A1368")]
		public AdminCreateUserResponseUnmarshaller()
		{
		}
	}
}
