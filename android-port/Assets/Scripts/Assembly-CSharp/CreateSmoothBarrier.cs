using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B5")]
[ExecuteAlways]
[Attribute(Name = "RequireComponent", RVA = "0x3EB04", Offset = "0x3EB04")]
public class CreateSmoothBarrier : MonoBehaviour
{
	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x18")]
	public bool CreateTrackFromPath;

	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x1C")]
	public float Width;

	[Token(Token = "0x4000E9E")]
	[FieldOffset(Offset = "0x20")]
	public float Height;

	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x24")]
	public float TilingMod;

	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x28")]
	private MeshFilter meshFilter;

	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x30")]
	private CinemachineSmoothPath path;

	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x38")]
	private MeshRenderer renderer;

	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0x40")]
	private MaterialPropertyBlock propBlock;

	[Token(Token = "0x4000EA4")]
	[FieldOffset(Offset = "0x48")]
	private MeshCollider meshCollider;

	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x18C00E0", Offset = "0x18C00E0", VA = "0x18C00E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x18C102C", Offset = "0x18C102C", VA = "0x18C102C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x18C03A0", Offset = "0x18C03A0", VA = "0x18C03A0")]
	private void CreateMesh()
	{
	}

	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x18C010C", Offset = "0x18C010C", VA = "0x18C010C")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x18C02FC", Offset = "0x18C02FC", VA = "0x18C02FC")]
	private void SetProperties()
	{
	}

	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x18C106C", Offset = "0x18C106C", VA = "0x18C106C")]
	public CreateSmoothBarrier()
	{
	}
}
