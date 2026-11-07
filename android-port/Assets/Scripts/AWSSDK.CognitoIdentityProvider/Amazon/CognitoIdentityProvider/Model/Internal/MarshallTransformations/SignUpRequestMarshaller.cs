using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000254")]
	public class SignUpRequestMarshaller : IMarshaller<IRequest, SignUpRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x0")]
		private static SignUpRequestMarshaller _instance;

		[Token(Token = "0x170003DD")]
		public static SignUpRequestMarshaller Instance
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x1155174", Offset = "0x1155174", VA = "0x1155174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x1153E04", Offset = "0x1153E04", VA = "0x1153E04", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x1153E98", Offset = "0x1153E98", VA = "0x1153E98", Slot = "4")]
		public IRequest Marshall(SignUpRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x1155110", Offset = "0x1155110", VA = "0x1155110")]
		internal static SignUpRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x11551D8", Offset = "0x11551D8", VA = "0x11551D8")]
		public SignUpRequestMarshaller()
		{
		}
	}
}
