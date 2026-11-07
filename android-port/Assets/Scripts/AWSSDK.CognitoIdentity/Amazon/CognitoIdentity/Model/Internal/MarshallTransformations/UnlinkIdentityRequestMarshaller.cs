using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000091")]
	public class UnlinkIdentityRequestMarshaller : IMarshaller<IRequest, UnlinkIdentityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x0")]
		private static UnlinkIdentityRequestMarshaller _instance;

		[Token(Token = "0x170000DD")]
		public static UnlinkIdentityRequestMarshaller Instance
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x1184068", Offset = "0x1184068", VA = "0x1184068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x118329C", Offset = "0x118329C", VA = "0x118329C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1183330", Offset = "0x1183330", VA = "0x1183330", Slot = "4")]
		public IRequest Marshall(UnlinkIdentityRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1184004", Offset = "0x1184004", VA = "0x1184004")]
		internal static UnlinkIdentityRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x11840CC", Offset = "0x11840CC", VA = "0x11840CC")]
		public UnlinkIdentityRequestMarshaller()
		{
		}
	}
}
