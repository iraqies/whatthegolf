using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001266")]
	public static class FileIOUtil
	{
		[Token(Token = "0x40062FC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_LocalDirectory;

		[Token(Token = "0x60054FB")]
		[Address(RVA = "0x14623F8", Offset = "0x14623F8", VA = "0x14623F8")]
		public static SerializableLevelData[] GetAllLocalLevels()
		{
			return null;
		}

		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x14625BC", Offset = "0x14625BC", VA = "0x14625BC")]
		public static void SaveLevelLocal(SerializableLevelData serializableLevelData, bool isClone)
		{
		}

		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x14628EC", Offset = "0x14628EC", VA = "0x14628EC")]
		public static void DeleteLevelLocal(SerializableLevelData serializableLevelData)
		{
		}

		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x14629F4", Offset = "0x14629F4", VA = "0x14629F4")]
		public static LevelData Deserialize(this SerializableLevelData serializableLevelData, ElementDatabase elementDatabase)
		{
			return null;
		}

		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x1462AA8", Offset = "0x1462AA8", VA = "0x1462AA8")]
		public static string Serialize(this LevelContentData levelContentData)
		{
			return null;
		}

		[Token(Token = "0x6005500")]
		[Address(RVA = "0x1462DAC", Offset = "0x1462DAC", VA = "0x1462DAC")]
		public static LevelContentData DeserializeLevelContentData(string json, ElementDatabase elementDatabase)
		{
			return null;
		}
	}
}
