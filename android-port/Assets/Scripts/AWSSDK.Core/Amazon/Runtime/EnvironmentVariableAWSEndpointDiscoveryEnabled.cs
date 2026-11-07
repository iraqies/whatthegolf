using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000D2")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x25ADC", Offset = "0x25ADC")]
	public class EnvironmentVariableAWSEndpointDiscoveryEnabled
	{
		[Token(Token = "0x400039A")]
		public const string ENVIRONMENT_VARIABLE_AWS_ENABLE_ENDPOINT_DISCOVERY = "AWS_ENABLE_ENDPOINT_DISCOVERY";

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B48", Offset = "0x26B48")]
		private bool Enabled__BackingField;

		[Token(Token = "0x170001E4")]
		public bool Enabled
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x11FEEC8", Offset = "0x11FEEC8", VA = "0x11FEEC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2939C", Offset = "0x2939C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x11FEED0", Offset = "0x11FEED0", VA = "0x11FEED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x293AC", Offset = "0x293AC")]
			private set
			{
			}
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x11FEED8", Offset = "0x11FEED8", VA = "0x11FEED8")]
		public EnvironmentVariableAWSEndpointDiscoveryEnabled()
		{
		}
	}
}
