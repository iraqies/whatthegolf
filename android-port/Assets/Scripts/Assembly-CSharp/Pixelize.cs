using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000012")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x3D1A8", Offset = "0x3D1A8")]
public class Pixelize : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x18")]
	private Shader _screenAndMaskShader;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	private Material _screenAndMaskMaterial;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture _temporaryRenderTexture;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x30")]
	private Shader _combineLayersShader;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x38")]
	private Material _combineLayersMaterial;

	[Token(Token = "0x1700000D")]
	private Shader ScreenAndMaskShader
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x15E32E4", Offset = "0x15E32E4", VA = "0x15E32E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	private Material ScreenAndMaskMaterial
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x15E3390", Offset = "0x15E3390", VA = "0x15E3390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	private RenderTexture TemporaryRenderTarget
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x15E3454", Offset = "0x15E3454", VA = "0x15E3454")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	private Shader CombineLayersShader
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x15E35D4", Offset = "0x15E35D4", VA = "0x15E35D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000011")]
	private Material CombineLayersMaterial
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x15E3680", Offset = "0x15E3680", VA = "0x15E3680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x15E3744", Offset = "0x15E3744", VA = "0x15E3744")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x15E34E4", Offset = "0x15E34E4", VA = "0x15E34E4")]
	private void CreateTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x15E38CC", Offset = "0x15E38CC", VA = "0x15E38CC")]
	private void CheckTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x15E3A1C", Offset = "0x15E3A1C", VA = "0x15E3A1C")]
	private void ReleaseTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x15E3A50", Offset = "0x15E3A50", VA = "0x15E3A50")]
	public Pixelize()
	{
	}
}
