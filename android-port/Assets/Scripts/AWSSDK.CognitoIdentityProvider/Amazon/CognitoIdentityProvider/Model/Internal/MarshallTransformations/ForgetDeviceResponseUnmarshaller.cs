using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001EA")]
	public class ForgetDeviceResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x0")]
		private static ForgetDeviceResponseUnmarshaller _instance;

		[Token(Token = "0x17000380")]
		public static ForgetDeviceResponseUnmarshaller Instance
		{
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x1115208", Offset = "0x1115208", VA = "0x1115208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x1114470", Offset = "0x1114470", VA = "0x1114470", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x11144C8", Offset = "0x11144C8", VA = "0x11144C8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x11151A4", Offset = "0x11151A4", VA = "0x11151A4")]
		internal static ForgetDeviceResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x111526C", Offset = "0x111526C", VA = "0x111526C")]
		public ForgetDeviceResponseUnmarshaller()
		{
		}
	}
}
