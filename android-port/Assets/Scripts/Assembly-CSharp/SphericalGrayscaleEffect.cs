using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000E8")]
[ExecuteInEditMode]
public class SphericalGrayscaleEffect : MonoBehaviour
{
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x18")]
	public List<MultiplayerConfiguration.PlayerInfo> Positions;

	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x20")]
	public List<float> Radii;

	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x28")]
	public float MoveSpeed;

	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x2C")]
	public float NoiseScale;

	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x30")]
	public float Intensity;

	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x34")]
	public float OutlineSize;

	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x38")]
	public float Offset;

	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x40")]
	public Material material;

	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x48")]
	private string[] shaderNamesPositions;

	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x50")]
	private string[] shaderNamesRadius;

	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x58")]
	private string[] shaderNamesColors;

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x16D1BE0", Offset = "0x16D1BE0", VA = "0x16D1BE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x16D1CFC", Offset = "0x16D1CFC", VA = "0x16D1CFC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x16D22DC", Offset = "0x16D22DC", VA = "0x16D22DC")]
	public void AddOffset(float offset)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x16D2344", Offset = "0x16D2344", VA = "0x16D2344")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x16D2404", Offset = "0x16D2404", VA = "0x16D2404")]
	public SphericalGrayscaleEffect()
	{
	}
}
