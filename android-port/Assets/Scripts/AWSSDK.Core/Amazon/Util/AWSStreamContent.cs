using System;
using System.IO;
using System.Net.Http;

namespace Amazon.Util
{
	public class AWSStreamContent : IDisposable
	{
		private bool disposed;

		internal StreamContent StreamContent { get; set; }

		public AWSStreamContent(Stream content)
		{
		}

		public AWSStreamContent(Stream content, int bufferSize)
		{
		}

		public bool RemoveHttpContentHeader(string name)
		{
			return false;
		}

		public void AddHttpContentHeader(string name, string value)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
