using System.Collections.Generic;
using Rewired.Platforms;
using UnityEngine;

namespace Rewired.Data
{
	public class RuntimeData : ScriptableObject
	{
		public Platform platform;

		public WebplayerPlatform webplayerPlatform;

		public EditorPlatform editorPlatform;

		public List<TextAsset> libraries;

		public void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries)
		{
		}
	}
}
