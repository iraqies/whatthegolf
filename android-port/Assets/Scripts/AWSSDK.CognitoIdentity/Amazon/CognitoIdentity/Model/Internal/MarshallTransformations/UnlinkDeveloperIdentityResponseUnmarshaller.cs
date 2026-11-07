using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000090")]
	public class UnlinkDeveloperIdentityResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x0")]
		private static UnlinkDeveloperIdentityResponseUnmarshaller _instance;

		[Token(Token = "0x170000DC")]
		public static UnlinkDeveloperIdentityResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1183014", Offset = "0x1183014", VA = "0x1183014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1182784", Offset = "0x1182784", VA = "0x1182784", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x11827DC", Offset = "0x11827DC", VA = "0x11827DC", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1182FB0", Offset = "0x1182FB0", VA = "0x1182FB0")]
		internal static UnlinkDeveloperIdentityResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1183078", Offset = "0x1183078", VA = "0x1183078")]
		public UnlinkDeveloperIdentityResponseUnmarshaller()
		{
		}
	}
}
