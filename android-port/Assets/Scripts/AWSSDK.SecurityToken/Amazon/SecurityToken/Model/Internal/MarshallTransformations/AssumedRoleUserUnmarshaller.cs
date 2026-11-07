using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000032")]
	public class AssumedRoleUserUnmarshaller : IUnmarshaller<AssumedRoleUser, XmlUnmarshallerContext>, IUnmarshaller<AssumedRoleUser, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		private static AssumedRoleUserUnmarshaller _instance;

		[Token(Token = "0x17000053")]
		public static AssumedRoleUserUnmarshaller Instance
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x12DD070", Offset = "0x12DD070", VA = "0x12DD070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x12D7234", Offset = "0x12D7234", VA = "0x12D7234", Slot = "4")]
		public AssumedRoleUser Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x12DD068", Offset = "0x12DD068", VA = "0x12DD068", Slot = "5")]
		public AssumedRoleUser Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x12DD0D4", Offset = "0x12DD0D4", VA = "0x12DD0D4")]
		public AssumedRoleUserUnmarshaller()
		{
		}
	}
}
