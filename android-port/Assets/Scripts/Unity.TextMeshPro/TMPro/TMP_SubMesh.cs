using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x200005A")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1B921C", Offset = "0x1B921C")]
	public class TMP_SubMesh : MonoBehaviour
	{
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material m_material;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material m_sharedMaterial;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x38")]
		private Material m_fallbackMaterial;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x40")]
		private Material m_fallbackSourceMaterial;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_isDefaultMaterial;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_padding;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Renderer m_renderer;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x58")]
		private MeshFilter m_meshFilter;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x60")]
		private Mesh m_mesh;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshPro m_TextComponent;

		[NonSerialized]
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isRegisteredForEvents;

		[Token(Token = "0x170000BF")]
		public TMP_FontAsset fontAsset
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2A9F314", Offset = "0x2A9F314", VA = "0x2A9F314")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x2A9F31C", Offset = "0x2A9F31C", VA = "0x2A9F31C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public TMP_SpriteAsset spriteAsset
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x2A9F324", Offset = "0x2A9F324", VA = "0x2A9F324")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x2A9F32C", Offset = "0x2A9F32C", VA = "0x2A9F32C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public Material material
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x2A9F334", Offset = "0x2A9F334", VA = "0x2A9F334")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x2A9F4F4", Offset = "0x2A9F4F4", VA = "0x2A9F4F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public Material sharedMaterial
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x2A9F760", Offset = "0x2A9F760", VA = "0x2A9F760")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x2A9F768", Offset = "0x2A9F768", VA = "0x2A9F768")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public Material fallbackMaterial
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2A9F818", Offset = "0x2A9F818", VA = "0x2A9F818")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x2A9F820", Offset = "0x2A9F820", VA = "0x2A9F820")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public Material fallbackSourceMaterial
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2A9F994", Offset = "0x2A9F994", VA = "0x2A9F994")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x2A9F99C", Offset = "0x2A9F99C", VA = "0x2A9F99C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool isDefaultMaterial
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x2A9F9A4", Offset = "0x2A9F9A4", VA = "0x2A9F9A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x2A9F9AC", Offset = "0x2A9F9AC", VA = "0x2A9F9AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public float padding
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x2A9F9B4", Offset = "0x2A9F9B4", VA = "0x2A9F9B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x2A9F9BC", Offset = "0x2A9F9BC", VA = "0x2A9F9BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public Renderer renderer
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x2A9F9C4", Offset = "0x2A9F9C4", VA = "0x2A9F9C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x2A9FA70", Offset = "0x2A9FA70", VA = "0x2A9FA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public Mesh mesh
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x2A9FB94", Offset = "0x2A9FB94", VA = "0x2A9FB94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x2A9FC60", Offset = "0x2A9FC60", VA = "0x2A9FC60")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public TMP_Text textComponent
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x2A9FC68", Offset = "0x2A9FC68", VA = "0x2A9FC68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2A9FD14", Offset = "0x2A9FD14", VA = "0x2A9FD14")]
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2AA0050", Offset = "0x2AA0050", VA = "0x2AA0050")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2AA01BC", Offset = "0x2AA01BC", VA = "0x2AA01BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2AA0294", Offset = "0x2AA0294", VA = "0x2AA0294")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2AA0474", Offset = "0x2AA0474", VA = "0x2AA0474")]
		public void DestroySelf()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2A9F33C", Offset = "0x2A9F33C", VA = "0x2A9F33C")]
		private Material GetMaterial(Material mat)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2AA04FC", Offset = "0x2AA04FC", VA = "0x2AA04FC")]
		private Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2AA05C8", Offset = "0x2AA05C8", VA = "0x2AA05C8")]
		private Material GetSharedMaterial()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2A9F76C", Offset = "0x2A9F76C", VA = "0x2A9F76C")]
		private void SetSharedMaterial(Material mat)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2A9F5E8", Offset = "0x2A9F5E8", VA = "0x2A9F5E8")]
		public float GetPaddingForMaterial()
		{
			return default;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2AA0680", Offset = "0x2AA0680", VA = "0x2AA0680")]
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2A9F684", Offset = "0x2A9F684", VA = "0x2A9F684")]
		public void SetVerticesDirty()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2A9F75C", Offset = "0x2A9F75C", VA = "0x2A9F75C")]
		public void SetMaterialDirty()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2AA0728", Offset = "0x2AA0728", VA = "0x2AA0728")]
		protected void UpdateMaterial()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2AA08D8", Offset = "0x2AA08D8", VA = "0x2AA08D8")]
		public TMP_SubMesh()
		{
		}
	}
}
