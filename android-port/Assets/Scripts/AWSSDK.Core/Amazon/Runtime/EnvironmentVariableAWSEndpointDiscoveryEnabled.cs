using System;

namespace Amazon.Runtime
{
	[Obsolete]
	public class EnvironmentVariableAWSEndpointDiscoveryEnabled
	{
		public const string ENVIRONMENT_VARIABLE_AWS_ENABLE_ENDPOINT_DISCOVERY = "AWS_ENABLE_ENDPOINT_DISCOVERY";

		public bool Enabled { get; private set; }
	}
}
