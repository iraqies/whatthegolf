using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000260")]
	public class StartUserImportJobResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x0")]
		private static StartUserImportJobResponseUnmarshaller _instance;

		[Token(Token = "0x170003E4")]
		public static StartUserImportJobResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001222")]
			[Address(RVA = "0x1158800", Offset = "0x1158800", VA = "0x1158800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600121F")]
		[Address(RVA = "0x1157E44", Offset = "0x1157E44", VA = "0x1157E44", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001220")]
		[Address(RVA = "0x1157FD0", Offset = "0x1157FD0", VA = "0x1157FD0", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001221")]
		[Address(RVA = "0x115879C", Offset = "0x115879C", VA = "0x115879C")]
		internal static StartUserImportJobResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001223")]
		[Address(RVA = "0x1158864", Offset = "0x1158864", VA = "0x1158864")]
		public StartUserImportJobResponseUnmarshaller()
		{
		}
	}
}
