using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005D")]
	public class DeleteIdentitiesRequestMarshaller : IMarshaller<IRequest, DeleteIdentitiesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteIdentitiesRequestMarshaller _instance;

		[Token(Token = "0x170000AC")]
		public static DeleteIdentitiesRequestMarshaller Instance
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x107DC88", Offset = "0x107DC88", VA = "0x107DC88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x107D168", Offset = "0x107D168", VA = "0x107D168", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x107D1FC", Offset = "0x107D1FC", VA = "0x107D1FC", Slot = "4")]
		public IRequest Marshall(DeleteIdentitiesRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x107DC24", Offset = "0x107DC24", VA = "0x107DC24")]
		internal static DeleteIdentitiesRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x107DCEC", Offset = "0x107DCEC", VA = "0x107DCEC")]
		public DeleteIdentitiesRequestMarshaller()
		{
		}
	}
}
