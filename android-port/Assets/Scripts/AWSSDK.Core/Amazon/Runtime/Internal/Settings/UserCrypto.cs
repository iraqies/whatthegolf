using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Settings
{
	[Token(Token = "0x2000243")]
	public static class UserCrypto
	{
		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		[Token(Token = "0x2000244")]
		private struct DATA_BLOB
		{
			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int cbData;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IntPtr pbData;
		}

		[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
		[Token(Token = "0x2000245")]
		private struct CRYPTPROTECT_PROMPTSTRUCT
		{
			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int cbSize;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public CryptProtectPromptFlags dwPromptFlags;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IntPtr hwndApp;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string szPrompt;
		}

		[Token(Token = "0x2000246")]
		[Flags]
		private enum CryptProtectPromptFlags
		{
			[Token(Token = "0x4000844")]
			CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
			[Token(Token = "0x4000845")]
			CRYPTPROTECT_PROMPT_ON_PROTECT = 2
		}

		[Token(Token = "0x2000247")]
		[Flags]
		private enum CryptProtectFlags
		{
			[Token(Token = "0x4000847")]
			CRYPTPROTECT_UI_FORBIDDEN = 1,
			[Token(Token = "0x4000848")]
			CRYPTPROTECT_LOCAL_MACHINE = 4,
			[Token(Token = "0x4000849")]
			CRYPTPROTECT_CRED_SYNC = 8,
			[Token(Token = "0x400084A")]
			CRYPTPROTECT_AUDIT = 0x10,
			[Token(Token = "0x400084B")]
			CRYPTPROTECT_NO_RECOVERY = 0x20,
			[Token(Token = "0x400084C")]
			CRYPTPROTECT_VERIFY_PROTECTION = 0x40
		}

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool? _isUserCryptAvailable;

		[Token(Token = "0x1700044C")]
		public static bool IsUserCryptAvailable
		{
			[Token(Token = "0x6001142")]
			[Address(RVA = "0x1272720", Offset = "0x1272720", VA = "0x1272720")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600113D")]
		[Address(RVA = "0x1280D90", Offset = "0x1280D90", VA = "0x1280D90")]
		public static string Decrypt(string encrypted)
		{
			return null;
		}

		[Token(Token = "0x600113E")]
		[Address(RVA = "0x1281384", Offset = "0x1281384", VA = "0x1281384")]
		public static string Encrypt(string unencrypted)
		{
			return null;
		}

		[Token(Token = "0x600113F")]
		[Address(RVA = "0x12811C4", Offset = "0x12811C4", VA = "0x12811C4")]
		private static DATA_BLOB ConvertData(byte[] data)
		{
			return default;
		}

		[PreserveSig]
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x1281870", Offset = "0x1281870", VA = "0x1281870")]
		private static extern bool CryptProtectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, CryptProtectFlags dwFlags, ref DATA_BLOB pDataOut);

		[PreserveSig]
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x1281264", Offset = "0x1281264", VA = "0x1281264")]
		private static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, CryptProtectFlags dwFlags, ref DATA_BLOB pDataOut);
	}
}
