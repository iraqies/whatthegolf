using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000060")]
	public class ListDatasetsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x0")]
		private static ListDatasetsResponseUnmarshaller _instance;

		[Token(Token = "0x17000098")]
		public static ListDatasetsResponseUnmarshaller Instance
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x119FAA0", Offset = "0x119FAA0", VA = "0x119FAA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x119EFB8", Offset = "0x119EFB8", VA = "0x119EFB8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x119F40C", Offset = "0x119F40C", VA = "0x119F40C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x119FA3C", Offset = "0x119FA3C", VA = "0x119FA3C")]
		internal static ListDatasetsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x119FB04", Offset = "0x119FB04", VA = "0x119FB04")]
		public ListDatasetsResponseUnmarshaller()
		{
		}
	}
}
