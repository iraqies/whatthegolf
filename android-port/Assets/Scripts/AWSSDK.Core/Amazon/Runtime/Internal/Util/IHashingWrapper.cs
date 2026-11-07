using System;
using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001CD")]
	public interface IHashingWrapper : IDisposable
	{
		[Token(Token = "0x6000E2B")]
		void Clear();

		[Token(Token = "0x6000E2C")]
		byte[] ComputeHash(byte[] buffer);

		[Token(Token = "0x6000E2D")]
		byte[] ComputeHash(Stream stream);

		[Token(Token = "0x6000E2E")]
		void AppendBlock(byte[] buffer);

		[Token(Token = "0x6000E2F")]
		void AppendBlock(byte[] buffer, int offset, int count);

		[Token(Token = "0x6000E30")]
		byte[] AppendLastBlock(byte[] buffer);

		[Token(Token = "0x6000E31")]
		byte[] AppendLastBlock(byte[] buffer, int offset, int count);
	}
}
