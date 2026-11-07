using System;
using System.IO;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.Internal.Transform
{
	public abstract class UnmarshallerContext : IDisposable
	{
		private bool disposed;

		protected bool MaintainResponseBody { get; set; }

		protected bool IsException { get; set; }

		protected CrcCalculatorStream CrcStream { get; set; }

		protected int Crc32Result { get; set; }

		protected IWebResponseData WebResponseData { get; set; }

		protected CachingWrapperStream WrappingStream { get; set; }

		public string ResponseBody => null;

		public IWebResponseData ResponseData => null;

		public abstract string CurrentPath { get; }

		public abstract int CurrentDepth { get; }

		public abstract bool IsStartElement { get; }

		public abstract bool IsEndElement { get; }

		public abstract bool IsStartOfDocument { get; }

		public byte[] GetResponseBodyBytes()
		{
			return null;
		}

		internal void ValidateCRC32IfAvailable()
		{
		}

		protected void SetupCRCStream(IWebResponseData responseData, Stream responseStream, long contentLength)
		{
		}

		public bool TestExpression(string expression)
		{
			return false;
		}

		public bool TestExpression(string expression, int startingStackDepth)
		{
			return false;
		}

		public bool ReadAtDepth(int targetDepth)
		{
			return false;
		}

		private static bool TestExpression(string expression, string currentPath)
		{
			return false;
		}

		private static bool TestExpression(string expression, int startingStackDepth, string currentPath, int currentDepth)
		{
			return false;
		}

		public abstract bool Read();

		public abstract string ReadText();

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
