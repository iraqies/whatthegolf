using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1AFFE0", Offset = "0x1AFFE0")]
	[ExecuteInEditMode]
	public class SplineMesh : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000015")]
		public struct UVSettings
		{
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UVMode horizontalUVMode;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public UVMode verticalUVMode;
		}

		[Token(Token = "0x2000016")]
		public enum UVMode
		{
			[Token(Token = "0x4000055")]
			WorldSpace = 0,
			[Token(Token = "0x4000056")]
			Normalized = 1
		}

		[Serializable]
		[Token(Token = "0x2000017")]
		private class SerializableShapeGeneratorData
		{
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string assemblyQualifiedTypeName;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string json;

			[Token(Token = "0x1700002E")]
			public string AssemblyQualifiedTypeName
			{
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0x2A0D36C", Offset = "0x2A0D36C", VA = "0x2A0D36C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			public string Json
			{
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0x2A0D374", Offset = "0x2A0D374", VA = "0x2A0D374")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2A08590", Offset = "0x2A08590", VA = "0x2A08590")]
			public SerializableShapeGeneratorData(string assemblyQualifiedTypeName, string json)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B007C", Offset = "0x1B007C")]
		private struct _003C_003Ec__DisplayClass29_0
		{
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<Vertex> vertices;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<int> triangles;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SplineMesh _003C_003E4__this;
		}

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Spline spline;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool drawGizmos;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float ringsPerUnit;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float startOffset;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B02FC", Offset = "0x1B02FC")]
		private float startOffsetFraction;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StartOffsetMode startOffsetMode;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		public float endOffset;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B035C", Offset = "0x1B035C")]
		[SerializeField]
		private float endOffsetFraction;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private StartOffsetMode endOffsetMode;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UVSettings uvSettings;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<SerializableShapeGeneratorData> serializedData;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string selectedShapeGeneratorTypeName;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeReference]
		private IShapeGeneratorData selectedShapeGeneratorData;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ShapeGenerator shapeGenerator;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<Type, IShapeGeneratorData> dataByGeneratorType;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Mesh generatedMesh;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Vector3> vertexBuffer;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<Vector3> normalBuffer;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Vector2> uvBuffer;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<Vertex> vertices;

		[Token(Token = "0x1700002D")]
		public Spline _spline
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x2A06770", Offset = "0x2A06770", VA = "0x2A06770")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x2A06778", Offset = "0x2A06778", VA = "0x2A06778")]
			set
			{
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2A06780", Offset = "0x2A06780", VA = "0x2A06780")]
		internal void Reset()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2A06E40", Offset = "0x2A06E40", VA = "0x2A06E40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2A0705C", Offset = "0x2A0705C", VA = "0x2A0705C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A06880", Offset = "0x2A06880", VA = "0x2A06880")]
		internal void Generate()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A07198", Offset = "0x2A07198", VA = "0x2A07198")]
		private float GetStartOffset()
		{
			return default;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2A071E0", Offset = "0x2A071E0", VA = "0x2A071E0")]
		private float GetEndOffset()
		{
			return default;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A07378", Offset = "0x2A07378", VA = "0x2A07378")]
		private void GenerateEndCaps(List<Vertex> vertices, List<int> triangles)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A07230", Offset = "0x2A07230", VA = "0x2A07230")]
		private Vertex GetVertexForSplineValue(SplineValue value, Vertex2D pointVertex)
		{
			return default;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A0745C", Offset = "0x2A0745C", VA = "0x2A0745C")]
		private void UpdateMesh(Mesh mesh, List<Vertex> vertices, List<int> triangles)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2A07E40", Offset = "0x2A07E40", VA = "0x2A07E40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2A07E88", Offset = "0x2A07E88", VA = "0x2A07E88")]
		private void DrawGizmoLines()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2A08100", Offset = "0x2A08100", VA = "0x2A08100")]
		private void DrawGizmoVertices()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2A0822C", Offset = "0x2A0822C", VA = "0x2A0822C", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2A085C8", Offset = "0x2A085C8", VA = "0x2A085C8", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2A0860C", Offset = "0x2A0860C", VA = "0x2A0860C")]
		private void DeserializeGeneratorData()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2A08A70", Offset = "0x2A08A70", VA = "0x2A08A70")]
		private void RestoreSelectedShapeGenerator()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2A08D48", Offset = "0x2A08D48", VA = "0x2A08D48")]
		public SplineMesh()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2A07884", Offset = "0x2A07884", VA = "0x2A07884")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B076C", Offset = "0x1B076C")]
		internal static void _003CGenerateEndCaps_003Eg__FlipTriangles_007C29_0(Shape shape)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2A0799C", Offset = "0x2A0799C", VA = "0x2A0799C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B077C", Offset = "0x1B077C")]
		private void _003CGenerateEndCaps_003Eg__AddCap_007C29_1(Shape cap, float t, ref _003C_003Ec__DisplayClass29_0 P_2)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2A08D60", Offset = "0x2A08D60", VA = "0x2A08D60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B078C", Offset = "0x1B078C")]
		private Matrix4x4 _003CGenerateEndCaps_003Eg__CreateTransformationMatrix_007C29_2(float t, ref _003C_003Ec__DisplayClass29_0 P_1)
		{
			return default;
		}
	}
}
