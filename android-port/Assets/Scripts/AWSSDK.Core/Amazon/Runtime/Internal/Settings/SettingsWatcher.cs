using System;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Settings
{
	public class SettingsWatcher : IDisposable
	{
		private string type;

		[CompilerGenerated]
		private EventHandler m_SettingsChanged;

		public bool Enable { get; set; }

		public event EventHandler SettingsChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private SettingsWatcher()
		{
		}

		internal SettingsWatcher(string filePath, string type)
		{
		}

		public SettingsCollection GetSettings()
		{
			return null;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
