using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F1")]
public class CreateRenderTexForPainter : MonoBehaviour
{
	[Token(Token = "0x400095A")]
	[FieldOffset(Offset = "0x18")]
	public Camera camera;

	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x20")]
	public Camera poseCamera;

	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x28")]
	public Camera bgCamera;

	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0x30")]
	public Material Mat;

	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x38")]
	public Vector2Int TexSize;

	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x40")]
	public GiraffePainterController controller;

	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x48")]
	public MeshRenderer CanvasRenderer;

	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x50")]
	public Action<RenderTexture> OnTextureCreated;

	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x58")]
	private RenderTexture tex;

	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x60")]
	private RenderTexture texResult;

	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x68")]
	private RenderTexture texBackground;

	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x70")]
	private Material paintingMat;

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x18BE788", Offset = "0x18BE788", VA = "0x18BE788")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x18BEABC", Offset = "0x18BEABC", VA = "0x18BEABC")]
	private void ControllerOnOnClear()
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x18BEB34", Offset = "0x18BEB34", VA = "0x18BEB34")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x18BEB70", Offset = "0x18BEB70", VA = "0x18BEB70")]
	public CreateRenderTexForPainter()
	{
	}
}
