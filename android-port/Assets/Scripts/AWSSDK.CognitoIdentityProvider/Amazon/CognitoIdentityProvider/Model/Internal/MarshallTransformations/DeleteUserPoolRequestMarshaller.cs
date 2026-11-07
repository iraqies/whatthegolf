using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001CA")]
	public class DeleteUserPoolRequestMarshaller : IMarshaller<IRequest, DeleteUserPoolRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteUserPoolRequestMarshaller _instance;

		[Token(Token = "0x17000363")]
		public static DeleteUserPoolRequestMarshaller Instance
		{
			[Token(Token = "0x6000F0D")]
			[Address(RVA = "0x1102A24", Offset = "0x1102A24", VA = "0x1102A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x1102088", Offset = "0x1102088", VA = "0x1102088", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x110211C", Offset = "0x110211C", VA = "0x110211C", Slot = "4")]
		public IRequest Marshall(DeleteUserPoolRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x11029C0", Offset = "0x11029C0", VA = "0x11029C0")]
		internal static DeleteUserPoolRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x1102A88", Offset = "0x1102A88", VA = "0x1102A88")]
		public DeleteUserPoolRequestMarshaller()
		{
		}
	}
}
