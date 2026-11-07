using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20000A8")]
	public class TagUnmarshaller : IUnmarshaller<Tag, XmlUnmarshallerContext>, IUnmarshaller<Tag, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x0")]
		private static TagUnmarshaller _instance;

		[Token(Token = "0x170000ED")]
		public static TagUnmarshaller Instance
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x12CD9C8", Offset = "0x12CD9C8", VA = "0x12CD9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x12CD740", Offset = "0x12CD740", VA = "0x12CD740", Slot = "4")]
		private Tag Amazon_002ERuntime_002EInternal_002ETransform_002EIUnmarshaller_003CAmazon_002EKinesis_002EModel_002ETag_002CAmazon_002ERuntime_002EInternal_002ETransform_002EXmlUnmarshallerContext_003E_002EUnmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x12CD780", Offset = "0x12CD780", VA = "0x12CD780", Slot = "5")]
		public Tag Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x12CDA2C", Offset = "0x12CDA2C", VA = "0x12CDA2C")]
		public TagUnmarshaller()
		{
		}
	}
}
