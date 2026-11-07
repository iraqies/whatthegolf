using System;
using System.IO;
using ThirdParty.MD5;

namespace Amazon.Runtime.Internal.Util
{
	public class HashingWrapper : IHashingWrapper, IDisposable
	{
		private static string MD5ManagedName;

		private MD5Managed _algorithm;

		public HashingWrapper(string algorithmName)
		{
		}

		public void AppendBlock(byte[] buffer)
		{
		}

		public byte[] AppendLastBlock(byte[] buffer)
		{
			return null;
		}

		public void Dispose()
		{
		}

		private void Init(string algorithmName)
		{
		}

		public void Clear()
		{
		}

		public byte[] ComputeHash(byte[] buffer)
		{
			return null;
		}

		public byte[] ComputeHash(Stream stream)
		{
			return null;
		}

		public void AppendBlock(byte[] buffer, int offset, int count)
		{
		}

		public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
		{
			return null;
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
