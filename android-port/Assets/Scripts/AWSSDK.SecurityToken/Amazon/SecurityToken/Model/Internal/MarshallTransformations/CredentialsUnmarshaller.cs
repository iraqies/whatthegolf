using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000039")]
	public class CredentialsUnmarshaller : IUnmarshaller<Credentials, XmlUnmarshallerContext>, IUnmarshaller<Credentials, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x0")]
		private static CredentialsUnmarshaller _instance;

		[Token(Token = "0x1700005A")]
		public static CredentialsUnmarshaller Instance
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x12DD3B0", Offset = "0x12DD3B0", VA = "0x12DD3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x12D74CC", Offset = "0x12D74CC", VA = "0x12D74CC", Slot = "4")]
		public Credentials Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x12DD3A8", Offset = "0x12DD3A8", VA = "0x12DD3A8", Slot = "5")]
		public Credentials Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x12DD414", Offset = "0x12DD414", VA = "0x12DD414")]
		public CredentialsUnmarshaller()
		{
		}
	}
}
