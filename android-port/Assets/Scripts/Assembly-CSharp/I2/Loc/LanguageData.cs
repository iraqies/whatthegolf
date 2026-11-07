using System;

namespace I2.Loc
{
	[Serializable]
	public class LanguageData
	{
		public string Name;

		public string Code;

		public byte Flags;

		[NonSerialized]
		public bool Compressed;

		public bool IsEnabled()
		{
			return false;
		}

		public bool IsLoaded()
		{
			return false;
		}

		public bool CanBeUnloaded()
		{
			return false;
		}

		public void SetLoaded(bool loaded)
		{
		}
	}
}
