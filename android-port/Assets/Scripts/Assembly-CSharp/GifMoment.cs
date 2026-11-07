using System.Collections.Generic;
using UnityEngine;

public class GifMoment
{
	public EGifMoment type;

	public bool unlocked;

	public string filename;

	public string imagesPath;

	private string gifSaveFormat;

	private Texture2D _preview;

	public Texture2D preview => null;

	public string id => null;

	public Texture2D LoadFrame(int index, Texture2D reuseTexture)
	{
		return null;
	}

	public bool HasFrame(int index)
	{
		return false;
	}

	private string GetPathForFrame(int index)
	{
		return null;
	}

	public void DeleteRecording()
	{
	}

	private byte[] EncodeTexture(Texture2D t)
	{
		return null;
	}

	public void SaveFrames(List<RenderTexture> frames)
	{
	}

	private void UpdateTexture(Texture2D tex, RenderTexture rt)
	{
	}

	private string GetSaveKey()
	{
		return null;
	}

	public void SaveUnlock()
	{
	}

	public bool HasSave()
	{
		return false;
	}
}
