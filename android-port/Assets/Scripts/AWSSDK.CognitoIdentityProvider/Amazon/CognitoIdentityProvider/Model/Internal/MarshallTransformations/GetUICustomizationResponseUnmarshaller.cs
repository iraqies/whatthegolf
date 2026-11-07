using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001F8")]
	public class GetUICustomizationResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x0")]
		private static GetUICustomizationResponseUnmarshaller _instance;

		[Token(Token = "0x1700038E")]
		public static GetUICustomizationResponseUnmarshaller Instance
		{
			[Token(Token = "0x600100E")]
			[Address(RVA = "0x11208EC", Offset = "0x11208EC", VA = "0x11208EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600100B")]
		[Address(RVA = "0x111FFF8", Offset = "0x111FFF8", VA = "0x111FFF8", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600100C")]
		[Address(RVA = "0x1120184", Offset = "0x1120184", VA = "0x1120184", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600100D")]
		[Address(RVA = "0x1120888", Offset = "0x1120888", VA = "0x1120888")]
		internal static GetUICustomizationResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600100F")]
		[Address(RVA = "0x1120950", Offset = "0x1120950", VA = "0x1120950")]
		public GetUICustomizationResponseUnmarshaller()
		{
		}
	}
}
