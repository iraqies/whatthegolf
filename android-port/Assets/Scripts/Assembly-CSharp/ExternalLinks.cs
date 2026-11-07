using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ExternalLinks : ScriptableObject
{
	[Serializable]
	public class LinksOnPlatform
	{
		public string name;

		public Store platformType;

		public List<Link> links;
	}

	[Serializable]
	public class Link
	{
		public LinkType typeOfLink;

		public string url;

		public Sprite QRCode;
	}

	[Serializable]
	public class PopupText
	{
		public LinkType typeOfLink;

		public string textID;
	}

	[Serializable]
	public enum LinkType
	{
		DISCORD = 0,
		NEWSLETTER = 1,
		TIKTOK = 2,
		FAQ = 3,
		TERMSOFERVICE = 4
	}

	public List<LinksOnPlatform> platforms;

	public List<PopupText> genericPopupText;

	public List<PopupText> playstationPopupText;
}
