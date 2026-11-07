using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200022E")]
	public class NullableDateTimeUnmarshaller : IUnmarshaller<DateTime?, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x0")]
		private static NullableDateTimeUnmarshaller _instance;

		[Token(Token = "0x17000422")]
		public static NullableDateTimeUnmarshaller Instance
		{
			[Token(Token = "0x6001098")]
			[Address(RVA = "0x12433CC", Offset = "0x12433CC", VA = "0x12433CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0x12433C4", Offset = "0x12433C4", VA = "0x12433C4")]
		private NullableDateTimeUnmarshaller()
		{
		}

		[Token(Token = "0x6001099")]
		[Address(RVA = "0x1243430", Offset = "0x1243430", VA = "0x1243430")]
		public static NullableDateTimeUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600109A")]
		[Address(RVA = "0x12434CC", Offset = "0x12434CC", VA = "0x12434CC", Slot = "4")]
		public DateTime? Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
