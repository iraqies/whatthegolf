using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200022F")]
	public class DateTimeEpochLongMillisecondsUnmarshaller : IUnmarshaller<DateTime, XmlUnmarshallerContext>, IUnmarshaller<DateTime, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x0")]
		private static DateTimeEpochLongMillisecondsUnmarshaller _instance;

		[Token(Token = "0x17000423")]
		public static DateTimeEpochLongMillisecondsUnmarshaller Instance
		{
			[Token(Token = "0x600109D")]
			[Address(RVA = "0x11EC820", Offset = "0x11EC820", VA = "0x11EC820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600109C")]
		[Address(RVA = "0x11EC818", Offset = "0x11EC818", VA = "0x11EC818")]
		private DateTimeEpochLongMillisecondsUnmarshaller()
		{
		}

		[Token(Token = "0x600109E")]
		[Address(RVA = "0x11EC884", Offset = "0x11EC884", VA = "0x11EC884")]
		public static DateTimeEpochLongMillisecondsUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600109F")]
		[Address(RVA = "0x11EC920", Offset = "0x11EC920", VA = "0x11EC920", Slot = "4")]
		public DateTime Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x11EC974", Offset = "0x11EC974", VA = "0x11EC974", Slot = "5")]
		public DateTime Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
