using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A36")]
public class Draw3DObjectOntoQuad : MonoBehaviour
{
	[Token(Token = "0x400385B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject masterObject;

	[Token(Token = "0x400385C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject object3D;

	[Token(Token = "0x400385D")]
	[FieldOffset(Offset = "0x28")]
	public Camera projectingCamera;

	[Token(Token = "0x400385E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject quad;

	[Token(Token = "0x400385F")]
	[FieldOffset(Offset = "0x38")]
	public RenderTexture renderTextureTemplate;

	[Token(Token = "0x4003860")]
	[FieldOffset(Offset = "0x40")]
	public Material renderTextureMaterialTemplate;

	[Token(Token = "0x4003861")]
	[FieldOffset(Offset = "0x48")]
	private MeshRenderer mesh;

	[Token(Token = "0x4003862")]
	[FieldOffset(Offset = "0x50")]
	private RenderTexture renderTexture;

	[Token(Token = "0x4003863")]
	[FieldOffset(Offset = "0x58")]
	private Material material;

	[Token(Token = "0x600309D")]
	[Address(RVA = "0x1434AA8", Offset = "0x1434AA8", VA = "0x1434AA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600309E")]
	[Address(RVA = "0x1434C50", Offset = "0x1434C50", VA = "0x1434C50")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600309F")]
	[Address(RVA = "0x1434CAC", Offset = "0x1434CAC", VA = "0x1434CAC")]
	private void Update()
	{
	}

	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x1434D08", Offset = "0x1434D08", VA = "0x1434D08")]
	public Draw3DObjectOntoQuad()
	{
	}
}
