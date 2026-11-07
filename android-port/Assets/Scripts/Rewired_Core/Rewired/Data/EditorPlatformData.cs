using System;
using Rewired.Platforms;
using UnityEngine;

namespace Rewired.Data
{
	public class EditorPlatformData : ScriptableObject
	{
		[Serializable]
		public class Platform
		{
			public TextAsset[] libraries;
		}

		public Platform windowsStandalone;

		public Platform windowsStore;

		public Platform osxStandalone;

		public Platform linuxStandalone;

		public Platform webplayer;

		public Platform fallback;

		public TextAsset[] GetLibraries(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			return null;
		}

		public Platform GetPlatform(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			return null;
		}
	}
}
