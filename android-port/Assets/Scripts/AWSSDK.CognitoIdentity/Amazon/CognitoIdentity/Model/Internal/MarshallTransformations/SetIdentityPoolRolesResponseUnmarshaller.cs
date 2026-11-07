using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008B")]
	public class SetIdentityPoolRolesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x0")]
		private static SetIdentityPoolRolesResponseUnmarshaller _instance;

		[Token(Token = "0x170000D7")]
		public static SetIdentityPoolRolesResponseUnmarshaller Instance
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x11802D4", Offset = "0x11802D4", VA = "0x11802D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x117F894", Offset = "0x117F894", VA = "0x117F894", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x117F8EC", Offset = "0x117F8EC", VA = "0x117F8EC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1180270", Offset = "0x1180270", VA = "0x1180270")]
		internal static SetIdentityPoolRolesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1180338", Offset = "0x1180338", VA = "0x1180338")]
		public SetIdentityPoolRolesResponseUnmarshaller()
		{
		}
	}
}
