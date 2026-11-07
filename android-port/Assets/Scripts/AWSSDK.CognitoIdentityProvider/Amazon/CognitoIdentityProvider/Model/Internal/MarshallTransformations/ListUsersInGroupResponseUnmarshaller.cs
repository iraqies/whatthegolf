using System;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000224")]
	public class ListUsersInGroupResponseUnmarshaller : JsonResponseUnmarshaller
	{
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x0")]
		private static ListUsersInGroupResponseUnmarshaller _instance;

		[Token(Token = "0x170003B8")]
		public static ListUsersInGroupResponseUnmarshaller Instance
		{
			[Token(Token = "0x6001102")]
			[Address(RVA = "0x113AECC", Offset = "0x113AECC", VA = "0x113AECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x113A468", Offset = "0x113A468", VA = "0x113A468", Slot = "12")]
		public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001100")]
		[Address(RVA = "0x113A764", Offset = "0x113A764", VA = "0x113A764", Slot = "13")]
		public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
		{
			return null;
		}

		[Token(Token = "0x6001101")]
		[Address(RVA = "0x113AE68", Offset = "0x113AE68", VA = "0x113AE68")]
		internal static ListUsersInGroupResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001103")]
		[Address(RVA = "0x113AF30", Offset = "0x113AF30", VA = "0x113AF30")]
		public ListUsersInGroupResponseUnmarshaller()
		{
		}
	}
}
