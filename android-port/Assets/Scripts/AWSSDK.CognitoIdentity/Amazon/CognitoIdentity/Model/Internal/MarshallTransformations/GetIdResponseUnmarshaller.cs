using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006C")]
	public class GetIdResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x0")]
		private static GetIdResponseUnmarshaller _instance;

		[Token(Token = "0x170000BB")]
		public static GetIdResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1087648", Offset = "0x1087648", VA = "0x1087648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1086B04", Offset = "0x1086B04", VA = "0x1086B04", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1086C90", Offset = "0x1086C90", VA = "0x1086C90", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x10875E4", Offset = "0x10875E4", VA = "0x10875E4")]
		internal static GetIdResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x10876AC", Offset = "0x10876AC", VA = "0x10876AC")]
		public GetIdResponseUnmarshaller()
		{
		}
	}
}
