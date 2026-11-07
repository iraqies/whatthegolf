using System.Collections;
using UnityEngine;

public class VideoPathProviderAssetBundle : IVideoPathProvider
{
	private AssetBundle bundle;

	private string[] assetNames;

	private string assetBundleFilePath;

	public bool InitComplete { get; private set; }

	public VideoPathProviderAssetBundle(string filePath)
	{
	}

	public virtual IEnumerator Init()
	{
		return null;
	}

	public string GetVideoPath(string path)
	{
		return null;
	}

	public bool FileExists(string path)
	{
		return false;
	}

	public IEnumerator GetVideoClipForPath(string path, VideoClipResult result)
	{
		return null;
	}

	public void Cleanup()
	{
	}
}
