using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008C")]
	public class TagResourceRequestMarshaller : IMarshaller<IRequest, TagResourceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private static TagResourceRequestMarshaller _instance;

		[Token(Token = "0x170000D8")]
		public static TagResourceRequestMarshaller Instance
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1181088", Offset = "0x1181088", VA = "0x1181088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x11804AC", Offset = "0x11804AC", VA = "0x11804AC", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1180540", Offset = "0x1180540", VA = "0x1180540", Slot = "4")]
		public IRequest Marshall(TagResourceRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1181024", Offset = "0x1181024", VA = "0x1181024")]
		internal static TagResourceRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x11810EC", Offset = "0x11810EC", VA = "0x11810EC")]
		public TagResourceRequestMarshaller()
		{
		}
	}
}
