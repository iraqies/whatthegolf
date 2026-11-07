using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000044")]
	public class GetSessionTokenRequestMarshaller : IMarshaller<IRequest, GetSessionTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		private static GetSessionTokenRequestMarshaller _instance;

		[Token(Token = "0x17000065")]
		public static GetSessionTokenRequestMarshaller Instance
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x12E3070", Offset = "0x12E3070", VA = "0x12E3070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x12E2870", Offset = "0x12E2870", VA = "0x12E2870", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x12E2904", Offset = "0x12E2904", VA = "0x12E2904", Slot = "4")]
		public IRequest Marshall(GetSessionTokenRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x12E300C", Offset = "0x12E300C", VA = "0x12E300C")]
		internal static GetSessionTokenRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x12E30D4", Offset = "0x12E30D4", VA = "0x12E30D4")]
		public GetSessionTokenRequestMarshaller()
		{
		}
	}
}
