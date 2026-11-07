using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001F")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_GrayScale : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public Shader SCShader;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x20")]
	private float TimeX;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x344A0", Offset = "0x344A0")]
	public float _Fade;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x28")]
	private Material SCMaterial;

	[Token(Token = "0x17000016")]
	private Material material
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x130DB00", Offset = "0x130DB00", VA = "0x130DB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x130DBD4", Offset = "0x130DBD4", VA = "0x130DBD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x130DC58", Offset = "0x130DC58", VA = "0x130DC58")]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x130DE98", Offset = "0x130DE98", VA = "0x130DE98")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x130DF54", Offset = "0x130DF54", VA = "0x130DF54")]
	public CameraFilterPack_Color_GrayScale()
	{
	}
}
