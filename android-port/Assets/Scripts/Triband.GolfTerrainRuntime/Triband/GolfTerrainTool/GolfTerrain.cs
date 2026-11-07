using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Token(Token = "0x2000002")]
	[Attribute(Name = "RequireComponent", RVA = "0x1AF9C8", Offset = "0x1AF9C8")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public sealed class GolfTerrain : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshFilter m_MeshFilter;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer m_MeshRenderer;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TerrainData m_TerrainData;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasParameters m_CanvasParameters;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshParameters m_MeshParameters;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RendererParameters m_RendererParameters;

		[Token(Token = "0x4000007")]
		private const string kChildName = "Renderer";

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MeshCollider m_MeshCollider;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_IsDirty;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Mesh m_Mesh;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_Material;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Shader m_Shader;

		[Token(Token = "0x17000001")]
		public TerrainData terrainData
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x29FAA3C", Offset = "0x29FAA3C", VA = "0x29FAA3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x29FAA44", Offset = "0x29FAA44", VA = "0x29FAA44")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public CanvasParameters canvasParameters
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x29FAA4C", Offset = "0x29FAA4C", VA = "0x29FAA4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x29FAA54", Offset = "0x29FAA54", VA = "0x29FAA54")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public MeshParameters meshParameters
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x29FAA5C", Offset = "0x29FAA5C", VA = "0x29FAA5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x29FAA64", Offset = "0x29FAA64", VA = "0x29FAA64")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public RendererParameters rendererParameters
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x29FAA6C", Offset = "0x29FAA6C", VA = "0x29FAA6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x29FAA74", Offset = "0x29FAA74", VA = "0x29FAA74")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public MeshCollider meshCollider
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x29FAA7C", Offset = "0x29FAA7C", VA = "0x29FAA7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public Mesh mesh
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x29FAB28", Offset = "0x29FAB28", VA = "0x29FAB28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x29FAC5C", Offset = "0x29FAC5C", VA = "0x29FAC5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public Shader shader
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x29FACC4", Offset = "0x29FACC4", VA = "0x29FACC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public Material material
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x29FAD84", Offset = "0x29FAD84", VA = "0x29FAD84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x29FAF1C", Offset = "0x29FAF1C", VA = "0x29FAF1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x29FAA34", Offset = "0x29FAA34", VA = "0x29FAA34")]
		public GolfTerrain()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x29FAF24", Offset = "0x29FAF24", VA = "0x29FAF24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x29FB470", Offset = "0x29FB470", VA = "0x29FB470")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x29FB708", Offset = "0x29FB708", VA = "0x29FB708")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x29FB788", Offset = "0x29FB788", VA = "0x29FB788")]
		public void Init([Optional] TerrainData terrainData, [Optional] CanvasParameters canvasParameters, [Optional] MeshParameters meshParameters, [Optional] RendererParameters rendererParameters)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x29FBA78", Offset = "0x29FBA78", VA = "0x29FBA78")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x29FBA84", Offset = "0x29FBA84", VA = "0x29FBA84")]
		public void HandleChanges()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x29FB3F8", Offset = "0x29FB3F8", VA = "0x29FB3F8")]
		public void UpdateMesh()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x29FAC64", Offset = "0x29FAC64", VA = "0x29FAC64")]
		private void UpdateMeshComponents()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x29FC030", Offset = "0x29FC030", VA = "0x29FC030")]
		public void UpdateRendererComponents()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x29FB124", Offset = "0x29FB124", VA = "0x29FB124")]
		private void AddRendererComponents()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x29FC064", Offset = "0x29FC064", VA = "0x29FC064")]
		private void OnDrawGizmos()
		{
		}
	}
}
