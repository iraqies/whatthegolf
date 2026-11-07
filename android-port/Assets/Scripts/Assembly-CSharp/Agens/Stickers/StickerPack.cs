using System.Collections.Generic;
using UnityEngine;

namespace Agens.Stickers
{
	public class StickerPack : ScriptableObject
	{
		[SerializeField]
		private string title;

		[SerializeField]
		private string bundleId;

		public SigningSettings Signing;

		public StickerPackIcon Icons;

		[SerializeField]
		private StickerSize size;

		public List<Sticker> Stickers;

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string BundleId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StickerSize Size
		{
			get
			{
				return StickerSize.Small;
			}
			set
			{
			}
		}
	}
}
