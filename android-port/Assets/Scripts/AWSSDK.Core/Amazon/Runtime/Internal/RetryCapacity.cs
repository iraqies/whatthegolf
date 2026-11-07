namespace Amazon.Runtime.Internal
{
	public class RetryCapacity
	{
		private readonly int _maxCapacity;

		public int AvailableCapacity { get; set; }

		public int MaxCapacity => 0;

		public RetryCapacity(int maxCapacity)
		{
		}
	}
}
