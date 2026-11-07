using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000021")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_VHS_Rewind : MonoBehaviour
{
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x18")]
	public Shader SCShader;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x20")]
	private float TimeX;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x28")]
	private Material SCMaterial;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x344D0", Offset = "0x344D0")]
	public float Cryptage;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0x344E8", Offset = "0x344E8")]
	public float Parasite;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x34500", Offset = "0x34500")]
	public float Parasite2;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x34518", Offset = "0x34518")]
	private float WhiteParasite;

	[Token(Token = "0x17000018")]
	private Material material
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x130E3D4", Offset = "0x130E3D4", VA = "0x130E3D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x130E4A8", Offset = "0x130E4A8", VA = "0x130E4A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x130E52C", Offset = "0x130E52C", VA = "0x130E52C")]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x130E7FC", Offset = "0x130E7FC", VA = "0x130E7FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x130E8B8", Offset = "0x130E8B8", VA = "0x130E8B8")]
	public CameraFilterPack_TV_VHS_Rewind()
	{
	}
}
