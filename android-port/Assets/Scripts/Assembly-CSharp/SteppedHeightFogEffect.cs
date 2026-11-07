using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037A")]
[Attribute(Name = "RequireComponent", RVA = "0x3F444", Offset = "0x3F444")]
[ExecuteInEditMode]
public class SteppedHeightFogEffect : MonoBehaviour
{
	[Token(Token = "0x4001308")]
	[FieldOffset(Offset = "0x18")]
	private Shader shader;

	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0x20")]
	private Material material;

	[Token(Token = "0x400130A")]
	[FieldOffset(Offset = "0x28")]
	public float fogStartHeight;

	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0x2C")]
	public float fogStopHeight;

	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4CCE4", Offset = "0x4CCE4")]
	public int stepPower;

	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x34")]
	public bool useCameraClearColor;

	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x38")]
	public Color fogColor;

	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x48")]
	public bool skyMask;

	[Token(Token = "0x6001068")]
	[Address(RVA = "0x16DEEC0", Offset = "0x16DEEC0", VA = "0x16DEEC0")]
	private void SetMaterialValues()
	{
	}

	[Token(Token = "0x6001069")]
	[Address(RVA = "0x16DF0A4", Offset = "0x16DF0A4", VA = "0x16DF0A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600106A")]
	[Address(RVA = "0x16DF138", Offset = "0x16DF138", VA = "0x16DF138")]
	private void CreateMaterial()
	{
	}

	[Token(Token = "0x600106B")]
	[Address(RVA = "0x16DF1C8", Offset = "0x16DF1C8", VA = "0x16DF1C8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600106C")]
	[Address(RVA = "0x16DF254", Offset = "0x16DF254", VA = "0x16DF254")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600106D")]
	[Address(RVA = "0x16DF348", Offset = "0x16DF348", VA = "0x16DF348")]
	public SteppedHeightFogEffect()
	{
	}
}
