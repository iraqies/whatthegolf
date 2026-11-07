using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000274")]
	public class UpdateGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateGroupResponseUnmarshaller _instance;

		[Token(Token = "0x170003F7")]
		public static UpdateGroupResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001290")]
			[Address(RVA = "0x1163C90", Offset = "0x1163C90", VA = "0x1163C90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600128D")]
		[Address(RVA = "0x1163398", Offset = "0x1163398", VA = "0x1163398", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600128E")]
		[Address(RVA = "0x1163524", Offset = "0x1163524", VA = "0x1163524", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600128F")]
		[Address(RVA = "0x1163C2C", Offset = "0x1163C2C", VA = "0x1163C2C")]
		internal static UpdateGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001291")]
		[Address(RVA = "0x1163CF4", Offset = "0x1163CF4", VA = "0x1163CF4")]
		public UpdateGroupResponseUnmarshaller()
		{
		}
	}
}
