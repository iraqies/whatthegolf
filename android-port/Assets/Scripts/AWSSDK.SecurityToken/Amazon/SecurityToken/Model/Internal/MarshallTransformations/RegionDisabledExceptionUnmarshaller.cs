using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200004C")]
	public class RegionDisabledExceptionUnmarshaller : IErrorResponseUnmarshaller<RegionDisabledException, XmlUnmarshallerContext>, IUnmarshaller<RegionDisabledException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		private static RegionDisabledExceptionUnmarshaller _instance;

		[Token(Token = "0x1700006D")]
		public static RegionDisabledExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x12E44A0", Offset = "0x12E44A0", VA = "0x12E44A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x12E4438", Offset = "0x12E4438", VA = "0x12E4438", Slot = "5")]
		public RegionDisabledException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x12D80BC", Offset = "0x12D80BC", VA = "0x12D80BC", Slot = "4")]
		public RegionDisabledException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x12E4504", Offset = "0x12E4504", VA = "0x12E4504")]
		public RegionDisabledExceptionUnmarshaller()
		{
		}
	}
}
