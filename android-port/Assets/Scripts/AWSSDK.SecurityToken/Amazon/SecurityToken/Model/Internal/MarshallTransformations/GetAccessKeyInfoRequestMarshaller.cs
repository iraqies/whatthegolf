using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200003E")]
	public class GetAccessKeyInfoRequestMarshaller : IMarshaller<IRequest, GetAccessKeyInfoRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x0")]
		private static GetAccessKeyInfoRequestMarshaller _instance;

		[Token(Token = "0x1700005F")]
		public static GetAccessKeyInfoRequestMarshaller Instance
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x12DEF7C", Offset = "0x12DEF7C", VA = "0x12DEF7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x12DEA48", Offset = "0x12DEA48", VA = "0x12DEA48", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x12DEADC", Offset = "0x12DEADC", VA = "0x12DEADC", Slot = "4")]
		public IRequest Marshall(GetAccessKeyInfoRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x12DEF18", Offset = "0x12DEF18", VA = "0x12DEF18")]
		internal static GetAccessKeyInfoRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x12DEFE0", Offset = "0x12DEFE0", VA = "0x12DEFE0")]
		public GetAccessKeyInfoRequestMarshaller()
		{
		}
	}
}
