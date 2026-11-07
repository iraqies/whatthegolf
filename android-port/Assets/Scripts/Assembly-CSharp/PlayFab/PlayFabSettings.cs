using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001190")]
	public static class PlayFabSettings
	{
		[Serializable]
		[Token(Token = "0x2001191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4814C", Offset = "0x4814C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005EF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x6005042")]
			[Address(RVA = "0x1828280", Offset = "0x1828280", VA = "0x1828280")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005043")]
			[Address(RVA = "0x1828288", Offset = "0x1828288", VA = "0x1828288")]
			internal PlayFabSharedSettings _003C_002Ecctor_003Eb__0_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4005EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayFabSharedSettings _playFabShared;

		[Token(Token = "0x4005EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly PlayFabApiSettings staticSettings;

		[Token(Token = "0x4005EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly PlayFabAuthenticationContext staticPlayer;

		[Token(Token = "0x170008A6")]
		private static PlayFabSharedSettings PlayFabSharedPrivate
		{
			[Token(Token = "0x6005039")]
			[Address(RVA = "0x15EFFF8", Offset = "0x15EFFF8", VA = "0x15EFFF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A7")]
		public static string DeviceUniqueIdentifier
		{
			[Token(Token = "0x600503B")]
			[Address(RVA = "0x15F01F0", Offset = "0x15F01F0", VA = "0x15F01F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A8")]
		public static string TitleId
		{
			[Token(Token = "0x600503C")]
			[Address(RVA = "0x15EC338", Offset = "0x15EC338", VA = "0x15EC338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A9")]
		public static bool DisableFocusTimeCollection
		{
			[Token(Token = "0x600503D")]
			[Address(RVA = "0x15ED0C8", Offset = "0x15ED0C8", VA = "0x15ED0C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170008AA")]
		public static string LoggerHost
		{
			[Token(Token = "0x600503E")]
			[Address(RVA = "0x15EF0D8", Offset = "0x15EF0D8", VA = "0x15EF0D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AB")]
		public static bool EnableRealTimeLogging
		{
			[Token(Token = "0x600503F")]
			[Address(RVA = "0x15EF5D4", Offset = "0x15EF5D4", VA = "0x15EF5D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005038")]
		[Address(RVA = "0x15EFE6C", Offset = "0x15EFE6C", VA = "0x15EFE6C")]
		static PlayFabSettings()
		{
		}

		[Token(Token = "0x600503A")]
		[Address(RVA = "0x15F00F0", Offset = "0x15F00F0", VA = "0x15F00F0")]
		private static PlayFabSharedSettings GetSharedSettingsObjectPrivate()
		{
			return null;
		}

		[Token(Token = "0x6005040")]
		[Address(RVA = "0x15F01F8", Offset = "0x15F01F8", VA = "0x15F01F8")]
		public static string GetFullUrl(string apiCall, Dictionary<string, string> getParams, [Optional] PlayFabApiSettings apiSettings)
		{
			return null;
		}
	}
}
