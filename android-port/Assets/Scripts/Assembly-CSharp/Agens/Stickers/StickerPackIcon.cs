using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Agens.Stickers
{
	[Serializable]
	[Token(Token = "0x200101B")]
	public class StickerPackIcon
	{
		[Serializable]
		[Token(Token = "0x200101C")]
		public class IconExportSettings
		{
			[Token(Token = "0x40054EF")]
			[FieldOffset(Offset = "0x10")]
			public Color BackgroundColor;

			[Token(Token = "0x40054F0")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x552E4", Offset = "0x552E4")]
			public int FillPercentage;

			[Token(Token = "0x40054F1")]
			[FieldOffset(Offset = "0x24")]
			public FilterMode FilterMode;

			[Token(Token = "0x40054F2")]
			[FieldOffset(Offset = "0x28")]
			public ScaleMode ScaleMode;

			[Token(Token = "0x6004802")]
			[Address(RVA = "0x185B3F4", Offset = "0x185B3F4", VA = "0x185B3F4")]
			public IconExportSettings()
			{
			}
		}

		[Token(Token = "0x40054E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Texture2D appStore;

		[Token(Token = "0x40054E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture2D messagesAppStore;

		[Token(Token = "0x40054E2")]
		[FieldOffset(Offset = "0x20")]
		public IconExportSettings Settings;

		[Token(Token = "0x40054E3")]
		[FieldOffset(Offset = "0x28")]
		public bool Override;

		[Token(Token = "0x40054E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture2D messagesiPadPro2;

		[Token(Token = "0x40054E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Texture2D messagesiPad2;

		[Token(Token = "0x40054E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Texture2D messagesiPhone2;

		[Token(Token = "0x40054E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Texture2D messagesiPhone3;

		[Token(Token = "0x40054E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Texture2D messagesSmall2;

		[Token(Token = "0x40054E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Texture2D messagesSmall3;

		[Token(Token = "0x40054EA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Texture2D messages2;

		[Token(Token = "0x40054EB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Texture2D messages3;

		[Token(Token = "0x40054EC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture2D iPhoneSettings2;

		[Token(Token = "0x40054ED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Texture2D iPhoneSettings3;

		[Token(Token = "0x40054EE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Texture2D iPadSettings2;

		[Token(Token = "0x6004801")]
		[Address(RVA = "0x16DF568", Offset = "0x16DF568", VA = "0x16DF568")]
		public StickerPackIcon()
		{
		}
	}
}
