using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B5A04", Offset = "0x1B5A04")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B5A04", Offset = "0x1B5A04")]
	[DisallowMultipleComponent]
	public sealed class ProBuilderMesh : MonoBehaviour
	{
		[Token(Token = "0x200001B")]
		[Flags]
		private enum CacheValidState : byte
		{
			[Token(Token = "0x4000095")]
			SharedVertex = 1,
			[Token(Token = "0x4000096")]
			SharedTexture = 2
		}

		[Serializable]
		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5AD0", Offset = "0x1B5AD0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Vector4, Vector2> _003C_003E9__100_0;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Vector4, Vector2> _003C_003E9__100_1;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<Face, int> _003C_003E9__108_0;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Face, int> _003C_003E9__110_0;

			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<Face, Face> _003C_003E9__140_0;

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2A5C9EC", Offset = "0x2A5C9EC", VA = "0x2A5C9EC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x2A5C9F4", Offset = "0x2A5C9F4", VA = "0x2A5C9F4")]
			internal Vector2 _003CSetUVs_003Eb__100_0(Vector4 x)
			{
				return default;
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2A5C9FC", Offset = "0x2A5C9FC", VA = "0x2A5C9FC")]
			internal Vector2 _003CSetUVs_003Eb__100_1(Vector4 x)
			{
				return default;
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2A5CA04", Offset = "0x2A5CA04", VA = "0x2A5CA04")]
			internal int _003Cget_indexCount_003Eb__108_0(Face x)
			{
				return default;
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2A5CA28", Offset = "0x2A5CA28", VA = "0x2A5CA28")]
			internal int _003Cget_triangleCount_003Eb__110_0(Face x)
			{
				return default;
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2A5CA4C", Offset = "0x2A5CA4C", VA = "0x2A5CA4C")]
			internal Face _003CCopyFrom_003Eb__140_0(Face x)
			{
				return null;
			}
		}

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5AE0", Offset = "0x1B5AE0")]
		private sealed class _003C_003Ec__DisplayClass143_0
		{
			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2A54CF4", Offset = "0x2A54CF4", VA = "0x2A54CF4")]
			public _003C_003Ec__DisplayClass143_0()
			{
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2A5CABC", Offset = "0x2A5CABC", VA = "0x2A5CABC")]
			internal bool _003CGetUnusedTextureGroup_003Eb__0(Face element)
			{
				return default;
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5AF0", Offset = "0x1B5AF0")]
		private sealed class _003C_003Ec__DisplayClass145_0
		{
			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2A54E1C", Offset = "0x2A54E1C", VA = "0x2A54E1C")]
			public _003C_003Ec__DisplayClass145_0()
			{
			}

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x2A5CAE0", Offset = "0x2A5CAE0", VA = "0x2A5CAE0")]
			internal bool _003CUnusedElementGroup_003Eb__0(Face element)
			{
				return default;
			}
		}

		[Token(Token = "0x400006F")]
		private const int k_UVChannelCount = 4;

		[Token(Token = "0x4000070")]
		private const int k_MeshFormatVersion = 1;

		[Token(Token = "0x4000071")]
		private const int k_MeshFormatVersionSubmeshMaterialRefactor = 1;

		[Token(Token = "0x4000072")]
		public const uint maxVertexCount = 65535u;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_MeshFormatVersion;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B614C", Offset = "0x1B614C")]
		[SerializeField]
		private Face[] m_Faces;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6198", Offset = "0x1B6198")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6198", Offset = "0x1B6198")]
		[SerializeField]
		private SharedVertex[] m_SharedVertices;

		[NonSerialized]
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CacheValidState m_CacheValid;

		[NonSerialized]
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> m_SharedVertexLookup;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6208", Offset = "0x1B6208")]
		[SerializeField]
		private SharedVertex[] m_SharedTextures;

		[NonSerialized]
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<int, int> m_SharedTextureLookup;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6254", Offset = "0x1B6254")]
		private Vector3[] m_Positions;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B62A0", Offset = "0x1B62A0")]
		[SerializeField]
		private Vector2[] m_Textures0;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B62EC", Offset = "0x1B62EC")]
		private List<Vector4> m_Textures2;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6338", Offset = "0x1B6338")]
		private List<Vector4> m_Textures3;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6384", Offset = "0x1B6384")]
		private Vector4[] m_Tangents;

		[NonSerialized]
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] m_Normals;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B63D0", Offset = "0x1B63D0")]
		[SerializeField]
		private Color[] m_Colors;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B641C", Offset = "0x1B641C")]
		private bool userCollisions__BackingField;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B642C", Offset = "0x1B642C")]
		[SerializeField]
		private UnwrapParameters m_UnwrapParameters;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6478", Offset = "0x1B6478")]
		[SerializeField]
		private bool m_PreserveMeshAssetOnDestroy;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		internal string assetGuid;

		[NonSerialized]
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private MeshRenderer m_MeshRenderer;

		[NonSerialized]
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private MeshFilter m_MeshFilter;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B64D4", Offset = "0x1B64D4")]
		private static Action<ProBuilderMesh> m_meshWillBeDestroyed;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B64E4", Offset = "0x1B64E4")]
		private static Action<ProBuilderMesh> m_componentWillBeDestroyed;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B64F4", Offset = "0x1B64F4")]
		private static Action<ProBuilderMesh> m_elementSelectionChanged;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static HashSet<int> s_CachedHashSet;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool m_IsSelectable;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private int[] m_SelectedFaces;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Edge[] m_SelectedEdges;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int[] m_SelectedVertices;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_SelectedCacheDirty;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int m_SelectedSharedVerticesCount;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int m_SelectedCoincidentVertexCount;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HashSet<int> m_SelectedSharedVertices;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<int> m_SelectedCoincidentVertices;

		[Token(Token = "0x17000020")]
		public bool userCollisions
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2A4DC0C", Offset = "0x2A4DC0C", VA = "0x2A4DC0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B68C4", Offset = "0x1B68C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2A4DC14", Offset = "0x2A4DC14", VA = "0x2A4DC14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B68D4", Offset = "0x1B68D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public UnwrapParameters unwrapParameters
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2A4DC1C", Offset = "0x2A4DC1C", VA = "0x2A4DC1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2A4DC24", Offset = "0x2A4DC24", VA = "0x2A4DC24")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		internal MeshRenderer renderer
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2A4DC2C", Offset = "0x2A4DC2C", VA = "0x2A4DC2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		internal MeshFilter filter
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x2A4DCD8", Offset = "0x2A4DCD8", VA = "0x2A4DCD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public bool preserveMeshAssetOnDestroy
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2A4DD84", Offset = "0x2A4DD84", VA = "0x2A4DD84")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2A4DD8C", Offset = "0x2A4DD8C", VA = "0x2A4DD8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		internal Face[] facesInternal
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x2A4DDB4", Offset = "0x2A4DDB4", VA = "0x2A4DDB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x2A4DDBC", Offset = "0x2A4DDBC", VA = "0x2A4DDBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public IList<Face> faces
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x2A4DDC4", Offset = "0x2A4DDC4", VA = "0x2A4DDC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x2A4DE44", Offset = "0x2A4DE44", VA = "0x2A4DE44")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		internal SharedVertex[] sharedVerticesInternal
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2A4E418", Offset = "0x2A4E418", VA = "0x2A4E418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2A4E420", Offset = "0x2A4E420", VA = "0x2A4E420")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public IList<SharedVertex> sharedVertices
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2A4E428", Offset = "0x2A4E428", VA = "0x2A4E428")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2A4E4A8", Offset = "0x2A4E4A8", VA = "0x2A4E4A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		internal Dictionary<int, int> sharedVertexLookup
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x2A4E7E4", Offset = "0x2A4E7E4", VA = "0x2A4E7E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		internal SharedVertex[] sharedTextures
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2A4F370", Offset = "0x2A4F370", VA = "0x2A4F370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2A4F378", Offset = "0x2A4F378", VA = "0x2A4F378")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		internal Dictionary<int, int> sharedTextureLookup
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2A4F380", Offset = "0x2A4F380", VA = "0x2A4F380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		internal Vector3[] positionsInternal
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x2A4F430", Offset = "0x2A4F430", VA = "0x2A4F430")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2A4F438", Offset = "0x2A4F438", VA = "0x2A4F438")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public IList<Vector3> positions
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x2A4F440", Offset = "0x2A4F440", VA = "0x2A4F440")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x2A4F4C0", Offset = "0x2A4F4C0", VA = "0x2A4F4C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public IList<Vector3> normals
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2A506E8", Offset = "0x2A506E8", VA = "0x2A506E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		internal Vector3[] normalsInternal
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2A50774", Offset = "0x2A50774", VA = "0x2A50774")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x2A5077C", Offset = "0x2A5077C", VA = "0x2A5077C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		internal Color[] colorsInternal
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2A50784", Offset = "0x2A50784", VA = "0x2A50784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2A5078C", Offset = "0x2A5078C", VA = "0x2A5078C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public IList<Color> colors
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2A50794", Offset = "0x2A50794", VA = "0x2A50794")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2A50820", Offset = "0x2A50820", VA = "0x2A50820")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public IList<Vector4> tangents
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2A50A64", Offset = "0x2A50A64", VA = "0x2A50A64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2A50B00", Offset = "0x2A50B00", VA = "0x2A50B00")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		internal Vector4[] tangentsInternal
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2A50BFC", Offset = "0x2A50BFC", VA = "0x2A50BFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x2A50C04", Offset = "0x2A50C04", VA = "0x2A50C04")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		internal Vector2[] texturesInternal
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x2A50C0C", Offset = "0x2A50C0C", VA = "0x2A50C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2A50C14", Offset = "0x2A50C14", VA = "0x2A50C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public IList<Vector2> textures
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x2A50C1C", Offset = "0x2A50C1C", VA = "0x2A50C1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x2A50CA8", Offset = "0x2A50CA8", VA = "0x2A50CA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public int faceCount
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2A4D874", Offset = "0x2A4D874", VA = "0x2A4D874")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000037")]
		public int vertexCount
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2A4CA34", Offset = "0x2A4CA34", VA = "0x2A4CA34")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000038")]
		public int edgeCount
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2A51240", Offset = "0x2A51240", VA = "0x2A51240")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000039")]
		public int indexCount
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2A512E8", Offset = "0x2A512E8", VA = "0x2A512E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003A")]
		public int triangleCount
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2A51438", Offset = "0x2A51438", VA = "0x2A51438")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003B")]
		internal Mesh mesh
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2A4DD94", Offset = "0x2A4DD94", VA = "0x2A4DD94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2A51BD4", Offset = "0x2A51BD4", VA = "0x2A51BD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		internal int id
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2A51C04", Offset = "0x2A51C04", VA = "0x2A51C04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003D")]
		public MeshSyncState meshSyncState
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2A51C28", Offset = "0x2A51C28", VA = "0x2A51C28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003E")]
		public bool selectable
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2A57BC4", Offset = "0x2A57BC4", VA = "0x2A57BC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2A57BCC", Offset = "0x2A57BCC", VA = "0x2A57BCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int selectedFaceCount
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2A57BD4", Offset = "0x2A57BD4", VA = "0x2A57BD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public int selectedVertexCount
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x2A57BF0", Offset = "0x2A57BF0", VA = "0x2A57BF0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000041")]
		public int selectedEdgeCount
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2A57C0C", Offset = "0x2A57C0C", VA = "0x2A57C0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		internal int selectedSharedVerticesCount
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x2A57C28", Offset = "0x2A57C28", VA = "0x2A57C28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		internal int selectedCoincidentVertexCount
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2A580F8", Offset = "0x2A580F8", VA = "0x2A580F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000044")]
		internal IEnumerable<int> selectedSharedVertices
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x2A5811C", Offset = "0x2A5811C", VA = "0x2A5811C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		internal IEnumerable<int> selectedCoincidentVertices
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2A58140", Offset = "0x2A58140", VA = "0x2A58140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public ReadOnlyCollection<int> selectedFaceIndexes
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2A58328", Offset = "0x2A58328", VA = "0x2A58328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public ReadOnlyCollection<int> selectedVertices
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2A583A8", Offset = "0x2A583A8", VA = "0x2A583A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public ReadOnlyCollection<Edge> selectedEdges
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2A58428", Offset = "0x2A58428", VA = "0x2A58428")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		internal Face[] selectedFacesInternal
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2A584A8", Offset = "0x2A584A8", VA = "0x2A584A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x2A584AC", Offset = "0x2A584AC", VA = "0x2A584AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		internal int[] selectedFaceIndicesInternal
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x2A58594", Offset = "0x2A58594", VA = "0x2A58594")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2A5859C", Offset = "0x2A5859C", VA = "0x2A5859C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		internal Edge[] selectedEdgesInternal
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2A585A4", Offset = "0x2A585A4", VA = "0x2A585A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x2A585AC", Offset = "0x2A585AC", VA = "0x2A585AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		internal int[] selectedIndexesInternal
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x2A585B4", Offset = "0x2A585B4", VA = "0x2A585B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x2A585BC", Offset = "0x2A585BC", VA = "0x2A585BC")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action<ProBuilderMesh> meshWillBeDestroyed
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2A51594", Offset = "0x2A51594", VA = "0x2A51594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B68E4", Offset = "0x1B68E4")]
			add
			{
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2A5169C", Offset = "0x2A5169C", VA = "0x2A5169C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B68F4", Offset = "0x1B68F4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		internal static event Action<ProBuilderMesh> componentWillBeDestroyed
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2A517A4", Offset = "0x2A517A4", VA = "0x2A517A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6904", Offset = "0x1B6904")]
			add
			{
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2A518B0", Offset = "0x2A518B0", VA = "0x2A518B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6914", Offset = "0x1B6914")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action<ProBuilderMesh> elementSelectionChanged
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2A519BC", Offset = "0x2A519BC", VA = "0x2A519BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6924", Offset = "0x1B6924")]
			add
			{
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2A51AC8", Offset = "0x2A51AC8", VA = "0x2A51AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6934", Offset = "0x1B6934")]
			remove
			{
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2A4CA4C", Offset = "0x2A4CA4C", VA = "0x2A4CA4C")]
		public bool HasArrays(MeshArrays channels)
		{
			return default;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A4DEF0", Offset = "0x2A4DEF0", VA = "0x2A4DEF0")]
		internal void InvalidateSharedVertexLookup()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A4DFAC", Offset = "0x2A4DFAC", VA = "0x2A4DFAC")]
		internal void InvalidateSharedTextureLookup()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A4E068", Offset = "0x2A4E068", VA = "0x2A4E068")]
		internal void InvalidateFaces()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A4E3E0", Offset = "0x2A4E3E0", VA = "0x2A4E3E0")]
		internal void InvalidateCaches()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2A4ED38", Offset = "0x2A4ED38", VA = "0x2A4ED38")]
		internal void SetSharedVertices(IEnumerable<KeyValuePair<int, int>> indexes)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2A4F3B8", Offset = "0x2A4F3B8", VA = "0x2A4F3B8")]
		internal void SetSharedTextures(IEnumerable<KeyValuePair<int, int>> indexes)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A4F56C", Offset = "0x2A4F56C", VA = "0x2A4F56C")]
		public Vertex[] GetVertices([Optional] IList<int> indexes)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A50294", Offset = "0x2A50294", VA = "0x2A50294")]
		public void SetVertices(IList<Vertex> vertices, bool applyMesh = false)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A4CD00", Offset = "0x2A4CD00", VA = "0x2A4CD00")]
		public Vector3[] GetNormals()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2A5091C", Offset = "0x2A5091C", VA = "0x2A5091C")]
		public Color[] GetColors()
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2A4FD28", Offset = "0x2A4FD28", VA = "0x2A4FD28")]
		public Vector4[] GetTangents()
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A4FE78", Offset = "0x2A4FE78", VA = "0x2A4FE78")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2A50D90", Offset = "0x2A50D90", VA = "0x2A50D90")]
		internal ReadOnlyCollection<Vector2> GetUVs(int channel)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A50EBC", Offset = "0x2A50EBC", VA = "0x2A50EBC")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2A50550", Offset = "0x2A50550", VA = "0x2A50550")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2A51E24", Offset = "0x2A51E24", VA = "0x2A51E24")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2A51EBC", Offset = "0x2A51EBC", VA = "0x2A51EBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2A52094", Offset = "0x2A52094", VA = "0x2A52094")]
		internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2A523E4", Offset = "0x2A523E4", VA = "0x2A523E4")]
		public static ProBuilderMesh Create()
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2A52478", Offset = "0x2A52478", VA = "0x2A52478")]
		public static ProBuilderMesh Create(IEnumerable<Vector3> positions, IEnumerable<Face> faces)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2A52668", Offset = "0x2A52668", VA = "0x2A52668")]
		public static ProBuilderMesh Create(IList<Vertex> vertices, IList<Face> faces, [Optional] IList<SharedVertex> sharedVertices, [Optional] IList<SharedVertex> sharedTextures, [Optional] IList<Material> materials)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2A521B4", Offset = "0x2A521B4", VA = "0x2A521B4")]
		private void GeometryWithPoints(Vector3[] points)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2A52554", Offset = "0x2A52554", VA = "0x2A52554")]
		public void RebuildWithPositionsAndFaces(IEnumerable<Vector3> vertices, IEnumerable<Face> faces)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2A51E90", Offset = "0x2A51E90", VA = "0x2A51E90")]
		internal void Rebuild()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2A52808", Offset = "0x2A52808", VA = "0x2A52808")]
		public void ToMesh(MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2A53D14", Offset = "0x2A53D14", VA = "0x2A53D14")]
		internal void MakeUnique()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2A53DA4", Offset = "0x2A53DA4", VA = "0x2A53DA4")]
		public void CopyFrom(ProBuilderMesh other)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2A52B40", Offset = "0x2A52B40", VA = "0x2A52B40")]
		public void Refresh(RefreshMask mask = RefreshMask.All)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2A54A90", Offset = "0x2A54A90", VA = "0x2A54A90")]
		private void RefreshCollisions()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2A54BE0", Offset = "0x2A54BE0", VA = "0x2A54BE0")]
		internal int GetUnusedTextureGroup(int i = 1)
		{
			return default;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2A54CFC", Offset = "0x2A54CFC", VA = "0x2A54CFC")]
		private static bool IsValidTextureGroup(int group)
		{
			return default;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2A54D08", Offset = "0x2A54D08", VA = "0x2A54D08")]
		internal int UnusedElementGroup(int i = 1)
		{
			return default;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2A542C4", Offset = "0x2A542C4", VA = "0x2A542C4")]
		public void RefreshUV(IEnumerable<Face> facesToRefresh)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2A55130", Offset = "0x2A55130", VA = "0x2A55130")]
		internal void SetGroupUV(AutoUnwrapSettings settings, int group)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2A54934", Offset = "0x2A54934", VA = "0x2A54934")]
		private void RefreshColors()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2A55220", Offset = "0x2A55220", VA = "0x2A55220")]
		public void SetFaceColor(Face face, Color color)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2A5563C", Offset = "0x2A5563C", VA = "0x2A5563C")]
		public void SetMaterial(IEnumerable<Face> faces, Material material)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2A54970", Offset = "0x2A54970", VA = "0x2A54970")]
		private void RefreshNormals()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2A54A00", Offset = "0x2A54A00", VA = "0x2A54A00")]
		private void RefreshTangents()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2A55BA0", Offset = "0x2A55BA0", VA = "0x2A55BA0")]
		internal int GetSharedVertexHandle(int vertex)
		{
			return default;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2A55CE4", Offset = "0x2A55CE4", VA = "0x2A55CE4")]
		internal HashSet<int> GetSharedVertexHandles(IEnumerable<int> vertices)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2A5608C", Offset = "0x2A5608C", VA = "0x2A5608C")]
		public List<int> GetCoincidentVertices(IEnumerable<int> vertices)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2A566C8", Offset = "0x2A566C8", VA = "0x2A566C8")]
		public void GetCoincidentVertices(IEnumerable<Face> faces, List<int> coincident)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2A56CB0", Offset = "0x2A56CB0", VA = "0x2A56CB0")]
		public void GetCoincidentVertices(IEnumerable<Edge> edges, List<int> coincident)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2A56164", Offset = "0x2A56164", VA = "0x2A56164")]
		public void GetCoincidentVertices(IEnumerable<int> vertices, List<int> coincident)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2A573AC", Offset = "0x2A573AC", VA = "0x2A573AC")]
		public void GetCoincidentVertices(int vertex, List<int> coincident)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2A5754C", Offset = "0x2A5754C", VA = "0x2A5754C")]
		public void SetVerticesCoincident(IEnumerable<int> vertices)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2A57958", Offset = "0x2A57958", VA = "0x2A57958")]
		internal void SetTexturesCoincident(IEnumerable<int> vertices)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2A579BC", Offset = "0x2A579BC", VA = "0x2A579BC")]
		internal void AddToSharedVertex(int sharedVertexHandle, int vertex)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2A57B10", Offset = "0x2A57B10", VA = "0x2A57B10")]
		internal void AddSharedVertex(SharedVertex vertex)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2A57C4C", Offset = "0x2A57C4C", VA = "0x2A57C4C")]
		private void CacheSelection()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2A58218", Offset = "0x2A58218", VA = "0x2A58218")]
		public Face[] GetSelectedFaces()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2A585C4", Offset = "0x2A585C4", VA = "0x2A585C4")]
		internal Face GetActiveFace()
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2A58630", Offset = "0x2A58630", VA = "0x2A58630")]
		internal Edge GetActiveEdge()
		{
			return default;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2A586C4", Offset = "0x2A586C4", VA = "0x2A586C4")]
		internal int GetActiveVertex()
		{
			return default;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2A58700", Offset = "0x2A58700", VA = "0x2A58700")]
		internal void AddToFaceSelection(int index)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2A58A40", Offset = "0x2A58A40", VA = "0x2A58A40")]
		public void SetSelectedFaces(IEnumerable<Face> selected)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2A5877C", Offset = "0x2A5877C", VA = "0x2A5877C")]
		internal void SetSelectedFaces(IEnumerable<int> selected)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2A58B1C", Offset = "0x2A58B1C", VA = "0x2A58B1C")]
		public void SetSelectedEdges(IEnumerable<Edge> edges)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2A58CC0", Offset = "0x2A58CC0", VA = "0x2A58CC0")]
		public void SetSelectedVertices(IEnumerable<int> vertices)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2A58E44", Offset = "0x2A58E44", VA = "0x2A58E44")]
		internal void RemoveFromFaceSelectionAtIndex(int index)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2A51D8C", Offset = "0x2A51D8C", VA = "0x2A51D8C")]
		public void ClearSelection()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2A58EAC", Offset = "0x2A58EAC", VA = "0x2A58EAC")]
		public ProBuilderMesh()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2A5906C", Offset = "0x2A5906C", VA = "0x2A5906C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6944", Offset = "0x1B6944")]
		private int _003Cset_selectedFacesInternal_003Eb__200_0(Face x)
		{
			return default;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2A590C8", Offset = "0x2A590C8", VA = "0x2A590C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6954", Offset = "0x1B6954")]
		private int _003CSetSelectedFaces_003Eb__214_0(Face x)
		{
			return default;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2A59124", Offset = "0x2A59124", VA = "0x2A59124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6964", Offset = "0x1B6964")]
		private IEnumerable<int> _003CSetSelectedFaces_003Eb__215_0(int x)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2A59178", Offset = "0x2A59178", VA = "0x2A59178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B6974", Offset = "0x1B6974")]
		private IEnumerable<Edge> _003CSetSelectedFaces_003Eb__215_1(int x)
		{
			return null;
		}
	}
}
