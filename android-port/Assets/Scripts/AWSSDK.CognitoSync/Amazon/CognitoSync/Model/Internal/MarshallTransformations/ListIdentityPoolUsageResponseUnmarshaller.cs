using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000062")]
	public class ListIdentityPoolUsageResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x0")]
		private static ListIdentityPoolUsageResponseUnmarshaller _instance;

		[Token(Token = "0x1700009A")]
		public static ListIdentityPoolUsageResponseUnmarshaller Instance
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x11A139C", Offset = "0x11A139C", VA = "0x11A139C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11A07D0", Offset = "0x11A07D0", VA = "0x11A07D0", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11A0D08", Offset = "0x11A0D08", VA = "0x11A0D08", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x11A1338", Offset = "0x11A1338", VA = "0x11A1338")]
		internal static ListIdentityPoolUsageResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11A1400", Offset = "0x11A1400", VA = "0x11A1400")]
		public ListIdentityPoolUsageResponseUnmarshaller()
		{
		}
	}
}
