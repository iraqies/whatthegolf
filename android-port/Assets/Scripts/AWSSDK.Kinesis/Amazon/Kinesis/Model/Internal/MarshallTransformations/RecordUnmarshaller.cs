using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000097")]
	public class RecordUnmarshaller : IUnmarshaller<Record, XmlUnmarshallerContext>, IUnmarshaller<Record, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x0")]
		private static RecordUnmarshaller _instance;

		[Token(Token = "0x170000DC")]
		public static RecordUnmarshaller Instance
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x12C304C", Offset = "0x12C304C", VA = "0x12C304C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x12C2B2C", Offset = "0x12C2B2C", VA = "0x12C2B2C", Slot = "4")]
		private Record Amazon_002ERuntime_002EInternal_002ETransform_002EIUnmarshaller_003CAmazon_002EKinesis_002EModel_002ERecord_002CAmazon_002ERuntime_002EInternal_002ETransform_002EXmlUnmarshallerContext_003E_002EUnmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x12C2B6C", Offset = "0x12C2B6C", VA = "0x12C2B6C", Slot = "5")]
		public Record Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x12C30B0", Offset = "0x12C30B0", VA = "0x12C30B0")]
		public RecordUnmarshaller()
		{
		}
	}
}
