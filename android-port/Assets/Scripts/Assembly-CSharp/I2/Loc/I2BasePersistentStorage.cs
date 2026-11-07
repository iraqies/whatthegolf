using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x20012E0")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x6005791")]
		[Address(RVA = "0x14DF884", Offset = "0x14DF884", VA = "0x14DF884", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6005792")]
		[Address(RVA = "0x14DFB18", Offset = "0x14DFB18", VA = "0x14DFB18", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6005793")]
		[Address(RVA = "0x14DFD8C", Offset = "0x14DFD8C", VA = "0x14DFD8C", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6005794")]
		[Address(RVA = "0x14DFFC4", Offset = "0x14DFFC4", VA = "0x14DFFC4", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6005795")]
		[Address(RVA = "0x14DFFCC", Offset = "0x14DFFCC", VA = "0x14DFFCC", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default;
		}

		[Token(Token = "0x6005796")]
		[Address(RVA = "0x14DFFD8", Offset = "0x14DFFD8", VA = "0x14DFFD8", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default;
		}

		[Token(Token = "0x6005797")]
		[Address(RVA = "0x14DFFE0", Offset = "0x14DFFE0", VA = "0x14DFFE0")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x6005798")]
		[Address(RVA = "0x14E0094", Offset = "0x14E0094", VA = "0x14E0094", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x6005799")]
		[Address(RVA = "0x14E028C", Offset = "0x14E028C", VA = "0x14E028C", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600579A")]
		[Address(RVA = "0x14E047C", Offset = "0x14E047C", VA = "0x14E047C", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x600579B")]
		[Address(RVA = "0x14E065C", Offset = "0x14E065C", VA = "0x14E065C", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x600579C")]
		[Address(RVA = "0x14E0838", Offset = "0x14E0838", VA = "0x14E0838")]
		protected I2BasePersistentStorage()
		{
		}
	}
}
