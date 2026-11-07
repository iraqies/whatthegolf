using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000092")]
	public class UnlinkIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		private static UnlinkIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x170000DE")]
		public static UnlinkIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1184A98", Offset = "0x1184A98", VA = "0x1184A98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x118413C", Offset = "0x118413C", VA = "0x118413C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1184194", Offset = "0x1184194", VA = "0x1184194", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1184A34", Offset = "0x1184A34", VA = "0x1184A34")]
		internal static UnlinkIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1184AFC", Offset = "0x1184AFC", VA = "0x1184AFC")]
		public UnlinkIdentityResponseUnmarshaller()
		{
		}
	}
}
