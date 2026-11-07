using System;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B9374", Offset = "0x1B9374")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class TextMeshPro : TMP_Text, ILayoutElement
	{
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x6C0")]
		[SerializeField]
		private bool m_hasFontAssetChanged;

		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x6C4")]
		private float m_previousLossyScaleY;

		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x6C8")]
		[SerializeField]
		private Renderer m_renderer;

		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x6D0")]
		private MeshFilter m_meshFilter;

		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x6D8")]
		private bool m_isFirstAllocation;

		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x6DC")]
		private int m_max_characters;

		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x6E0")]
		private int m_max_numberOfLines;

		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x6E8")]
		private TMP_SubMesh[] m_subTextObjects;

		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x6F0")]
		[SerializeField]
		private MaskingTypes m_maskType;

		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x6F4")]
		private Matrix4x4 m_EnvMapMatrix;

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x738")]
		private Vector3[] m_RectTransformCorners;

		[NonSerialized]
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x740")]
		private bool m_isRegisteredForEvents;

		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker k_GenerateTextMarker;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_SetArraySizesMarker;

		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_GenerateTextPhaseIMarker;

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_ParseMarkupTextMarker;

		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_CharacterLookupMarker;

		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_HandleGPOSFeaturesMarker;

		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker k_CalculateVerticesPositionMarker;

		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker k_ComputeTextMetricsMarker;

		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x40")]
		private static ProfilerMarker k_HandleVisibleCharacterMarker;

		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x48")]
		private static ProfilerMarker k_HandleWhiteSpacesMarker;

		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x50")]
		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker;

		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x58")]
		private static ProfilerMarker k_HandleVerticalLineBreakingMarker;

		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x60")]
		private static ProfilerMarker k_SaveGlyphVertexDataMarker;

		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x68")]
		private static ProfilerMarker k_ComputeCharacterAdvanceMarker;

		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x70")]
		private static ProfilerMarker k_HandleCarriageReturnMarker;

		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x78")]
		private static ProfilerMarker k_HandleLineTerminationMarker;

		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x80")]
		private static ProfilerMarker k_SavePageInfoMarker;

		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x88")]
		private static ProfilerMarker k_SaveProcessingStatesMarker;

		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x90")]
		private static ProfilerMarker k_GenerateTextPhaseIIMarker;

		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x98")]
		private static ProfilerMarker k_GenerateTextPhaseIIIMarker;

		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x744")]
		[SerializeField]
		internal int _SortingLayer;

		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x748")]
		[SerializeField]
		internal int _SortingLayerID;

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x74C")]
		[SerializeField]
		internal int _SortingOrder;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x750")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA5B8", Offset = "0x1BA5B8")]
		private new Action<TMP_TextInfo> m_OnPreRenderText;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x758")]
		private bool m_currentAutoSizeMode;

		[Token(Token = "0x1700013D")]
		public int sortingLayerID
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x2ACC38C", Offset = "0x2ACC38C", VA = "0x2ACC38C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x2ACC4E4", Offset = "0x2ACC4E4", VA = "0x2ACC4E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public int sortingOrder
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x2ACC5A4", Offset = "0x2ACC5A4", VA = "0x2ACC5A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x2ACC650", Offset = "0x2ACC650", VA = "0x2ACC650")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public override bool autoSizeTextContainer
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x2ACC710", Offset = "0x2ACC710", VA = "0x2ACC710", Slot = "71")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x2ACC718", Offset = "0x2ACC718", VA = "0x2ACC718", Slot = "72")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BA9E0", Offset = "0x1BA9E0")]
		public TextContainer textContainer
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x2ACC800", Offset = "0x2ACC800", VA = "0x2ACC800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000141")]
		public new Transform transform
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x2ABDF60", Offset = "0x2ABDF60", VA = "0x2ABDF60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000142")]
		public Renderer renderer
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x2ACC438", Offset = "0x2ACC438", VA = "0x2ACC438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000143")]
		public override Mesh mesh
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x2ACC808", Offset = "0x2ACC808", VA = "0x2ACC808", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x2ABE160", Offset = "0x2ABE160", VA = "0x2ABE160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000145")]
		public MaskingTypes maskType
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x2ACC8D4", Offset = "0x2ACC8D4", VA = "0x2ACC8D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x2ACC8DC", Offset = "0x2ACC8DC", VA = "0x2ACC8DC")]
			set
			{
			}
		}

		[Token(Token = "0x14000004")]
		public override event Action<TMP_TextInfo> OnPreRenderText
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x2ACD180", Offset = "0x2ACD180", VA = "0x2ACD180", Slot = "74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA8B8", Offset = "0x1BA8B8")]
			add
			{
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x2ACD224", Offset = "0x2ACD224", VA = "0x2ACD224", Slot = "75")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA8C8", Offset = "0x1BA8C8")]
			remove
			{
			}
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2ABDB90", Offset = "0x2ABDB90", VA = "0x2ABDB90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2ABE00C", Offset = "0x2ABE00C", VA = "0x2ABE00C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2ABE284", Offset = "0x2ABE284", VA = "0x2ABE284", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2ABE384", Offset = "0x2ABE384", VA = "0x2ABE384", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2ABE4B8", Offset = "0x2ABE4B8", VA = "0x2ABE4B8", Slot = "85")]
		protected override void LoadFontAsset()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2ABEBF4", Offset = "0x2ABEBF4", VA = "0x2ABEBF4")]
		private void UpdateEnvMapMatrix()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2ABEE40", Offset = "0x2ABEE40", VA = "0x2ABEE40")]
		private void SetMask(MaskingTypes maskType)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2ABEFD4", Offset = "0x2ABEFD4", VA = "0x2ABEFD4")]
		private void SetMaskCoordinates(Vector4 coords)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2ABF0B0", Offset = "0x2ABF0B0", VA = "0x2ABF0B0")]
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2ABF1DC", Offset = "0x2ABF1DC", VA = "0x2ABF1DC")]
		private void EnableMasking()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2ABF404", Offset = "0x2ABF404", VA = "0x2ABF404")]
		private void DisableMasking()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2ABF36C", Offset = "0x2ABF36C", VA = "0x2ABF36C")]
		private void UpdateMask()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2ABF664", Offset = "0x2ABF664", VA = "0x2ABF664", Slot = "87")]
		protected override Material GetMaterial(Material mat)
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2ABF784", Offset = "0x2ABF784", VA = "0x2ABF784", Slot = "90")]
		protected override Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2ABF91C", Offset = "0x2ABF91C", VA = "0x2ABF91C", Slot = "86")]
		protected override void SetSharedMaterial(Material mat)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2ABF960", Offset = "0x2ABF960", VA = "0x2ABF960", Slot = "88")]
		protected override Material[] GetSharedMaterials()
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2ABFAE8", Offset = "0x2ABFAE8", VA = "0x2ABFAE8", Slot = "89")]
		protected override void SetSharedMaterials(Material[] materials)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2ABFEC0", Offset = "0x2ABFEC0", VA = "0x2ABFEC0", Slot = "94")]
		protected override void SetOutlineThickness(float thickness)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2AC000C", Offset = "0x2AC000C", VA = "0x2AC000C", Slot = "92")]
		protected override void SetFaceColor(Color32 color)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2AC0120", Offset = "0x2AC0120", VA = "0x2AC0120", Slot = "93")]
		protected override void SetOutlineColor(Color32 color)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2ABF594", Offset = "0x2ABF594", VA = "0x2ABF594")]
		private void CreateMaterialInstance()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2AC0234", Offset = "0x2AC0234", VA = "0x2AC0234", Slot = "95")]
		protected override void SetShaderDepth()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2AC035C", Offset = "0x2AC035C", VA = "0x2AC035C", Slot = "96")]
		protected override void SetCulling()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2AC0688", Offset = "0x2AC0688", VA = "0x2AC0688")]
		private void SetPerspectiveCorrection()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2AC0748", Offset = "0x2AC0748", VA = "0x2AC0748", Slot = "108")]
		internal override int SetArraySizes(UnicodeChar[] unicodeChars)
		{
			return default;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2AC249C", Offset = "0x2AC249C", VA = "0x2AC249C", Slot = "113")]
		public override void ComputeMarginSize()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2AC25D4", Offset = "0x2AC25D4", VA = "0x2AC25D4", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2AC25F0", Offset = "0x2AC25F0", VA = "0x2AC25F0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2AC262C", Offset = "0x2AC262C", VA = "0x2AC262C", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2AC27DC", Offset = "0x2AC27DC", VA = "0x2AC27DC", Slot = "126")]
		internal override void InternalUpdate()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2AC2A30", Offset = "0x2AC2A30", VA = "0x2AC2A30")]
		private void OnPreRenderObject()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2AC2E74", Offset = "0x2AC2E74", VA = "0x2AC2E74", Slot = "136")]
		protected virtual void GenerateTextMesh()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2ACB918", Offset = "0x2ACB918", VA = "0x2ACB918", Slot = "100")]
		protected override Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2ACB9C8", Offset = "0x2ACB9C8", VA = "0x2ACB9C8")]
		private void SetMeshFilters(bool state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2ACBBF4", Offset = "0x2ACBBF4", VA = "0x2ACBBF4", Slot = "121")]
		protected override void SetActiveSubMeshes(bool state)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2AC2D18", Offset = "0x2AC2D18", VA = "0x2AC2D18")]
		protected void SetActiveSubTextObjectRenderers(bool state)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2ACBD28", Offset = "0x2ACBD28", VA = "0x2ACBD28", Slot = "122")]
		protected override void DestroySubMeshObjects()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2ACBE40", Offset = "0x2ACBE40", VA = "0x2ACBE40")]
		internal void UpdateSubMeshSortingLayerID(int id)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2ACBF70", Offset = "0x2ACBF70", VA = "0x2ACBF70")]
		internal void UpdateSubMeshSortingOrder(int order)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2ACC0A0", Offset = "0x2ACC0A0", VA = "0x2ACC0A0", Slot = "110")]
		protected override Bounds GetCompoundBounds()
		{
			return default;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2AC2894", Offset = "0x2AC2894", VA = "0x2AC2894")]
		private void UpdateSDFScale(float scaleDelta)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2ACC8E4", Offset = "0x2ACC8E4", VA = "0x2ACC8E4")]
		public void SetMask(MaskingTypes type, Vector4 maskCoords)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2ACC9A4", Offset = "0x2ACC9A4", VA = "0x2ACC9A4")]
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2ACCA10", Offset = "0x2ACCA10", VA = "0x2ACCA10", Slot = "28")]
		public override void SetVerticesDirty()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2ACCB20", Offset = "0x2ACCB20", VA = "0x2ACCB20", Slot = "27")]
		public override void SetLayoutDirty()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2ACCC0C", Offset = "0x2ACCC0C", VA = "0x2ACCC0C", Slot = "29")]
		public override void SetMaterialDirty()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2ACCC1C", Offset = "0x2ACCC1C", VA = "0x2ACCC1C", Slot = "26")]
		public override void SetAllDirty()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2ACCC6C", Offset = "0x2ACCC6C", VA = "0x2ACCC6C", Slot = "37")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2ACCD68", Offset = "0x2ACCD68", VA = "0x2ACCD68", Slot = "40")]
		protected override void UpdateMaterial()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2ACCEC8", Offset = "0x2ACCEC8", VA = "0x2ACCEC8", Slot = "105")]
		public override void UpdateMeshPadding()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2ACCFE0", Offset = "0x2ACCFE0", VA = "0x2ACCFE0", Slot = "101")]
		public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2ACCFF0", Offset = "0x2ACCFF0", VA = "0x2ACCFF0", Slot = "112")]
		public override TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2ACD068", Offset = "0x2ACD068", VA = "0x2ACD068", Slot = "124")]
		public override void ClearMesh(bool updateMesh)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2ACD2C8", Offset = "0x2ACD2C8", VA = "0x2ACD2C8", Slot = "102")]
		public override void UpdateGeometry(Mesh mesh, int index)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2ACD2E4", Offset = "0x2ACD2E4", VA = "0x2ACD2E4", Slot = "103")]
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2ACD498", Offset = "0x2ACD498", VA = "0x2ACD498", Slot = "104")]
		public override void UpdateVertexData()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2ACD644", Offset = "0x2ACD644", VA = "0x2ACD644")]
		public void UpdateFontAsset()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2ACD654", Offset = "0x2ACD654", VA = "0x2ACD654", Slot = "127")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2ACD658", Offset = "0x2ACD658", VA = "0x2ACD658", Slot = "128")]
		public void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2ACD65C", Offset = "0x2ACD65C", VA = "0x2ACD65C")]
		public TextMeshPro()
		{
		}
	}
}
