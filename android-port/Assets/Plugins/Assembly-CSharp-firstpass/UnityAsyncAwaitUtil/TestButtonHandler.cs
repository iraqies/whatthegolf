using System;

namespace UnityAsyncAwaitUtil
{
	public class TestButtonHandler
	{
		[Serializable]
		public class Settings
		{
			public int NumPerColumn;

			public float VerticalMargin;

			public float VerticalSpacing;

			public float HorizontalSpacing;

			public float HorizontalMargin;

			public float ButtonWidth;

			public float ButtonHeight;
		}

		private readonly Settings _settings;

		private int _buttonVCount;

		private int _buttonHCount;

		public TestButtonHandler(Settings settings)
		{
		}

		public void Restart()
		{
		}

		public bool Display(string text)
		{
			return false;
		}
	}
}
