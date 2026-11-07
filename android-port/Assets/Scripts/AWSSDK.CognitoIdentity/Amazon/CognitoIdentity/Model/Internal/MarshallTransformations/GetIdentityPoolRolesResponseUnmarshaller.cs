using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006A")]
	public class GetIdentityPoolRolesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x0")]
		private static GetIdentityPoolRolesResponseUnmarshaller _instance;

		[Token(Token = "0x170000B9")]
		public static GetIdentityPoolRolesResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x1088FC8", Offset = "0x1088FC8", VA = "0x1088FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x108835C", Offset = "0x108835C", VA = "0x108835C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x10887A0", Offset = "0x10887A0", VA = "0x10887A0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1088F64", Offset = "0x1088F64", VA = "0x1088F64")]
		internal static GetIdentityPoolRolesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x108902C", Offset = "0x108902C", VA = "0x108902C")]
		public GetIdentityPoolRolesResponseUnmarshaller()
		{
		}
	}
}
