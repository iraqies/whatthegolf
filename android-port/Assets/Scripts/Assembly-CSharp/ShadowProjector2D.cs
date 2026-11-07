using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C75")]
public class ShadowProjector2D : MonoBehaviour
{
	[Token(Token = "0x4004438")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Down;

	[Token(Token = "0x4004439")]
	[FieldOffset(Offset = "0x24")]
	public float Offset;

	[Token(Token = "0x400443A")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask GroundLayers;

	[Token(Token = "0x400443B")]
	[FieldOffset(Offset = "0x2C")]
	public float MaxHeight;

	[Token(Token = "0x400443C")]
	[FieldOffset(Offset = "0x30")]
	public bool is2D;

	[Token(Token = "0x400443D")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x51254", Offset = "0x51254")]
	private Projector Projector__BackingField;

	[Token(Token = "0x400443E")]
	[FieldOffset(Offset = "0x40")]
	public float SizeMod;

	[Token(Token = "0x400443F")]
	[FieldOffset(Offset = "0x44")]
	private float startOrthoSize;

	[Token(Token = "0x1700060D")]
	public Projector Projector
	{
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x169D39C", Offset = "0x169D39C", VA = "0x169D39C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B664", Offset = "0x6B664")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x169D3A4", Offset = "0x169D3A4", VA = "0x169D3A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B674", Offset = "0x6B674")]
		private set
		{
		}
	}

	[Token(Token = "0x6003B1C")]
	[Address(RVA = "0x169D3AC", Offset = "0x169D3AC", VA = "0x169D3AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6003B1D")]
	[Address(RVA = "0x169D41C", Offset = "0x169D41C", VA = "0x169D41C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B1E")]
	[Address(RVA = "0x169D608", Offset = "0x169D608", VA = "0x169D608")]
	private void SetProjector(float distance)
	{
	}

	[Token(Token = "0x6003B1F")]
	[Address(RVA = "0x169D694", Offset = "0x169D694", VA = "0x169D694")]
	public ShadowProjector2D()
	{
	}
}
