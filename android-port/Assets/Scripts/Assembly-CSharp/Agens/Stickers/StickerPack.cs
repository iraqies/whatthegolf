using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Agens.Stickers
{
	[Token(Token = "0x200101A")]
	public class StickerPack : ScriptableObject
	{
		[Token(Token = "0x40054DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string title;

		[Token(Token = "0x40054DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string bundleId;

		[Token(Token = "0x40054DC")]
		[FieldOffset(Offset = "0x28")]
		public SigningSettings Signing;

		[Token(Token = "0x40054DD")]
		[FieldOffset(Offset = "0x30")]
		public StickerPackIcon Icons;

		[Token(Token = "0x40054DE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StickerSize size;

		[Token(Token = "0x40054DF")]
		[FieldOffset(Offset = "0x40")]
		public List<Sticker> Stickers;

		[Token(Token = "0x17000791")]
		public string Title
		{
			[Token(Token = "0x60047FA")]
			[Address(RVA = "0x16DF3E4", Offset = "0x16DF3E4", VA = "0x16DF3E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047FB")]
			[Address(RVA = "0x16DF48C", Offset = "0x16DF48C", VA = "0x16DF48C")]
			set
			{
			}
		}

		[Token(Token = "0x17000792")]
		public string BundleId
		{
			[Token(Token = "0x60047FC")]
			[Address(RVA = "0x16DF494", Offset = "0x16DF494", VA = "0x16DF494")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047FD")]
			[Address(RVA = "0x16DF540", Offset = "0x16DF540", VA = "0x16DF540")]
			set
			{
			}
		}

		[Token(Token = "0x17000793")]
		public StickerSize Size
		{
			[Token(Token = "0x60047FE")]
			[Address(RVA = "0x16DF548", Offset = "0x16DF548", VA = "0x16DF548")]
			get
			{
				return default;
			}
			[Token(Token = "0x60047FF")]
			[Address(RVA = "0x16DF550", Offset = "0x16DF550", VA = "0x16DF550")]
			set
			{
			}
		}

		[Token(Token = "0x6004800")]
		[Address(RVA = "0x16DF558", Offset = "0x16DF558", VA = "0x16DF558")]
		public StickerPack()
		{
		}
	}
}
