using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util.Internal
{
	[Token(Token = "0x2000085")]
	public class NamedSettingsManager
	{
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x10")]
		private SettingsManager settingsManager;

		[Token(Token = "0x17000140")]
		public static bool IsAvailable
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x124041C", Offset = "0x124041C", VA = "0x124041C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1240424", Offset = "0x1240424", VA = "0x1240424")]
		public NamedSettingsManager(string settingsType)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x124049C", Offset = "0x124049C", VA = "0x124049C")]
		public string RegisterObject(string displayName, Dictionary<string, string> properties)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1240624", Offset = "0x1240624", VA = "0x1240624")]
		public bool TryGetObject(string displayName, out Dictionary<string, string> properties)
		{
			return default;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x12406A8", Offset = "0x12406A8", VA = "0x12406A8")]
		public bool TryGetObject(string displayName, out string uniqueKey, out Dictionary<string, string> properties)
		{
			return default;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1240728", Offset = "0x1240728", VA = "0x1240728")]
		public void UnregisterObject(string displayName)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x12407C0", Offset = "0x12407C0", VA = "0x12407C0")]
		public void RenameObject(string oldDisplayName, string newDisplayName, bool force)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x12409D8", Offset = "0x12409D8", VA = "0x12409D8")]
		public void CopyObject(string fromDisplayName, string toDisplayName, bool force)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1240BA4", Offset = "0x1240BA4", VA = "0x1240BA4")]
		public List<string> ListObjectNames()
		{
			return null;
		}
	}
}
