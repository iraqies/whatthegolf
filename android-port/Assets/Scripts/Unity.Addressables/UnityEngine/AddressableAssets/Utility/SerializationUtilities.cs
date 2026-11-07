using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets.Utility
{
	[Token(Token = "0x2000046")]
	internal static class SerializationUtilities
	{
		[Token(Token = "0x2000047")]
		internal enum ObjectType
		{
			[Token(Token = "0x40000C4")]
			AsciiString = 0,
			[Token(Token = "0x40000C5")]
			UnicodeString = 1,
			[Token(Token = "0x40000C6")]
			UInt16 = 2,
			[Token(Token = "0x40000C7")]
			UInt32 = 3,
			[Token(Token = "0x40000C8")]
			Int32 = 4,
			[Token(Token = "0x40000C9")]
			Hash128 = 5,
			[Token(Token = "0x40000CA")]
			Type = 6,
			[Token(Token = "0x40000CB")]
			JsonObject = 7
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2A2BD00", Offset = "0x2A2BD00", VA = "0x2A2BD00")]
		internal static int ReadInt32FromByteArray(byte[] data, int offset)
		{
			return default;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2A38894", Offset = "0x2A38894", VA = "0x2A38894")]
		internal static int WriteInt32ToByteArray(byte[] data, int val, int offset)
		{
			return default;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2A2BD74", Offset = "0x2A2BD74", VA = "0x2A2BD74")]
		internal static object ReadObjectFromByteArray(byte[] keyData, int dataIndex)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2A36D2C", Offset = "0x2A36D2C", VA = "0x2A36D2C")]
		internal static int WriteObjectToByteList(object obj, List<byte> buffer)
		{
			return default;
		}
	}
}
