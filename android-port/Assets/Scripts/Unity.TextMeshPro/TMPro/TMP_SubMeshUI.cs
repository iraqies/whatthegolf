using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B9294", Offset = "0x1B9294")]
	[ExecuteAlways]
	public class TMP_SubMeshUI : MaskableGraphic
	{
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Material m_material;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Material m_sharedMaterial;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0xF0")]
		private Material m_fallbackMaterial;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xF8")]
		private Material m_fallbackSourceMaterial;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool m_isDefaultMaterial;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private float m_padding;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x108")]
		private Mesh m_mesh;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private TextMeshProUGUI m_TextComponent;

		[NonSerialized]
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isRegisteredForEvents;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x119")]
		private bool m_materialDirty;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private int m_materialReferenceIndex;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x120")]
		private Transform m_RootCanvasTransform;

		[Token(Token = "0x170000CB")]
		public TMP_FontAsset fontAsset
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2AA08E0", Offset = "0x2AA08E0", VA = "0x2AA08E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x2AA08E8", Offset = "0x2AA08E8", VA = "0x2AA08E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public TMP_SpriteAsset spriteAsset
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x2AA08F0", Offset = "0x2AA08F0", VA = "0x2AA08F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x2AA08F8", Offset = "0x2AA08F8", VA = "0x2AA08F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x2AA0900", Offset = "0x2AA0900", VA = "0x2AA0900", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public override Material material
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x2AA09EC", Offset = "0x2AA09EC", VA = "0x2AA09EC", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x2AA0B68", Offset = "0x2AA0B68", VA = "0x2AA0B68", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public Material sharedMaterial
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x2AA0D70", Offset = "0x2AA0D70", VA = "0x2AA0D70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x2AA0D78", Offset = "0x2AA0D78", VA = "0x2AA0D78")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public Material fallbackMaterial
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x2AA0E38", Offset = "0x2AA0E38", VA = "0x2AA0E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x2AA0E40", Offset = "0x2AA0E40", VA = "0x2AA0E40")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public Material fallbackSourceMaterial
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x2AA0FB4", Offset = "0x2AA0FB4", VA = "0x2AA0FB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x2AA0FBC", Offset = "0x2AA0FBC", VA = "0x2AA0FBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public override Material materialForRendering
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x2AA0FC4", Offset = "0x2AA0FC4", VA = "0x2AA0FC4", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public bool isDefaultMaterial
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x2AA1048", Offset = "0x2AA1048", VA = "0x2AA1048")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x2AA1050", Offset = "0x2AA1050", VA = "0x2AA1050")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public float padding
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x2AA1058", Offset = "0x2AA1058", VA = "0x2AA1058")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x2AA1060", Offset = "0x2AA1060", VA = "0x2AA1060")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public Mesh mesh
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x2AA1068", Offset = "0x2AA1068", VA = "0x2AA1068")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x2AA1134", Offset = "0x2AA1134", VA = "0x2AA1134")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public TMP_Text textComponent
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x2AA113C", Offset = "0x2AA113C", VA = "0x2AA113C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2AA11E8", Offset = "0x2AA11E8", VA = "0x2AA11E8")]
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2AA1668", Offset = "0x2AA1668", VA = "0x2AA1668", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2AA16E4", Offset = "0x2AA16E4", VA = "0x2AA16E4", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2AA17B8", Offset = "0x2AA17B8", VA = "0x2AA17B8", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2AA19EC", Offset = "0x2AA19EC", VA = "0x2AA19EC", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2AA1A50", Offset = "0x2AA1A50", VA = "0x2AA1A50", Slot = "55")]
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2AA0CD4", Offset = "0x2AA0CD4", VA = "0x2AA0CD4")]
		public float GetPaddingForMaterial()
		{
			return default;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2AA1B68", Offset = "0x2AA1B68", VA = "0x2AA1B68")]
		public float GetPaddingForMaterial(Material mat)
		{
			return default;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2AA1BFC", Offset = "0x2AA1BFC", VA = "0x2AA1BFC")]
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2AA1CA4", Offset = "0x2AA1CA4", VA = "0x2AA1CA4", Slot = "26")]
		public override void SetAllDirty()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2AA1CA8", Offset = "0x2AA1CA8", VA = "0x2AA1CA8", Slot = "28")]
		public override void SetVerticesDirty()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2AA1D84", Offset = "0x2AA1D84", VA = "0x2AA1D84", Slot = "27")]
		public override void SetLayoutDirty()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2AA1D88", Offset = "0x2AA1D88", VA = "0x2AA1D88", Slot = "29")]
		public override void SetMaterialDirty()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2AA1DD4", Offset = "0x2AA1DD4", VA = "0x2AA1DD4")]
		public void SetPivotDirty()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2AA1E44", Offset = "0x2AA1E44", VA = "0x2AA1E44")]
		private Transform GetRootCanvasTransform()
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2AA1EFC", Offset = "0x2AA1EFC", VA = "0x2AA1EFC", Slot = "56")]
		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2AA1F00", Offset = "0x2AA1F00", VA = "0x2AA1F00", Slot = "41")]
		protected override void UpdateGeometry()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2AA1F04", Offset = "0x2AA1F04", VA = "0x2AA1F04", Slot = "37")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2AA1F48", Offset = "0x2AA1F48", VA = "0x2AA1F48")]
		public void RefreshMaterial()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2AA1F58", Offset = "0x2AA1F58", VA = "0x2AA1F58", Slot = "40")]
		protected override void UpdateMaterial()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2AA2110", Offset = "0x2AA2110", VA = "0x2AA2110", Slot = "59")]
		public override void RecalculateClipping()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2AA2118", Offset = "0x2AA2118", VA = "0x2AA2118")]
		private Material GetMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2AA09F4", Offset = "0x2AA09F4", VA = "0x2AA09F4")]
		private Material GetMaterial(Material mat)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x2AA2120", Offset = "0x2AA2120", VA = "0x2AA2120")]
		private Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2AA21EC", Offset = "0x2AA21EC", VA = "0x2AA21EC")]
		private Material GetSharedMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2AA0D7C", Offset = "0x2AA0D7C", VA = "0x2AA0D7C")]
		private void SetSharedMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2AA2210", Offset = "0x2AA2210", VA = "0x2AA2210")]
		public TMP_SubMeshUI()
		{
		}
	}
}
