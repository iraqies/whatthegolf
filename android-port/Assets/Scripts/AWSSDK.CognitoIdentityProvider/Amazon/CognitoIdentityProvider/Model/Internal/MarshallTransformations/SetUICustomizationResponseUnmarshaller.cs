using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200024D")]
	public class SetUICustomizationResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x0")]
		private static SetUICustomizationResponseUnmarshaller _instance;

		[Token(Token = "0x170003D6")]
		public static SetUICustomizationResponseUnmarshaller Instance
		{
			[Token(Token = "0x60011C3")]
			[Address(RVA = "0x114E730", Offset = "0x114E730", VA = "0x114E730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011C0")]
		[Address(RVA = "0x114DE3C", Offset = "0x114DE3C", VA = "0x114DE3C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x114DFC8", Offset = "0x114DFC8", VA = "0x114DFC8", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x114E6CC", Offset = "0x114E6CC", VA = "0x114E6CC")]
		internal static SetUICustomizationResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x114E794", Offset = "0x114E794", VA = "0x114E794")]
		public SetUICustomizationResponseUnmarshaller()
		{
		}
	}
}
