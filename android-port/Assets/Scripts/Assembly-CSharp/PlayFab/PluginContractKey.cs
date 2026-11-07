using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001193")]
	public struct PluginContractKey
	{
		[Token(Token = "0x4005EF8")]
		[FieldOffset(Offset = "0x0")]
		public PluginContract _pluginContract;

		[Token(Token = "0x4005EF9")]
		[FieldOffset(Offset = "0x8")]
		public string _pluginName;
	}
}
