using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000262")]
	public class StopUserImportJobResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x0")]
		private static StopUserImportJobResponseUnmarshaller _instance;

		[Token(Token = "0x170003E6")]
		public static StopUserImportJobResponseUnmarshaller Instance
		{
			[Token(Token = "0x600122E")]
			[Address(RVA = "0x115ACB0", Offset = "0x115ACB0", VA = "0x115ACB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600122B")]
		[Address(RVA = "0x115972C", Offset = "0x115972C", VA = "0x115972C", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600122C")]
		[Address(RVA = "0x115A394", Offset = "0x115A394", VA = "0x115A394", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x600122D")]
		[Address(RVA = "0x115AC4C", Offset = "0x115AC4C", VA = "0x115AC4C")]
		internal static StopUserImportJobResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600122F")]
		[Address(RVA = "0x115AD14", Offset = "0x115AD14", VA = "0x115AD14")]
		public StopUserImportJobResponseUnmarshaller()
		{
		}
	}
}
