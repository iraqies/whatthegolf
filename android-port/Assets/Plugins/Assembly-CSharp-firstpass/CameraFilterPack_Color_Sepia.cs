using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000020")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Sepia : MonoBehaviour
{
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x18")]
	public Shader SCShader;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x20")]
	private float TimeX;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x344B8", Offset = "0x344B8")]
	public float _Fade;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x28")]
	private Material SCMaterial;

	[Token(Token = "0x17000017")]
	private Material material
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x130DF64", Offset = "0x130DF64", VA = "0x130DF64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x130E038", Offset = "0x130E038", VA = "0x130E038")]
	private void Start()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x130E0BC", Offset = "0x130E0BC", VA = "0x130E0BC")]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x130E308", Offset = "0x130E308", VA = "0x130E308")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x130E3C4", Offset = "0x130E3C4", VA = "0x130E3C4")]
	public CameraFilterPack_Color_Sepia()
	{
	}
}
