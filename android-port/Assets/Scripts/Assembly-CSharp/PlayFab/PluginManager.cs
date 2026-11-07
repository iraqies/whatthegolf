using System.Collections.Generic;

namespace PlayFab
{
	public class PluginManager
	{
		private Dictionary<PluginContractKey, IPlayFabPlugin> plugins;

		private static readonly PluginManager Instance;

		private PluginManager()
		{
		}

		public static T GetPlugin<T>(PluginContract contract, string instanceName = "") where T : IPlayFabPlugin
		{
			return default;
		}

		private IPlayFabPlugin GetPluginInternal(PluginContract contract, string instanceName)
		{
			return null;
		}

		private IPlayFabPlugin CreatePlugin<T>() where T : IPlayFabPlugin, new()
		{
			return null;
		}

		private ITransportPlugin CreatePlayFabTransportPlugin()
		{
			return null;
		}
	}
}
