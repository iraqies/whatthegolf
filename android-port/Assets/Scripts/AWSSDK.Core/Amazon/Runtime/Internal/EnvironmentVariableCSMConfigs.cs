using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x20001AB")]
	public class EnvironmentVariableCSMConfigs
	{
		[Token(Token = "0x4000679")]
		private const string CSM_ENABLED = "AWS_CSM_ENABLED";

		[Token(Token = "0x400067A")]
		private const string CSM_CLIENTID = "AWS_CSM_CLIENT_ID";

		[Token(Token = "0x400067B")]
		private const string CSM_HOST = "AWS_CSM_HOST";

		[Token(Token = "0x400067C")]
		private const string CSM_PORT = "AWS_CSM_PORT";

		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27648", Offset = "0x27648")]
		private IEnvironmentVariableRetriever environmentRetriever__BackingField;

		[Token(Token = "0x17000362")]
		private IEnvironmentVariableRetriever environmentRetriever
		{
			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x11FF4C4", Offset = "0x11FF4C4", VA = "0x11FF4C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AFF4", Offset = "0x2AFF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x11FF4CC", Offset = "0x11FF4CC", VA = "0x11FF4CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B004", Offset = "0x2B004")]
			set
			{
			}
		}

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x11FF4D4", Offset = "0x11FF4D4", VA = "0x11FF4D4")]
		public EnvironmentVariableCSMConfigs(IEnvironmentVariableRetriever environmentRetriever, CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}

		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x11FFC7C", Offset = "0x11FFC7C", VA = "0x11FFC7C")]
		public EnvironmentVariableCSMConfigs(CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}

		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x11FF5B4", Offset = "0x11FF5B4", VA = "0x11FF5B4")]
		private void SetupConfiguration(CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}
	}
}
