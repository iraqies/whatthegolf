using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200015B")]
	public class EnvironmentVariableInternalConfiguration : InternalConfiguration
	{
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x28")]
		private Logger _logger;

		[Token(Token = "0x4000569")]
		public const string ENVIRONMENT_VARIABLE_AWS_ENABLE_ENDPOINT_DISCOVERY = "AWS_ENABLE_ENDPOINT_DISCOVERY";

		[Token(Token = "0x400056A")]
		public const string ENVIRONMENT_VARIABLE_AWS_MAX_ATTEMPTS = "AWS_MAX_ATTEMPTS";

		[Token(Token = "0x400056B")]
		public const string ENVIRONMENT_VARIABLE_AWS_RETRY_MODE = "AWS_RETRY_MODE";

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x11FFD4C", Offset = "0x11FFD4C", VA = "0x11FFD4C")]
		public EnvironmentVariableInternalConfiguration()
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x11FFEF8", Offset = "0x11FFEF8", VA = "0x11FFEF8")]
		private bool TryGetEnvironmentVariable(string environmentVariableName, out string value)
		{
			return default;
		}

		[Token(Token = "0x6000B10")]
		private T? GetEnvironmentVariable<T>(string name) where T : struct
		{
			return null;
		}
	}
}
