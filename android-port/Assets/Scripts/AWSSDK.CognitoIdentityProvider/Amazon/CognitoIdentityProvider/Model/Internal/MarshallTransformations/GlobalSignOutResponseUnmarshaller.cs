using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000200")]
	public class GlobalSignOutResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x0")]
		private static GlobalSignOutResponseUnmarshaller _instance;

		[Token(Token = "0x17000396")]
		public static GlobalSignOutResponseUnmarshaller Instance
		{
			[Token(Token = "0x600103E")]
			[Address(RVA = "0x1127338", Offset = "0x1127338", VA = "0x1127338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600103B")]
		[Address(RVA = "0x11269E0", Offset = "0x11269E0", VA = "0x11269E0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600103C")]
		[Address(RVA = "0x1126A38", Offset = "0x1126A38", VA = "0x1126A38", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600103D")]
		[Address(RVA = "0x11272D4", Offset = "0x11272D4", VA = "0x11272D4")]
		internal static GlobalSignOutResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600103F")]
		[Address(RVA = "0x112739C", Offset = "0x112739C", VA = "0x112739C")]
		public GlobalSignOutResponseUnmarshaller()
		{
		}
	}
}
