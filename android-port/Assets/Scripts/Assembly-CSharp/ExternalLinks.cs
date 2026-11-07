using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E44")]
public class ExternalLinks : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000E45")]
	public class LinksOnPlatform
	{
		[Token(Token = "0x4004D75")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4004D76")]
		[FieldOffset(Offset = "0x18")]
		public Store platformType;

		[Token(Token = "0x4004D77")]
		[FieldOffset(Offset = "0x20")]
		public List<Link> links;

		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x17A1B38", Offset = "0x17A1B38", VA = "0x17A1B38")]
		public LinksOnPlatform()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000E46")]
	public class Link
	{
		[Token(Token = "0x4004D78")]
		[FieldOffset(Offset = "0x10")]
		public LinkType typeOfLink;

		[Token(Token = "0x4004D79")]
		[FieldOffset(Offset = "0x18")]
		public string url;

		[Token(Token = "0x4004D7A")]
		[FieldOffset(Offset = "0x20")]
		public Sprite QRCode;

		[Token(Token = "0x60042D8")]
		[Address(RVA = "0x17A1B30", Offset = "0x17A1B30", VA = "0x17A1B30")]
		public Link()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000E47")]
	public class PopupText
	{
		[Token(Token = "0x4004D7B")]
		[FieldOffset(Offset = "0x10")]
		public LinkType typeOfLink;

		[Token(Token = "0x4004D7C")]
		[FieldOffset(Offset = "0x18")]
		public string textID;

		[Token(Token = "0x60042D9")]
		[Address(RVA = "0x17A1B40", Offset = "0x17A1B40", VA = "0x17A1B40")]
		public PopupText()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000E48")]
	public enum LinkType
	{
		[Token(Token = "0x4004D7E")]
		DISCORD = 0,
		[Token(Token = "0x4004D7F")]
		NEWSLETTER = 1,
		[Token(Token = "0x4004D80")]
		TIKTOK = 2,
		[Token(Token = "0x4004D81")]
		FAQ = 3,
		[Token(Token = "0x4004D82")]
		TERMSOFERVICE = 4
	}

	[Token(Token = "0x4004D72")]
	[FieldOffset(Offset = "0x18")]
	public List<LinksOnPlatform> platforms;

	[Token(Token = "0x4004D73")]
	[FieldOffset(Offset = "0x20")]
	public List<PopupText> genericPopupText;

	[Token(Token = "0x4004D74")]
	[FieldOffset(Offset = "0x28")]
	public List<PopupText> playstationPopupText;

	[Token(Token = "0x60042D6")]
	[Address(RVA = "0x1454388", Offset = "0x1454388", VA = "0x1454388")]
	public ExternalLinks()
	{
	}
}
