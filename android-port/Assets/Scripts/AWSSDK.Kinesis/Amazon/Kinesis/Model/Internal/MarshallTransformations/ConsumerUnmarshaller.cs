using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005F")]
	public class ConsumerUnmarshaller : IUnmarshaller<Consumer, XmlUnmarshallerContext>, IUnmarshaller<Consumer, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x0")]
		private static ConsumerUnmarshaller _instance;

		[Token(Token = "0x170000A5")]
		public static ConsumerUnmarshaller Instance
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x12A2C94", Offset = "0x12A2C94", VA = "0x12A2C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x12A2830", Offset = "0x12A2830", VA = "0x12A2830", Slot = "4")]
		private Consumer Amazon_002ERuntime_002EInternal_002ETransform_002EIUnmarshaller_003CAmazon_002EKinesis_002EModel_002EConsumer_002CAmazon_002ERuntime_002EInternal_002ETransform_002EXmlUnmarshallerContext_003E_002EUnmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x12A2870", Offset = "0x12A2870", VA = "0x12A2870", Slot = "5")]
		public Consumer Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x12A2CF8", Offset = "0x12A2CF8", VA = "0x12A2CF8")]
		public ConsumerUnmarshaller()
		{
		}
	}
}
