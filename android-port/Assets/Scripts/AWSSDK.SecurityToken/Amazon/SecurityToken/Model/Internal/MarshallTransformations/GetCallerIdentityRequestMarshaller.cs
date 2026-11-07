using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000040")]
	public class GetCallerIdentityRequestMarshaller : IMarshaller<IRequest, GetCallerIdentityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x0")]
		private static GetCallerIdentityRequestMarshaller _instance;

		[Token(Token = "0x17000061")]
		public static GetCallerIdentityRequestMarshaller Instance
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x12DFBDC", Offset = "0x12DFBDC", VA = "0x12DFBDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x12DF804", Offset = "0x12DF804", VA = "0x12DF804", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x12DF898", Offset = "0x12DF898", VA = "0x12DF898", Slot = "4")]
		public IRequest Marshall(GetCallerIdentityRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12DFB78", Offset = "0x12DFB78", VA = "0x12DFB78")]
		internal static GetCallerIdentityRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x12DFC40", Offset = "0x12DFC40", VA = "0x12DFC40")]
		public GetCallerIdentityRequestMarshaller()
		{
		}
	}
}
