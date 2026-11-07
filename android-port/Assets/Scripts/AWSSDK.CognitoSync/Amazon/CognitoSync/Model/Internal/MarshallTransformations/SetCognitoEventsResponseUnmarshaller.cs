using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006F")]
	public class SetCognitoEventsResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x0")]
		private static SetCognitoEventsResponseUnmarshaller _instance;

		[Token(Token = "0x170000A5")]
		public static SetCognitoEventsResponseUnmarshaller Instance
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x11A88B4", Offset = "0x11A88B4", VA = "0x11A88B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x11A8100", Offset = "0x11A8100", VA = "0x11A8100", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x11A8158", Offset = "0x11A8158", VA = "0x11A8158", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x11A8850", Offset = "0x11A8850", VA = "0x11A8850")]
		internal static SetCognitoEventsResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x11A8918", Offset = "0x11A8918", VA = "0x11A8918")]
		public SetCognitoEventsResponseUnmarshaller()
		{
		}
	}
}
