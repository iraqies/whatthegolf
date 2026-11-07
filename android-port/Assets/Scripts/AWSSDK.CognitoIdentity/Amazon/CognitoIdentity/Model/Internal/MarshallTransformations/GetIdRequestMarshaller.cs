using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006B")]
	public class GetIdRequestMarshaller : IMarshaller<IRequest, GetIdRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		private static GetIdRequestMarshaller _instance;

		[Token(Token = "0x170000BA")]
		public static GetIdRequestMarshaller Instance
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1086A10", Offset = "0x1086A10", VA = "0x1086A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1085DC8", Offset = "0x1085DC8", VA = "0x1085DC8", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1085E5C", Offset = "0x1085E5C", VA = "0x1085E5C", Slot = "4")]
		public IRequest Marshall(GetIdRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x10869AC", Offset = "0x10869AC", VA = "0x10869AC")]
		internal static GetIdRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1086A74", Offset = "0x1086A74", VA = "0x1086A74")]
		public GetIdRequestMarshaller()
		{
		}
	}
}
