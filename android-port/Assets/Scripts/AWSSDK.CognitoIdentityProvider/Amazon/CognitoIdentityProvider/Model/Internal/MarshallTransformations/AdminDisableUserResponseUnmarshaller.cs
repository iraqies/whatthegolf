using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200016B")]
	public class AdminDisableUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x0")]
		private static AdminDisableUserResponseUnmarshaller _instance;

		[Token(Token = "0x1700030B")]
		public static AdminDisableUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x10A6920", Offset = "0x10A6920", VA = "0x10A6920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x10A608C", Offset = "0x10A608C", VA = "0x10A608C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x10A60E4", Offset = "0x10A60E4", VA = "0x10A60E4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x10A68BC", Offset = "0x10A68BC", VA = "0x10A68BC")]
		internal static AdminDisableUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x10A6984", Offset = "0x10A6984", VA = "0x10A6984")]
		public AdminDisableUserResponseUnmarshaller()
		{
		}
	}
}
