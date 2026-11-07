using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C43")]
public class SetVertexColors : ScriptableObject
{
	[Token(Token = "0x2000C44")]
	public class MeshToSave
	{
		[Token(Token = "0x400435F")]
		[FieldOffset(Offset = "0x10")]
		public Mesh Mesh;

		[Token(Token = "0x4004360")]
		[FieldOffset(Offset = "0x18")]
		public Mesh MeshPath;

		[Token(Token = "0x6003A6A")]
		[Address(RVA = "0x18431E0", Offset = "0x18431E0", VA = "0x18431E0")]
		public MeshToSave()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000C45")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44098", Offset = "0x44098")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004361")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004362")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MeshFilter, int> _003C_003E9__7_0;

		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x18431AC", Offset = "0x18431AC", VA = "0x18431AC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x18431B4", Offset = "0x18431B4", VA = "0x18431B4")]
		internal int _003CCombineMeshes_003Eb__7_0(MeshFilter f)
		{
			return default;
		}
	}

	[Token(Token = "0x400435B")]
	[FieldOffset(Offset = "0x18")]
	public bool DoUpdate;

	[Token(Token = "0x400435C")]
	[FieldOffset(Offset = "0x20")]
	public Material CombinedMaterial;

	[Token(Token = "0x400435D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PrefabToOptimize;

	[Token(Token = "0x400435E")]
	[FieldOffset(Offset = "0x30")]
	public Mesh MeshToSimplify;

	[Token(Token = "0x6003A66")]
	[Address(RVA = "0x1690E1C", Offset = "0x1690E1C", VA = "0x1690E1C")]
	public MeshToSave Optimize(Material combinedMaterial, GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6003A67")]
	[Address(RVA = "0x169123C", Offset = "0x169123C", VA = "0x169123C")]
	private void CombineSkinnedMeshes(SkinnedMeshRenderer renderer, Mesh newMesh)
	{
	}

	[Token(Token = "0x6003A68")]
	[Address(RVA = "0x1691AC0", Offset = "0x1691AC0", VA = "0x1691AC0")]
	private void CombineMeshes(MeshFilter[] filters, Mesh newMesh)
	{
	}

	[Token(Token = "0x6003A69")]
	[Address(RVA = "0x16923C4", Offset = "0x16923C4", VA = "0x16923C4")]
	public SetVertexColors()
	{
	}
}
