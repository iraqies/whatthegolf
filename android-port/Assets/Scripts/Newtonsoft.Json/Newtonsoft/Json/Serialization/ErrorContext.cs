using System;

namespace Newtonsoft.Json.Serialization
{
	public class ErrorContext
	{
		private readonly object OriginalObject;

		private readonly object Member;

		private readonly string Path;

		internal bool Traced { get; set; }

		public Exception Error { get; }

		public bool Handled { get; }

		internal ErrorContext(object originalObject, object member, string path, Exception error)
		{
		}
	}
}
