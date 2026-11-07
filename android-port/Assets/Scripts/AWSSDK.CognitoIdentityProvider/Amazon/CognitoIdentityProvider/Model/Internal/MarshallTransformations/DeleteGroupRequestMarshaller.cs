using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001BE")]
	public class DeleteGroupRequestMarshaller : IMarshaller<IRequest, DeleteGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteGroupRequestMarshaller _instance;

		[Token(Token = "0x17000357")]
		public static DeleteGroupRequestMarshaller Instance
		{
			[Token(Token = "0x6000EC5")]
			[Address(RVA = "0x10FAF60", Offset = "0x10FAF60", VA = "0x10FAF60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x10FA558", Offset = "0x10FA558", VA = "0x10FA558", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x10FA5EC", Offset = "0x10FA5EC", VA = "0x10FA5EC", Slot = "4")]
		public IRequest Marshall(DeleteGroupRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x10FAEFC", Offset = "0x10FAEFC", VA = "0x10FAEFC")]
		internal static DeleteGroupRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x10FAFC4", Offset = "0x10FAFC4", VA = "0x10FAFC4")]
		public DeleteGroupRequestMarshaller()
		{
		}
	}
}
