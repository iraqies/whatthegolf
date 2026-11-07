using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200003A")]
	public class DecodeAuthorizationMessageRequestMarshaller : IMarshaller<IRequest, DecodeAuthorizationMessageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		private static DecodeAuthorizationMessageRequestMarshaller _instance;

		[Token(Token = "0x1700005B")]
		public static DecodeAuthorizationMessageRequestMarshaller Instance
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x12DD9D8", Offset = "0x12DD9D8", VA = "0x12DD9D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x12DD4A4", Offset = "0x12DD4A4", VA = "0x12DD4A4", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x12DD538", Offset = "0x12DD538", VA = "0x12DD538", Slot = "4")]
		public IRequest Marshall(DecodeAuthorizationMessageRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x12DD974", Offset = "0x12DD974", VA = "0x12DD974")]
		internal static DecodeAuthorizationMessageRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12DDA3C", Offset = "0x12DDA3C", VA = "0x12DDA3C")]
		public DecodeAuthorizationMessageRequestMarshaller()
		{
		}
	}
}
