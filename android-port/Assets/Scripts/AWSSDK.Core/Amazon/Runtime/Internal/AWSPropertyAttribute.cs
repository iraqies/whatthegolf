using System;

namespace Amazon.Runtime.Internal
{
	public sealed class AWSPropertyAttribute : Attribute
	{
		private long min;

		private long max;

		public bool Required { get; set; }

		public bool IsMinSet { get; private set; }

		public long Min
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool IsMaxSet { get; private set; }

		public long Max
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}
	}
}
