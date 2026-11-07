using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200024B")]
	public class SetRiskConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x0")]
		private static SetRiskConfigurationResponseUnmarshaller _instance;

		[Token(Token = "0x170003D4")]
		public static SetRiskConfigurationResponseUnmarshaller Instance
		{
			[Token(Token = "0x60011B7")]
			[Address(RVA = "0x114D0D0", Offset = "0x114D0D0", VA = "0x114D0D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011B4")]
		[Address(RVA = "0x114C57C", Offset = "0x114C57C", VA = "0x114C57C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x114C704", Offset = "0x114C704", VA = "0x114C704", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x114D06C", Offset = "0x114D06C", VA = "0x114D06C")]
		internal static SetRiskConfigurationResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x114D134", Offset = "0x114D134", VA = "0x114D134")]
		public SetRiskConfigurationResponseUnmarshaller()
		{
		}
	}
}
