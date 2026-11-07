using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200018F")]
	public class AdminUpdateUserAttributesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x0")]
		private static AdminUpdateUserAttributesResponseUnmarshaller _instance;

		[Token(Token = "0x1700032F")]
		public static AdminUpdateUserAttributesResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000DCD")]
			[Address(RVA = "0x10C5904", Offset = "0x10C5904", VA = "0x10C5904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x10C49E0", Offset = "0x10C49E0", VA = "0x10C49E0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x10C4A38", Offset = "0x10C4A38", VA = "0x10C4A38", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x10C58A0", Offset = "0x10C58A0", VA = "0x10C58A0")]
		internal static AdminUpdateUserAttributesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x10C5968", Offset = "0x10C5968", VA = "0x10C5968")]
		public AdminUpdateUserAttributesResponseUnmarshaller()
		{
		}
	}
}
