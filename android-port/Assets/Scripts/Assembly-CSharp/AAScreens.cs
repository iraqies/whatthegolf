using System;
using System.Collections.Generic;
using UnityEngine;

public class AAScreens : ScriptableObject
{
	[Serializable]
	public class VideoDef
	{
		public string path;

		public int width;

		public int height;

		public float aspect => 0f;
	}

	[SerializeField]
	public List<VideoDef> splashVideos;

	public string GetSplashVideoPath(IVideoPathProvider videoPathProvider)
	{
		return null;
	}
}
