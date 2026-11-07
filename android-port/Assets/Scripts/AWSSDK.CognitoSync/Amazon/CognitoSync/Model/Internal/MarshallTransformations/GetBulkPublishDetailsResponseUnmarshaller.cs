using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000052")]
	public class GetBulkPublishDetailsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x0")]
		private static GetBulkPublishDetailsResponseUnmarshaller _instance;

		[Token(Token = "0x1700008A")]
		public static GetBulkPublishDetailsResponseUnmarshaller Instance
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x119A510", Offset = "0x119A510", VA = "0x119A510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1199994", Offset = "0x1199994", VA = "0x1199994", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1199E7C", Offset = "0x1199E7C", VA = "0x1199E7C", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x119A4AC", Offset = "0x119A4AC", VA = "0x119A4AC")]
		internal static GetBulkPublishDetailsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x119A574", Offset = "0x119A574", VA = "0x119A574")]
		public GetBulkPublishDetailsResponseUnmarshaller()
		{
		}
	}
}
