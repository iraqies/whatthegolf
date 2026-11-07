using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001EB")]
	public class ForgotPasswordRequestMarshaller : IMarshaller<IRequest, ForgotPasswordRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x0")]
		private static ForgotPasswordRequestMarshaller _instance;

		[Token(Token = "0x17000381")]
		public static ForgotPasswordRequestMarshaller Instance
		{
			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x1116324", Offset = "0x1116324", VA = "0x1116324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x11154B8", Offset = "0x11154B8", VA = "0x11154B8", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x111554C", Offset = "0x111554C", VA = "0x111554C", Slot = "4")]
		public IRequest Marshall(ForgotPasswordRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x11162C0", Offset = "0x11162C0", VA = "0x11162C0")]
		internal static ForgotPasswordRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x1116388", Offset = "0x1116388", VA = "0x1116388")]
		public ForgotPasswordRequestMarshaller()
		{
		}
	}
}
