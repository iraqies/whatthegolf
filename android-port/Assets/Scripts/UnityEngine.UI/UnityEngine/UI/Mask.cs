using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F65CC", Offset = "0x1F65CC")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
	{
		[NonSerialized]
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform m_RectTransform;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_ShowMaskGraphic;

		[NonSerialized]
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x28")]
		private Graphic m_Graphic;

		[NonSerialized]
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x30")]
		private Material m_MaskMaterial;

		[NonSerialized]
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x38")]
		private Material m_UnmaskMaterial;

		[Token(Token = "0x170000D1")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x2C274E4", Offset = "0x2C274E4", VA = "0x2C274E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public bool showMaskGraphic
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x2C27540", Offset = "0x2C27540", VA = "0x2C27540")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x2C27548", Offset = "0x2C27548", VA = "0x2C27548")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public Graphic graphic
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x2C27688", Offset = "0x2C27688", VA = "0x2C27688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2C276E4", Offset = "0x2C276E4", VA = "0x2C276E4")]
		protected Mask()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2C276F4", Offset = "0x2C276F4", VA = "0x2C276F4", Slot = "19")]
		public virtual bool MaskEnabled()
		{
			return default;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2C277C4", Offset = "0x2C277C4", VA = "0x2C277C4", Slot = "20")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F8970", Offset = "0x1F8970")]
		public virtual void OnSiblingGraphicEnabledDisabled()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2C277C8", Offset = "0x2C277C8", VA = "0x2C277C8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2C27D44", Offset = "0x2C27D44", VA = "0x2C27D44", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2C280BC", Offset = "0x2C280BC", VA = "0x2C280BC", Slot = "21")]
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2C281B8", Offset = "0x2C281B8", VA = "0x2C281B8", Slot = "22")]
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}
	}
}
