using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC9")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43C98", Offset = "0x43C98")]
public class CaptureWithAlpha : MonoBehaviour
{
	[Token(Token = "0x40041A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera m_Camera;

	[Token(Token = "0x40041A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int UpScale;

	[Token(Token = "0x40041A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool AlphaBackground;

	[Token(Token = "0x170005F0")]
	public Camera camera
	{
		[Token(Token = "0x60038BE")]
		[Address(RVA = "0x1887000", Offset = "0x1887000", VA = "0x1887000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F1")]
	public RenderTextureDescriptor descriptor
	{
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x18870AC", Offset = "0x18870AC", VA = "0x18870AC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60038C0")]
	[Address(RVA = "0x1887130", Offset = "0x1887130", VA = "0x1887130")]
	private Texture2D Screenshot([Optional][DefaultParameterValue(true)] bool useAlpha, [Optional] RenderTexture customDepthTexture)
	{
		return null;
	}

	[Token(Token = "0x60038C1")]
	[Address(RVA = "0x18874B4", Offset = "0x18874B4", VA = "0x18874B4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6B140", Offset = "0x6B140")]
	public string SaveScreenshot(string scene, string layer, DateTime time, [Optional][DefaultParameterValue(true)] bool useClearAlpha, [Optional] RenderTexture customDepthTexture)
	{
		return null;
	}

	[Token(Token = "0x60038C2")]
	[Address(RVA = "0x1887808", Offset = "0x1887808", VA = "0x1887808")]
	public CaptureWithAlpha()
	{
	}
}
