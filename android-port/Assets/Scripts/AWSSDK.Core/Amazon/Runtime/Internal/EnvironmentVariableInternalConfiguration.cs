using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class EnvironmentVariableInternalConfiguration : InternalConfiguration
	{
		private Logger _logger;

		public const string ENVIRONMENT_VARIABLE_AWS_ENABLE_ENDPOINT_DISCOVERY = "AWS_ENABLE_ENDPOINT_DISCOVERY";

		public const string ENVIRONMENT_VARIABLE_AWS_MAX_ATTEMPTS = "AWS_MAX_ATTEMPTS";

		public const string ENVIRONMENT_VARIABLE_AWS_RETRY_MODE = "AWS_RETRY_MODE";

		private bool TryGetEnvironmentVariable(string environmentVariableName, out string value)
		{
			value = null;
			return false;
		}

		private T? GetEnvironmentVariable<T>(string name) where T : struct
		{
			return null;
		}
	}
}
