using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B4")]
[Attribute(Name = "RequireComponent", RVA = "0x3EA3C", Offset = "0x3EA3C")]
[ExecuteAlways]
public class CreateRunningTrack : MonoBehaviour
{
	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x18")]
	public bool CreateTrackFromPath;

	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x1C")]
	public float Width;

	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x20")]
	public Color BaseColor;

	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x30")]
	public bool UseCustomLineColor;

	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x34")]
	public Color LineColor;

	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B514", Offset = "0x4B514")]
	public float LeftLineIndent;

	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B52C", Offset = "0x4B52C")]
	public float LeftLineWidth;

	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B544", Offset = "0x4B544")]
	public float RightLineIndent;

	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B55C", Offset = "0x4B55C")]
	public float RightLineWidth;

	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x54")]
	public float Tracks;

	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B574", Offset = "0x4B574")]
	public float MiddleLineWidth;

	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B58C", Offset = "0x4B58C")]
	public float HorizontalLineWidth;

	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B5AC", Offset = "0x4B5AC")]
	public float HorizontalLineInterval;

	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x64")]
	public bool UseGab;

	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B5C4", Offset = "0x4B5C4")]
	public float LineGabWidth;

	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B5DC", Offset = "0x4B5DC")]
	public float LineGabInterval;

	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x70")]
	public bool AddNoise;

	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B5FC", Offset = "0x4B5FC")]
	public float NoiseCutoff;

	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x78")]
	public float NoiseScale;

	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x7C")]
	public Color NoiseColor;

	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x8C")]
	public Vector2 NoiseOffset;

	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4B614", Offset = "0x4B614")]
	public float NoiseCutoff2;

	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x98")]
	public float NoiseScale2;

	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x9C")]
	public Color NoiseColor2;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0xAC")]
	public Vector2 NoiseOffset2;

	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0xB8")]
	private MeshFilter meshFilter;

	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0xC0")]
	private CinemachineSmoothPath path;

	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0xC8")]
	private MeshRenderer renderer;

	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0xD0")]
	private MaterialPropertyBlock propBlock;

	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0xD8")]
	public MeshRenderer start;

	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0xE0")]
	public MeshRenderer end;

	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0xE8")]
	public bool CurvedEnds;

	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0xEC")]
	public float pathResolution;

	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0xF0")]
	private bool isFirstFrame;

	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x18BEB80", Offset = "0x18BEB80", VA = "0x18BEB80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x18BFF58", Offset = "0x18BFF58", VA = "0x18BFF58")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x18BF2A4", Offset = "0x18BF2A4", VA = "0x18BF2A4")]
	private void CreateMesh()
	{
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x18BED5C", Offset = "0x18BED5C", VA = "0x18BED5C")]
	private void SetProperties(Renderer r)
	{
	}

	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x18BEBC8", Offset = "0x18BEBC8", VA = "0x18BEBC8")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x18BFFB4", Offset = "0x18BFFB4", VA = "0x18BFFB4")]
	public CreateRunningTrack()
	{
	}
}
