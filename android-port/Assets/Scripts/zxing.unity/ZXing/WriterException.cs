using System;

namespace ZXing
{
	[Serializable]
	public sealed class WriterException : Exception
	{
		public WriterException()
		{
		}

		public WriterException(string message)
		{
		}

		public WriterException(string message, Exception innerExc)
		{
		}
	}
}
