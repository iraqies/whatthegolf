using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000048")]
	public class DeleteDatasetRequestMarshaller : IMarshaller<IRequest, DeleteDatasetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteDatasetRequestMarshaller _instance;

		[Token(Token = "0x17000080")]
		public static DeleteDatasetRequestMarshaller Instance
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1194314", Offset = "0x1194314", VA = "0x1194314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1193BE8", Offset = "0x1193BE8", VA = "0x1193BE8", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1193C7C", Offset = "0x1193C7C", VA = "0x1193C7C", Slot = "4")]
		public IRequest Marshall(DeleteDatasetRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x11942B0", Offset = "0x11942B0", VA = "0x11942B0")]
		internal static DeleteDatasetRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1194378", Offset = "0x1194378", VA = "0x1194378")]
		public DeleteDatasetRequestMarshaller()
		{
		}
	}
}
