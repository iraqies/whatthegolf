using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000042")]
	public class GetFederationTokenRequestMarshaller : IMarshaller<IRequest, GetFederationTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x0")]
		private static GetFederationTokenRequestMarshaller _instance;

		[Token(Token = "0x17000063")]
		public static GetFederationTokenRequestMarshaller Instance
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x12E191C", Offset = "0x12E191C", VA = "0x12E191C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x12E0994", Offset = "0x12E0994", VA = "0x12E0994", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x12E0A28", Offset = "0x12E0A28", VA = "0x12E0A28", Slot = "4")]
		public IRequest Marshall(GetFederationTokenRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x12E18B8", Offset = "0x12E18B8", VA = "0x12E18B8")]
		internal static GetFederationTokenRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x12E1980", Offset = "0x12E1980", VA = "0x12E1980")]
		public GetFederationTokenRequestMarshaller()
		{
		}
	}
}
