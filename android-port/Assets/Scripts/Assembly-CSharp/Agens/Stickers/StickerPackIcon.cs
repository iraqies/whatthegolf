using System;
using UnityEngine;

namespace Agens.Stickers
{
	[Serializable]
	public class StickerPackIcon
	{
		[Serializable]
		public class IconExportSettings
		{
			public Color BackgroundColor;

			public int FillPercentage;

			public FilterMode FilterMode;

			public ScaleMode ScaleMode;
		}

		[SerializeField]
		private Texture2D appStore;

		[SerializeField]
		private Texture2D messagesAppStore;

		public IconExportSettings Settings;

		public bool Override;

		[SerializeField]
		private Texture2D messagesiPadPro2;

		[SerializeField]
		private Texture2D messagesiPad2;

		[SerializeField]
		private Texture2D messagesiPhone2;

		[SerializeField]
		private Texture2D messagesiPhone3;

		[SerializeField]
		private Texture2D messagesSmall2;

		[SerializeField]
		private Texture2D messagesSmall3;

		[SerializeField]
		private Texture2D messages2;

		[SerializeField]
		private Texture2D messages3;

		[SerializeField]
		private Texture2D iPhoneSettings2;

		[SerializeField]
		private Texture2D iPhoneSettings3;

		[SerializeField]
		private Texture2D iPadSettings2;
	}
}
