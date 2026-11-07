using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Settings
{
	[Token(Token = "0x200023C")]
	public class InMemoryPersistenceManager : IPersistenceManager
	{
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, SettingsCollection> _settingsDictionary;

		[Token(Token = "0x6001102")]
		[Address(RVA = "0x12157D8", Offset = "0x12157D8", VA = "0x12157D8", Slot = "4")]
		public SettingsCollection GetSettings(string type)
		{
			return null;
		}

		[Token(Token = "0x6001103")]
		[Address(RVA = "0x12158A4", Offset = "0x12158A4", VA = "0x12158A4", Slot = "5")]
		public void SaveSettings(string type, SettingsCollection settings)
		{
		}

		[Token(Token = "0x6001104")]
		[Address(RVA = "0x1215910", Offset = "0x1215910", VA = "0x1215910")]
		public InMemoryPersistenceManager()
		{
		}
	}
}
