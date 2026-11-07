using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200021C")]
	public class ListTagsForResourceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x0")]
		private static ListTagsForResourceResponseUnmarshaller _instance;

		[Token(Token = "0x170003B0")]
		public static ListTagsForResourceResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010D2")]
			[Address(RVA = "0x11349DC", Offset = "0x11349DC", VA = "0x11349DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x1133FF0", Offset = "0x1133FF0", VA = "0x1133FF0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x1134274", Offset = "0x1134274", VA = "0x1134274", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x1134978", Offset = "0x1134978", VA = "0x1134978")]
		internal static ListTagsForResourceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x1134A40", Offset = "0x1134A40", VA = "0x1134A40")]
		public ListTagsForResourceResponseUnmarshaller()
		{
		}
	}
}
