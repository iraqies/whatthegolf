using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200009F")]
	public class ShardUnmarshaller : IUnmarshaller<Shard, XmlUnmarshallerContext>, IUnmarshaller<Shard, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x0")]
		private static ShardUnmarshaller _instance;

		[Token(Token = "0x170000E4")]
		public static ShardUnmarshaller Instance
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x12C6EF8", Offset = "0x12C6EF8", VA = "0x12C6EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x12C6A50", Offset = "0x12C6A50", VA = "0x12C6A50", Slot = "4")]
		private Shard Amazon_002ERuntime_002EInternal_002ETransform_002EIUnmarshaller_003CAmazon_002EKinesis_002EModel_002EShard_002CAmazon_002ERuntime_002EInternal_002ETransform_002EXmlUnmarshallerContext_003E_002EUnmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x12C6A90", Offset = "0x12C6A90", VA = "0x12C6A90", Slot = "5")]
		public Shard Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x12C6F5C", Offset = "0x12C6F5C", VA = "0x12C6F5C")]
		public ShardUnmarshaller()
		{
		}
	}
}
