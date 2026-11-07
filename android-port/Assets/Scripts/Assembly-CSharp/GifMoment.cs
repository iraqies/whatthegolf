using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C1")]
public class GifMoment
{
	[Token(Token = "0x4001D6D")]
	[FieldOffset(Offset = "0x10")]
	public EGifMoment type;

	[Token(Token = "0x4001D6E")]
	[FieldOffset(Offset = "0x14")]
	public bool unlocked;

	[Token(Token = "0x4001D6F")]
	[FieldOffset(Offset = "0x18")]
	public string filename;

	[Token(Token = "0x4001D70")]
	[FieldOffset(Offset = "0x20")]
	public string imagesPath;

	[Token(Token = "0x4001D71")]
	[FieldOffset(Offset = "0x28")]
	private string gifSaveFormat;

	[Token(Token = "0x4001D72")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D _preview;

	[Token(Token = "0x170002D3")]
	public Texture2D preview
	{
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x1486B0C", Offset = "0x1486B0C", VA = "0x1486B0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D4")]
	public string id
	{
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x1486D0C", Offset = "0x1486D0C", VA = "0x1486D0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x1486C24", Offset = "0x1486C24", VA = "0x1486C24")]
	public Texture2D LoadFrame(int index, Texture2D reuseTexture)
	{
		return null;
	}

	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x1486BE0", Offset = "0x1486BE0", VA = "0x1486BE0")]
	public bool HasFrame(int index)
	{
		return default;
	}

	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x1486D80", Offset = "0x1486D80", VA = "0x1486D80")]
	private string GetPathForFrame(int index)
	{
		return null;
	}

	[Token(Token = "0x6001A24")]
	[Address(RVA = "0x1486E58", Offset = "0x1486E58", VA = "0x1486E58")]
	public void DeleteRecording()
	{
	}

	[Token(Token = "0x6001A25")]
	[Address(RVA = "0x1486F0C", Offset = "0x1486F0C", VA = "0x1486F0C")]
	private byte[] EncodeTexture(Texture2D t)
	{
		return null;
	}

	[Token(Token = "0x6001A26")]
	[Address(RVA = "0x1486F18", Offset = "0x1486F18", VA = "0x1486F18")]
	public void SaveFrames(List<RenderTexture> frames)
	{
	}

	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x148734C", Offset = "0x148734C", VA = "0x148734C")]
	private void UpdateTexture(Texture2D tex, RenderTexture rt)
	{
	}

	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x1487400", Offset = "0x1487400", VA = "0x1487400")]
	private string GetSaveKey()
	{
		return null;
	}

	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x1487494", Offset = "0x1487494", VA = "0x1487494")]
	public void SaveUnlock()
	{
	}

	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x14875A4", Offset = "0x14875A4", VA = "0x14875A4")]
	public bool HasSave()
	{
		return default;
	}

	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x14876B0", Offset = "0x14876B0", VA = "0x14876B0")]
	public GifMoment()
	{
	}
}
