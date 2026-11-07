using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200027A")]
	public class UpdateUserAttributesResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateUserAttributesResponseUnmarshaller _instance;

		[Token(Token = "0x170003FD")]
		public static UpdateUserAttributesResponseUnmarshaller Instance
		{
			[Token(Token = "0x60012B4")]
			[Address(RVA = "0x1169B34", Offset = "0x1169B34", VA = "0x1169B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x1168650", Offset = "0x1168650", VA = "0x1168650", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x1168894", Offset = "0x1168894", VA = "0x1168894", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x1169AD0", Offset = "0x1169AD0", VA = "0x1169AD0")]
		internal static UpdateUserAttributesResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60012B5")]
		[Address(RVA = "0x1169B98", Offset = "0x1169B98", VA = "0x1169B98")]
		public UpdateUserAttributesResponseUnmarshaller()
		{
		}
	}
}
