namespace Amazon.Runtime.Internal
{
	public sealed class DeterminedCSMConfiguration
	{
		private static readonly DeterminedCSMConfiguration instance;

		public CSMConfiguration CSMConfiguration { get; set; }

		public static DeterminedCSMConfiguration Instance => null;

		private DeterminedCSMConfiguration()
		{
		}

		static DeterminedCSMConfiguration()
		{
		}
	}
}
