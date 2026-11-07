using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001E9")]
	public class ForgetDeviceRequestMarshaller : IMarshaller<IRequest, ForgetDeviceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x0")]
		private static ForgetDeviceRequestMarshaller _instance;

		[Token(Token = "0x1700037F")]
		public static ForgetDeviceRequestMarshaller Instance
		{
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x111439C", Offset = "0x111439C", VA = "0x111439C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x1113994", Offset = "0x1113994", VA = "0x1113994", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x1113A28", Offset = "0x1113A28", VA = "0x1113A28", Slot = "4")]
		public IRequest Marshall(ForgetDeviceRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x1114338", Offset = "0x1114338", VA = "0x1114338")]
		internal static ForgetDeviceRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x1114400", Offset = "0x1114400", VA = "0x1114400")]
		public ForgetDeviceRequestMarshaller()
		{
		}
	}
}
