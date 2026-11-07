using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000035")]
	public class AssumeRoleWithSAMLRequestMarshaller : IMarshaller<IRequest, AssumeRoleWithSAMLRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		private static AssumeRoleWithSAMLRequestMarshaller _instance;

		[Token(Token = "0x17000056")]
		public static AssumeRoleWithSAMLRequestMarshaller Instance
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x12D931C", Offset = "0x12D931C", VA = "0x12D931C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x12D8564", Offset = "0x12D8564", VA = "0x12D8564", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x12D85F8", Offset = "0x12D85F8", VA = "0x12D85F8", Slot = "4")]
		public IRequest Marshall(AssumeRoleWithSAMLRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x12D92B8", Offset = "0x12D92B8", VA = "0x12D92B8")]
		internal static AssumeRoleWithSAMLRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x12D9380", Offset = "0x12D9380", VA = "0x12D9380")]
		public AssumeRoleWithSAMLRequestMarshaller()
		{
		}
	}
}
