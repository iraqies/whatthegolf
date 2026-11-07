using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Settings;
using Il2CppDummyDll;

namespace Amazon.Util.Internal
{
	[Token(Token = "0x2000086")]
	public class SettingsManager
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x259AC", Offset = "0x259AC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000283")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000284")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SettingsCollection.ObjectSettings, string> _003C_003E9__11_0;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1296950", Offset = "0x1296950", VA = "0x1296950")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x1296958", Offset = "0x1296958", VA = "0x1296958")]
			internal string _003CListUniqueKeys_003Eb__11_0(SettingsCollection.ObjectSettings x)
			{
				return null;
			}
		}

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x259BC", Offset = "0x259BC")]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			[Token(Token = "0x4000285")]
			[FieldOffset(Offset = "0x10")]
			public string propertyName;

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1296970", Offset = "0x1296970", VA = "0x1296970")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1296978", Offset = "0x1296978", VA = "0x1296978")]
			internal string _003CSelectProperty_003Eb__0(SettingsCollection.ObjectSettings x)
			{
				return null;
			}
		}

		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x259CC", Offset = "0x259CC")]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			[Token(Token = "0x4000286")]
			[FieldOffset(Offset = "0x10")]
			public string propertyName;

			[Token(Token = "0x4000287")]
			[FieldOffset(Offset = "0x18")]
			public string value;

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x1296A28", Offset = "0x1296A28", VA = "0x1296A28")]
			public _003C_003Ec__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1296A30", Offset = "0x1296A30", VA = "0x1296A30")]
			internal bool _003CTryGetObjectSettings_003Eb__0(SettingsCollection.ObjectSettings x)
			{
				return default;
			}
		}

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x259DC", Offset = "0x259DC")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x4000288")]
			[FieldOffset(Offset = "0x10")]
			public string uniqueKey;

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1296AF4", Offset = "0x1296AF4", VA = "0x1296AF4")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1296AFC", Offset = "0x1296AFC", VA = "0x1296AFC")]
			internal bool _003CTryGetObjectSettings_003Eb__0(SettingsCollection.ObjectSettings x)
			{
				return default;
			}
		}

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26678", Offset = "0x26678")]
		private string SettingsType__BackingField;

		[Token(Token = "0x17000141")]
		public static bool IsAvailable
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x126EBE0", Offset = "0x126EBE0", VA = "0x126EBE0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000142")]
		public string SettingsType
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1272A40", Offset = "0x1272A40", VA = "0x1272A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2894C", Offset = "0x2894C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1272A48", Offset = "0x1272A48", VA = "0x1272A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2895C", Offset = "0x2895C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x126EC74", Offset = "0x126EC74", VA = "0x126EC74")]
		public SettingsManager(string settingsType)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1272A50", Offset = "0x1272A50", VA = "0x1272A50")]
		public string RegisterObject(Dictionary<string, string> properties)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x126F75C", Offset = "0x126F75C", VA = "0x126F75C")]
		public string RegisterObject(string uniqueKey, Dictionary<string, string> properties)
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x126F2A8", Offset = "0x126F2A8", VA = "0x126F2A8")]
		public bool TryGetObject(string uniqueKey, out Dictionary<string, string> properties)
		{
			return default;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1272DD4", Offset = "0x1272DD4", VA = "0x1272DD4")]
		public bool TryGetObjectByProperty(string propertyName, string value, out string uniqueKey, out Dictionary<string, string> properties)
		{
			return default;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x126EDFC", Offset = "0x126EDFC", VA = "0x126EDFC")]
		public List<string> ListUniqueKeys()
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x12732CC", Offset = "0x12732CC", VA = "0x12732CC")]
		public List<string> SelectProperty(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x126EFA0", Offset = "0x126EFA0", VA = "0x126EFA0")]
		public void UnregisterObject(string uniqueKey)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1272A5C", Offset = "0x1272A5C", VA = "0x1272A5C")]
		private SettingsCollection GetSettings()
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1272C98", Offset = "0x1272C98", VA = "0x1272C98")]
		private void SaveSettings(SettingsCollection settings)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x12731BC", Offset = "0x12731BC", VA = "0x12731BC")]
		private static bool TryGetObjectSettings(string propertyName, string value, SettingsCollection settings, out SettingsCollection.ObjectSettings objectSettings)
		{
			return default;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1272B8C", Offset = "0x1272B8C", VA = "0x1272B8C")]
		private static bool TryGetObjectSettings(string uniqueKey, SettingsCollection settings, out SettingsCollection.ObjectSettings objectSettings)
		{
			return default;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x12729D8", Offset = "0x12729D8", VA = "0x12729D8")]
		private static void EnsureAvailable()
		{
		}
	}
}
