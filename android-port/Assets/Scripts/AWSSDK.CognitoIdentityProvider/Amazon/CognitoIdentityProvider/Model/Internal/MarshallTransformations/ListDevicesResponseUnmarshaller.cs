using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000214")]
	public class ListDevicesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x0")]
		private static ListDevicesResponseUnmarshaller _instance;

		[Token(Token = "0x170003A8")]
		public static ListDevicesResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010A2")]
			[Address(RVA = "0x112E8B4", Offset = "0x112E8B4", VA = "0x112E8B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600109F")]
		[Address(RVA = "0x112DB24", Offset = "0x112DB24", VA = "0x112DB24", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x112DE20", Offset = "0x112DE20", VA = "0x112DE20", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x112E850", Offset = "0x112E850", VA = "0x112E850")]
		internal static ListDevicesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x112E918", Offset = "0x112E918", VA = "0x112E918")]
		public ListDevicesResponseUnmarshaller()
		{
		}
	}
}
