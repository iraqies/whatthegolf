using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005E")]
	public class DeleteIdentitiesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteIdentitiesResponseUnmarshaller _instance;

		[Token(Token = "0x170000AD")]
		public static DeleteIdentitiesResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x107E650", Offset = "0x107E650", VA = "0x107E650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x107DE3C", Offset = "0x107DE3C", VA = "0x107DE3C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x107E080", Offset = "0x107E080", VA = "0x107E080", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x107E5EC", Offset = "0x107E5EC", VA = "0x107E5EC")]
		internal static DeleteIdentitiesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x107E6B4", Offset = "0x107E6B4", VA = "0x107E6B4")]
		public DeleteIdentitiesResponseUnmarshaller()
		{
		}
	}
}
