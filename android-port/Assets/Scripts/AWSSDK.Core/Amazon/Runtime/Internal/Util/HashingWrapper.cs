using System;
using System.IO;
using Il2CppDummyDll;
using ThirdParty.MD5;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001C7")]
	public class HashingWrapper : IHashingWrapper, IDisposable
	{
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x0")]
		private static string MD5ManagedName;

		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x10")]
		private MD5Managed _algorithm;

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x120DFF8", Offset = "0x120DFF8", VA = "0x120DFF8")]
		public HashingWrapper(string algorithmName)
		{
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x120E180", Offset = "0x120E180", VA = "0x120E180", Slot = "7")]
		public void AppendBlock(byte[] buffer)
		{
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x120E1C8", Offset = "0x120E1C8", VA = "0x120E1C8", Slot = "9")]
		public byte[] AppendLastBlock(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x120E210", Offset = "0x120E210", VA = "0x120E210", Slot = "11")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x120E080", Offset = "0x120E080", VA = "0x120E080")]
		private void Init(string algorithmName)
		{
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x120E290", Offset = "0x120E290", VA = "0x120E290", Slot = "4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x120E2B4", Offset = "0x120E2B4", VA = "0x120E2B4", Slot = "5")]
		public byte[] ComputeHash(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x120E2D0", Offset = "0x120E2D0", VA = "0x120E2D0", Slot = "6")]
		public byte[] ComputeHash(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x120E1AC", Offset = "0x120E1AC", VA = "0x120E1AC", Slot = "8")]
		public void AppendBlock(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x120E1F4", Offset = "0x120E1F4", VA = "0x120E1F4", Slot = "10")]
		public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
		{
			return null;
		}

		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x120E2EC", Offset = "0x120E2EC", VA = "0x120E2EC", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
