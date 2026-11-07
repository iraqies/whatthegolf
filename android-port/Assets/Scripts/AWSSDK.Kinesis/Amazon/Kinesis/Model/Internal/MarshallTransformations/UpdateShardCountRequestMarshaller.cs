using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000A9")]
	public class UpdateShardCountRequestMarshaller : IMarshaller<IRequest, UpdateShardCountRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x0")]
		private static UpdateShardCountRequestMarshaller _instance;

		[Token(Token = "0x170000EE")]
		public static UpdateShardCountRequestMarshaller Instance
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x12CE790", Offset = "0x12CE790", VA = "0x12CE790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x12CDC3C", Offset = "0x12CDC3C", VA = "0x12CDC3C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x12CDCD0", Offset = "0x12CDCD0", VA = "0x12CDCD0", Slot = "4")]
		public IRequest Marshall(UpdateShardCountRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x12CE72C", Offset = "0x12CE72C", VA = "0x12CE72C")]
		internal static UpdateShardCountRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x12CE7F4", Offset = "0x12CE7F4", VA = "0x12CE7F4")]
		public UpdateShardCountRequestMarshaller()
		{
		}
	}
}
