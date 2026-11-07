using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Settings
{
	[Token(Token = "0x200023D")]
	public class PersistenceManager : IPersistenceManager
	{
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<string> ENCRYPTEDKEYS;

		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Logger _logger;

		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, SettingsWatcher> _watchers;

		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x10")]
		private static string SettingsStoreFolder;

		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C88", Offset = "0x27C88")]
		private static IPersistenceManager Instance__BackingField;

		[Token(Token = "0x17000441")]
		public static IPersistenceManager Instance
		{
			[Token(Token = "0x6001106")]
			[Address(RVA = "0x124A1BC", Offset = "0x124A1BC", VA = "0x124A1BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF00", Offset = "0x2BF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001107")]
			[Address(RVA = "0x124A220", Offset = "0x124A220", VA = "0x124A220")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BF10", Offset = "0x2BF10")]
			set
			{
			}
		}

		[Token(Token = "0x6001105")]
		[Address(RVA = "0x1249B40", Offset = "0x1249B40", VA = "0x1249B40")]
		static PersistenceManager()
		{
		}

		[Token(Token = "0x6001108")]
		[Address(RVA = "0x124A290", Offset = "0x124A290", VA = "0x124A290", Slot = "4")]
		public SettingsCollection GetSettings(string type)
		{
			return null;
		}

		[Token(Token = "0x6001109")]
		[Address(RVA = "0x124A78C", Offset = "0x124A78C", VA = "0x124A78C", Slot = "5")]
		public void SaveSettings(string type, SettingsCollection settings)
		{
		}

		[Token(Token = "0x600110A")]
		[Address(RVA = "0x124ACC8", Offset = "0x124ACC8", VA = "0x124ACC8")]
		public string GetSetting(string key)
		{
			return null;
		}

		[Token(Token = "0x600110B")]
		[Address(RVA = "0x124AD3C", Offset = "0x124AD3C", VA = "0x124AD3C")]
		public void SetSetting(string key, string value)
		{
		}

		[Token(Token = "0x600110C")]
		[Address(RVA = "0x124ADD8", Offset = "0x124ADD8", VA = "0x124ADD8")]
		public static string GetSettingsStoreFolder()
		{
			return null;
		}

		[Token(Token = "0x600110D")]
		[Address(RVA = "0x124AE3C", Offset = "0x124AE3C", VA = "0x124AE3C")]
		public SettingsWatcher Watch(string type)
		{
			return null;
		}

		[Token(Token = "0x600110E")]
		[Address(RVA = "0x124B020", Offset = "0x124B020", VA = "0x124B020")]
		private void enableWatcher(string type)
		{
		}

		[Token(Token = "0x600110F")]
		[Address(RVA = "0x124B0AC", Offset = "0x124B0AC", VA = "0x124B0AC")]
		private void disableWatcher(string type)
		{
		}

		[Token(Token = "0x6001110")]
		[Address(RVA = "0x124B134", Offset = "0x124B134", VA = "0x124B134")]
		internal static bool IsEncrypted(string key)
		{
			return default;
		}

		[Token(Token = "0x6001111")]
		[Address(RVA = "0x124A790", Offset = "0x124A790", VA = "0x124A790")]
		private void saveSettingsType(string type, SettingsCollection settings)
		{
		}

		[Token(Token = "0x6001112")]
		[Address(RVA = "0x124A294", Offset = "0x124A294", VA = "0x124A294")]
		private SettingsCollection loadSettingsType(string type)
		{
			return null;
		}

		[Token(Token = "0x6001113")]
		[Address(RVA = "0x124B1C8", Offset = "0x124B1C8", VA = "0x124B1C8")]
		private static void DecryptAnyEncryptedValues(Dictionary<string, Dictionary<string, object>> settings)
		{
		}

		[Token(Token = "0x6001114")]
		[Address(RVA = "0x124AF1C", Offset = "0x124AF1C", VA = "0x124AF1C")]
		private static string getFileFromType(string type)
		{
			return null;
		}

		[Token(Token = "0x6001115")]
		[Address(RVA = "0x124A13C", Offset = "0x124A13C", VA = "0x124A13C")]
		public PersistenceManager()
		{
		}
	}
}
