using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200017B")]
	public class AdminListGroupsForUserResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x0")]
		private static AdminListGroupsForUserResponseUnmarshaller _instance;

		[Token(Token = "0x1700031B")]
		public static AdminListGroupsForUserResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000D55")]
			[Address(RVA = "0x10B44DC", Offset = "0x10B44DC", VA = "0x10B44DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x10B39A4", Offset = "0x10B39A4", VA = "0x10B39A4", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x10B3CA0", Offset = "0x10B3CA0", VA = "0x10B3CA0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x10B4478", Offset = "0x10B4478", VA = "0x10B4478")]
		internal static AdminListGroupsForUserResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x10B4540", Offset = "0x10B4540", VA = "0x10B4540")]
		public AdminListGroupsForUserResponseUnmarshaller()
		{
		}
	}
}
