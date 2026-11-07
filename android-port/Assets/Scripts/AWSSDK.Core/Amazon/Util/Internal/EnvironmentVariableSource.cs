namespace Amazon.Util.Internal
{
	public sealed class EnvironmentVariableSource
	{
		private static readonly EnvironmentVariableSource instance;

		public IEnvironmentVariableRetriever EnvironmentVariableRetriever { get; set; }

		public static EnvironmentVariableSource Instance => null;

		private EnvironmentVariableSource()
		{
		}

		static EnvironmentVariableSource()
		{
		}
	}
}
