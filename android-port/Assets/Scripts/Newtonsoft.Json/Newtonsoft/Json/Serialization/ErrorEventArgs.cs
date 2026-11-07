using System;

namespace Newtonsoft.Json.Serialization
{
	public class ErrorEventArgs : EventArgs
	{
		private readonly object CurrentObject;

		private readonly ErrorContext ErrorContext;

		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
		}
	}
}
