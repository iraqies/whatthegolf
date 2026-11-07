using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200022D")]
	public class DateTimeUnmarshaller : IUnmarshaller<DateTime, XmlUnmarshallerContext>, IUnmarshaller<DateTime, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x0")]
		private static DateTimeUnmarshaller _instance;

		[Token(Token = "0x17000421")]
		public static DateTimeUnmarshaller Instance
		{
			[Token(Token = "0x6001091")]
			[Address(RVA = "0x11ECAFC", Offset = "0x11ECAFC", VA = "0x11ECAFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001090")]
		[Address(RVA = "0x11ECAF4", Offset = "0x11ECAF4", VA = "0x11ECAF4")]
		private DateTimeUnmarshaller()
		{
		}

		[Token(Token = "0x6001092")]
		[Address(RVA = "0x11ECB60", Offset = "0x11ECB60", VA = "0x11ECB60")]
		public static DateTimeUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001093")]
		[Address(RVA = "0x11ECBFC", Offset = "0x11ECBFC", VA = "0x11ECBFC", Slot = "4")]
		public DateTime Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x6001094")]
		[Address(RVA = "0x11ECE90", Offset = "0x11ECE90", VA = "0x11ECE90", Slot = "5")]
		public DateTime Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x6001095")]
		[Address(RVA = "0x11ECCBC", Offset = "0x11ECCBC", VA = "0x11ECCBC")]
		internal static DateTime? UnmarshallInternal(string text, bool treatAsNullable)
		{
			return null;
		}
	}
}
