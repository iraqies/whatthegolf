using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x20012DE")]
	public static class PersistentStorage
	{
		[Token(Token = "0x20012DF")]
		public enum eFileType
		{
			[Token(Token = "0x40065AB")]
			Raw = 0,
			[Token(Token = "0x40065AC")]
			Persistent = 1,
			[Token(Token = "0x40065AD")]
			Temporal = 2,
			[Token(Token = "0x40065AE")]
			Streaming = 3
		}

		[Token(Token = "0x40065A9")]
		[FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x6005787")]
		[Address(RVA = "0x15E00E0", Offset = "0x15E00E0", VA = "0x15E00E0")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6005788")]
		[Address(RVA = "0x15E0198", Offset = "0x15E0198", VA = "0x15E0198")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6005789")]
		[Address(RVA = "0x15E0250", Offset = "0x15E0250", VA = "0x15E0250")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x600578A")]
		[Address(RVA = "0x15E0300", Offset = "0x15E0300", VA = "0x15E0300")]
		public static bool HasSetting(string key)
		{
			return default;
		}

		[Token(Token = "0x600578B")]
		[Address(RVA = "0x15E03B0", Offset = "0x15E03B0", VA = "0x15E03B0")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x600578C")]
		[Address(RVA = "0x15E0450", Offset = "0x15E0450", VA = "0x15E0450")]
		public static bool CanAccessFiles()
		{
			return default;
		}

		[Token(Token = "0x600578D")]
		[Address(RVA = "0x15E04F0", Offset = "0x15E04F0", VA = "0x15E04F0")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x600578E")]
		[Address(RVA = "0x15E05C0", Offset = "0x15E05C0", VA = "0x15E05C0")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600578F")]
		[Address(RVA = "0x15E0688", Offset = "0x15E0688", VA = "0x15E0688")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x6005790")]
		[Address(RVA = "0x15E0750", Offset = "0x15E0750", VA = "0x15E0750")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}
	}
}
