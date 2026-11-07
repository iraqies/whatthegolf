using System.Collections.Generic;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001195")]
	public class PluginManager
	{
		[Token(Token = "0x4005EFA")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<PluginContractKey, IPlayFabPlugin> plugins;

		[Token(Token = "0x4005EFB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly PluginManager Instance;

		[Token(Token = "0x6005047")]
		[Address(RVA = "0x15FF16C", Offset = "0x15FF16C", VA = "0x15FF16C")]
		private PluginManager()
		{
		}

		[Token(Token = "0x6005048")]
		public static T GetPlugin<T>(PluginContract contract, string instanceName = "") where T : IPlayFabPlugin
		{
			return (T)null;
		}

		[Token(Token = "0x6005049")]
		[Address(RVA = "0x15FF24C", Offset = "0x15FF24C", VA = "0x15FF24C")]
		private IPlayFabPlugin GetPluginInternal(PluginContract contract, string instanceName)
		{
			return null;
		}

		[Token(Token = "0x600504A")]
		private IPlayFabPlugin CreatePlugin<T>() where T : IPlayFabPlugin, new()
		{
			return null;
		}

		[Token(Token = "0x600504B")]
		[Address(RVA = "0x15FF39C", Offset = "0x15FF39C", VA = "0x15FF39C")]
		private ITransportPlugin CreatePlayFabTransportPlugin()
		{
			return null;
		}
	}
}
