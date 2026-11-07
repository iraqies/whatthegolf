using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000253")]
	public class SetUserSettingsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x0")]
		private static SetUserSettingsResponseUnmarshaller _instance;

		[Token(Token = "0x170003DC")]
		public static SetUserSettingsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x1153A04", Offset = "0x1153A04", VA = "0x1153A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x11530B0", Offset = "0x11530B0", VA = "0x11530B0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x1153108", Offset = "0x1153108", VA = "0x1153108", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x11539A0", Offset = "0x11539A0", VA = "0x11539A0")]
		internal static SetUserSettingsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x1153A68", Offset = "0x1153A68", VA = "0x1153A68")]
		public SetUserSettingsResponseUnmarshaller()
		{
		}
	}
}
