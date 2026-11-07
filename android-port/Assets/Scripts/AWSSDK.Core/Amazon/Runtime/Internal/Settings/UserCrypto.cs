using System;
using System.Runtime.InteropServices;

namespace Amazon.Runtime.Internal.Settings
{
	public static class UserCrypto
	{
		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		private struct DATA_BLOB
		{
			public int cbData;

			public IntPtr pbData;
		}

		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		private struct CRYPTPROTECT_PROMPTSTRUCT
		{
			public int cbSize;

			public CryptProtectPromptFlags dwPromptFlags;

			public IntPtr hwndApp;

			public string szPrompt;
		}

		[Flags]
		private enum CryptProtectPromptFlags
		{
			CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
			CRYPTPROTECT_PROMPT_ON_PROTECT = 2
		}

		[Flags]
		private enum CryptProtectFlags
		{
			CRYPTPROTECT_UI_FORBIDDEN = 1,
			CRYPTPROTECT_LOCAL_MACHINE = 4,
			CRYPTPROTECT_CRED_SYNC = 8,
			CRYPTPROTECT_AUDIT = 0x10,
			CRYPTPROTECT_NO_RECOVERY = 0x20,
			CRYPTPROTECT_VERIFY_PROTECTION = 0x40
		}

		private static bool? _isUserCryptAvailable;

		public static bool IsUserCryptAvailable => false;

		public static string Decrypt(string encrypted)
		{
			return null;
		}

		public static string Encrypt(string unencrypted)
		{
			return null;
		}

		private static DATA_BLOB ConvertData(byte[] data)
		{
			return default;
		}

		[PreserveSig]
		private static extern bool CryptProtectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, CryptProtectFlags dwFlags, ref DATA_BLOB pDataOut);

		[PreserveSig]
		private static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, CryptProtectFlags dwFlags, ref DATA_BLOB pDataOut);
	}
}
