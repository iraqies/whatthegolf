using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200021A")]
	public class ListResourceServersResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x0")]
		private static ListResourceServersResponseUnmarshaller _instance;

		[Token(Token = "0x170003AE")]
		public static ListResourceServersResponseUnmarshaller Instance
		{
			[Token(Token = "0x60010C6")]
			[Address(RVA = "0x11333A8", Offset = "0x11333A8", VA = "0x11333A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x1132944", Offset = "0x1132944", VA = "0x1132944", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x1132C40", Offset = "0x1132C40", VA = "0x1132C40", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x1133344", Offset = "0x1133344", VA = "0x1133344")]
		internal static ListResourceServersResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x113340C", Offset = "0x113340C", VA = "0x113340C")]
		public ListResourceServersResponseUnmarshaller()
		{
		}
	}
}
