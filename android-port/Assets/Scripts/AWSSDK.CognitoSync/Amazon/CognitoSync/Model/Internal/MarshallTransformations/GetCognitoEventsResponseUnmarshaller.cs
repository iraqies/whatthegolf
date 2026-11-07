using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000054")]
	public class GetCognitoEventsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x0")]
		private static GetCognitoEventsResponseUnmarshaller _instance;

		[Token(Token = "0x1700008C")]
		public static GetCognitoEventsResponseUnmarshaller Instance
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x119B700", Offset = "0x119B700", VA = "0x119B700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x119AD20", Offset = "0x119AD20", VA = "0x119AD20", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x119AFA4", Offset = "0x119AFA4", VA = "0x119AFA4", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x119B69C", Offset = "0x119B69C", VA = "0x119B69C")]
		internal static GetCognitoEventsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x119B764", Offset = "0x119B764", VA = "0x119B764")]
		public GetCognitoEventsResponseUnmarshaller()
		{
		}
	}
}
