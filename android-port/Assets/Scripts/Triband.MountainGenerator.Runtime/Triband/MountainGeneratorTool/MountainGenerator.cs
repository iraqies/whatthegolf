using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.MountainGeneratorTool
{
	[Token(Token = "0x2000002")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1AFD7C", Offset = "0x1AFD7C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1AFD7C", Offset = "0x1AFD7C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1AFD7C", Offset = "0x1AFD7C")]
	public sealed class MountainGenerator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFE64", Offset = "0x1AFE64")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Vector3, Vector2> _003C_003E9__20_0;

			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2A01AC8", Offset = "0x2A01AC8", VA = "0x2A01AC8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2A01AD0", Offset = "0x2A01AD0", VA = "0x2A01AD0")]
			internal Vector2 _003CBuildMountain_003Eb__20_0(Vector3 v)
			{
				return default;
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		public MountainSettings Settings;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		public bool LockHeight;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> Points;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Transform> pointTransforms;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x38")]
		private Mesh mesh;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x40")]
		private Material[] materials;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x48")]
		private Material pointMaterial;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x50")]
		private MeshFilter m_Filter;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x58")]
		private MeshRenderer m_Renderer;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x60")]
		private MeshCollider m_Collider;

		[Token(Token = "0x400000B")]
		private const string kPointName = "point";

		[Token(Token = "0x400000C")]
		private const string kPointShaderName = "PointShader";

		[Token(Token = "0x17000001")]
		internal MeshFilter filter
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x29FEE00", Offset = "0x29FEE00", VA = "0x29FEE00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		internal MeshRenderer renderer
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x29FEEAC", Offset = "0x29FEEAC", VA = "0x29FEEAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		internal MeshCollider collider
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x29FEF58", Offset = "0x29FEF58", VA = "0x29FEF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x29FF004", Offset = "0x29FF004", VA = "0x29FF004")]
		private void Update()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2A0007C", Offset = "0x2A0007C", VA = "0x2A0007C")]
		private static Vector3 Bezier(Vector3 start, Vector3 control, Vector3 end, float t)
		{
			return default;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x29FF614", Offset = "0x29FF614", VA = "0x29FF614")]
		public void BuildMountain()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2A000DC", Offset = "0x2A000DC", VA = "0x2A000DC")]
		public void AddPoint(Vector3 pos, bool rebuild = true)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2A00354", Offset = "0x2A00354", VA = "0x2A00354")]
		public void InsertPoint(int index, Vector3 pos, bool rebuild = true)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2A006EC", Offset = "0x2A006EC", VA = "0x2A006EC")]
		public void RemovePoint(int index, bool rebuild = true)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A008A8", Offset = "0x2A008A8", VA = "0x2A008A8")]
		public void MovePoint(int index, Vector3 pos)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x29FF378", Offset = "0x29FF378", VA = "0x29FF378")]
		private void CheckTransformList()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2A0045C", Offset = "0x2A0045C", VA = "0x2A0045C")]
		private Transform CreatePointTransform(Vector3 pos)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A00168", Offset = "0x2A00168", VA = "0x2A00168")]
		private void AddBevels(List<Vector3> vertices, List<Vector3> normals, List<List<int>> triangles)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A009CC", Offset = "0x2A009CC", VA = "0x2A009CC")]
		private static float CalculateSlope(float height, float size)
		{
			return default;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A0150C", Offset = "0x2A0150C", VA = "0x2A0150C")]
		private static void AddSide(IReadOnlyList<Vector3> top, IReadOnlyList<Vector3> bottom, List<Vector3> vertices, List<List<int>> triangles)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A0165C", Offset = "0x2A0165C", VA = "0x2A0165C")]
		private static List<int> CreateTriangles(int startOffset, int pointCount)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A00A10", Offset = "0x2A00A10", VA = "0x2A00A10")]
		private static List<Vector3> CalculateNormals(IReadOnlyList<Vector3> vertices, float slope)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A00F34", Offset = "0x2A00F34", VA = "0x2A00F34")]
		private static List<Vector3> CreateSideVertices(IReadOnlyList<Vector3> fromPolygon, float height, float size)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A0178C", Offset = "0x2A0178C", VA = "0x2A0178C")]
		private static bool ContainsPoint(IReadOnlyList<Vector2> polyPoints, Vector2 p)
		{
			return default;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A01A30", Offset = "0x2A01A30", VA = "0x2A01A30")]
		public MountainGenerator()
		{
		}
	}
}
