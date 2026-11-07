using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007C")]
	public class ListTagsForResourceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x0")]
		private static ListTagsForResourceResponseUnmarshaller _instance;

		[Token(Token = "0x170000CB")]
		public static ListTagsForResourceResponseUnmarshaller Instance
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1092250", Offset = "0x1092250", VA = "0x1092250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x109186C", Offset = "0x109186C", VA = "0x109186C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1091AF0", Offset = "0x1091AF0", VA = "0x1091AF0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x10921EC", Offset = "0x10921EC", VA = "0x10921EC")]
		internal static ListTagsForResourceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x10922B4", Offset = "0x10922B4", VA = "0x10922B4")]
		public ListTagsForResourceResponseUnmarshaller()
		{
		}
	}
}
