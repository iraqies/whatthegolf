using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000095")]
	public class UntagResourceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x0")]
		private static UntagResourceResponseUnmarshaller _instance;

		[Token(Token = "0x170000E1")]
		public static UntagResourceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x11864E0", Offset = "0x11864E0", VA = "0x11864E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1185D1C", Offset = "0x1185D1C", VA = "0x1185D1C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1185D74", Offset = "0x1185D74", VA = "0x1185D74", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x118647C", Offset = "0x118647C", VA = "0x118647C")]
		internal static UntagResourceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1186544", Offset = "0x1186544", VA = "0x1186544")]
		public UntagResourceResponseUnmarshaller()
		{
		}
	}
}
