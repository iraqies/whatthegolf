using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200003D")]
	public class FederatedUserUnmarshaller : IUnmarshaller<FederatedUser, XmlUnmarshallerContext>, IUnmarshaller<FederatedUser, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		private static FederatedUserUnmarshaller _instance;

		[Token(Token = "0x1700005E")]
		public static FederatedUserUnmarshaller Instance
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x12DE954", Offset = "0x12DE954", VA = "0x12DE954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x12DE6B4", Offset = "0x12DE6B4", VA = "0x12DE6B4", Slot = "4")]
		public FederatedUser Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x12DE94C", Offset = "0x12DE94C", VA = "0x12DE94C", Slot = "5")]
		public FederatedUser Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x12DE9B8", Offset = "0x12DE9B8", VA = "0x12DE9B8")]
		public FederatedUserUnmarshaller()
		{
		}
	}
}
