using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	[Token(Token = "0x200002F")]
	public class DynamicMesh : IMesh
	{
		[Token(Token = "0x40000FA")]
		private const int capacity = 4048;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x10")]
		protected List<Vector2> uv;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x18")]
		protected List<Vector2> uv2;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x20")]
		protected List<Vector3> vertices;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x28")]
		protected List<Vector3> normals;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x30")]
		protected List<Vector4> tangents;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x38")]
		protected List<Color> vertexColors;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x40")]
		internal Color[] vertexColorsFreezed;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x48")]
		internal RecreationMode mode;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x4C")]
		private int lastVertexCount;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x50")]
		internal List<int> triangleIndices;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x58")]
		internal IndexTrashBin trashBin;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x60")]
		protected DecalBase Parent;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x68")]
		protected bool freezed;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x69")]
		private bool copiedOnce;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x0")]
		protected static Vector3 projectionDirection;

		[Token(Token = "0x17000057")]
		public List<Vector3> Vertices
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x2C5FA10", Offset = "0x2C5FA10", VA = "0x2C5FA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public List<Vector3> Normals
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x2C5FA18", Offset = "0x2C5FA18", VA = "0x2C5FA18", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x2C5FA20", Offset = "0x2C5FA20", VA = "0x2C5FA20")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public List<Vector4> Tangents
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x2C5FA28", Offset = "0x2C5FA28", VA = "0x2C5FA28", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x2C5FA30", Offset = "0x2C5FA30", VA = "0x2C5FA30")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public List<Color> VertexColors
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x2C5FA38", Offset = "0x2C5FA38", VA = "0x2C5FA38", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public List<int> TriangleIndices
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x2C5FA40", Offset = "0x2C5FA40", VA = "0x2C5FA40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public List<Vector2> UV
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x2C5FA48", Offset = "0x2C5FA48", VA = "0x2C5FA48", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public List<Vector2> UV2
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x2C5FA50", Offset = "0x2C5FA50", VA = "0x2C5FA50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		internal int VerticesAmount
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2C5FA58", Offset = "0x2C5FA58", VA = "0x2C5FA58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005F")]
		internal int IndicesAmount
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x2C5FAA4", Offset = "0x2C5FAA4", VA = "0x2C5FAA4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2C5FAF0", Offset = "0x2C5FAF0", VA = "0x2C5FAF0")]
		public DynamicMesh(DecalBase parent, RecreationMode mode)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2C5FE08", Offset = "0x2C5FE08", VA = "0x2C5FE08")]
		internal void Freeze()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2C5FE74", Offset = "0x2C5FE74", VA = "0x2C5FE74")]
		internal void Unfreeze()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2C5FE7C", Offset = "0x2C5FE7C", VA = "0x2C5FE7C", Slot = "11")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2C5934C", Offset = "0x2C5934C", VA = "0x2C5934C")]
		public void Add(Mesh mesh, Matrix4x4 localToWorld)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2C6031C", Offset = "0x2C6031C", VA = "0x2C6031C")]
		public void Add(SimpleMesh mesh, Matrix4x4 localToWorld)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2C58990", Offset = "0x2C58990", VA = "0x2C58990")]
		public void Add(Terrain terrain, Matrix4x4 localToWorld)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2C60430", Offset = "0x2C60430", VA = "0x2C60430")]
		private void Add(IList<int> triangles, IList<Vector3> vertices, IList<Vector3> normals, IList<Vector4> tangents, IList<Vector2> uvs, Matrix4x4 localToWorldMatrix)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2C609FC", Offset = "0x2C609FC", VA = "0x2C609FC")]
		protected void AddIndices(int indexA, int indexB, int indexC)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2C60AF8", Offset = "0x2C60AF8", VA = "0x2C60AF8", Slot = "12")]
		protected virtual void AddMeshData(IList<Vector3> vertices, IList<Vector3> normals, IList<Vector4> tangents, IList<Vector2> uvs, Matrix4x4 localToWorld)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2C61444", Offset = "0x2C61444", VA = "0x2C61444", Slot = "13")]
		protected virtual void OnProcessVertexIndex(int index, bool valid)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2C61448", Offset = "0x2C61448", VA = "0x2C61448", Slot = "14")]
		public virtual Mesh ConvertToMesh(Mesh target, bool forceRecreation = false)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2C615C8", Offset = "0x2C615C8", VA = "0x2C615C8")]
		private void CopyGeometryData(Mesh mesh)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2C61718", Offset = "0x2C61718", VA = "0x2C61718", Slot = "15")]
		internal virtual void RemoveRange(int startIndex, int count)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2C617F4", Offset = "0x2C617F4", VA = "0x2C617F4")]
		internal void RemoveTriangleAt(int index)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2C6185C", Offset = "0x2C6185C", VA = "0x2C6185C")]
		internal static void Assign(DynamicMesh dynMesh, Mesh mesh)
		{
		}
	}
}
