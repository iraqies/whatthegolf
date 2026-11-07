using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000181")]
	public class AdminResetUserPasswordResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x0")]
		private static AdminResetUserPasswordResponseUnmarshaller _instance;

		[Token(Token = "0x17000321")]
		public static AdminResetUserPasswordResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x10B926C", Offset = "0x10B926C", VA = "0x10B926C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x10B8428", Offset = "0x10B8428", VA = "0x10B8428", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x10B8480", Offset = "0x10B8480", VA = "0x10B8480", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x10B9208", Offset = "0x10B9208", VA = "0x10B9208")]
		internal static AdminResetUserPasswordResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x10B92D0", Offset = "0x10B92D0", VA = "0x10B92D0")]
		public AdminResetUserPasswordResponseUnmarshaller()
		{
		}
	}
}
