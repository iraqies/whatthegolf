using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x200002E")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F638C", Offset = "0x1F638C")]
	[ExecuteAlways]
	public class CanvasScaler : UIBehaviour
	{
		[Token(Token = "0x200002F")]
		public enum ScaleMode
		{
			[Token(Token = "0x4000114")]
			ConstantPixelSize = 0,
			[Token(Token = "0x4000115")]
			ScaleWithScreenSize = 1,
			[Token(Token = "0x4000116")]
			ConstantPhysicalSize = 2
		}

		[Token(Token = "0x2000030")]
		public enum ScreenMatchMode
		{
			[Token(Token = "0x4000118")]
			MatchWidthOrHeight = 0,
			[Token(Token = "0x4000119")]
			Expand = 1,
			[Token(Token = "0x400011A")]
			Shrink = 2
		}

		[Token(Token = "0x2000031")]
		public enum Unit
		{
			[Token(Token = "0x400011C")]
			Centimeters = 0,
			[Token(Token = "0x400011D")]
			Millimeters = 1,
			[Token(Token = "0x400011E")]
			Inches = 2,
			[Token(Token = "0x400011F")]
			Points = 3,
			[Token(Token = "0x4000120")]
			Picas = 4
		}

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScaleMode m_UiScaleMode;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected float m_ReferencePixelsPerUnit;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float m_ScaleFactor;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected Vector2 m_ReferenceResolution;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected ScreenMatchMode m_ScreenMatchMode;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F7A90", Offset = "0x1F7A90")]
		[SerializeField]
		protected float m_MatchWidthOrHeight;

		[Token(Token = "0x400010A")]
		private const float kLogBase = 2f;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected Unit m_PhysicalUnit;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected float m_FallbackScreenDPI;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected float m_DefaultSpriteDPI;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected float m_DynamicPixelsPerUnit;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x48")]
		private Canvas m_Canvas;

		[NonSerialized]
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x50")]
		private float m_PrevScaleFactor;

		[NonSerialized]
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x54")]
		private float m_PrevReferencePixelsPerUnit;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected bool m_PresetInfoIsWorld;

		[Token(Token = "0x17000097")]
		public ScaleMode uiScaleMode
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2BF9EDC", Offset = "0x2BF9EDC", VA = "0x2BF9EDC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x2BF9EE4", Offset = "0x2BF9EE4", VA = "0x2BF9EE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public float referencePixelsPerUnit
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2BF9EEC", Offset = "0x2BF9EEC", VA = "0x2BF9EEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2BF9EF4", Offset = "0x2BF9EF4", VA = "0x2BF9EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public float scaleFactor
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2BF9EFC", Offset = "0x2BF9EFC", VA = "0x2BF9EFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2BF9F04", Offset = "0x2BF9F04", VA = "0x2BF9F04")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Vector2 referenceResolution
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2BF9F3C", Offset = "0x2BF9F3C", VA = "0x2BF9F3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2BF9F44", Offset = "0x2BF9F44", VA = "0x2BF9F44")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public ScreenMatchMode screenMatchMode
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2BF9FC8", Offset = "0x2BF9FC8", VA = "0x2BF9FC8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2BF9FD0", Offset = "0x2BF9FD0", VA = "0x2BF9FD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public float matchWidthOrHeight
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2BF9FD8", Offset = "0x2BF9FD8", VA = "0x2BF9FD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2BF9FE0", Offset = "0x2BF9FE0", VA = "0x2BF9FE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Unit physicalUnit
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2BF9FE8", Offset = "0x2BF9FE8", VA = "0x2BF9FE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2BF9FF0", Offset = "0x2BF9FF0", VA = "0x2BF9FF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public float fallbackScreenDPI
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2BF9FF8", Offset = "0x2BF9FF8", VA = "0x2BF9FF8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x2BFA000", Offset = "0x2BFA000", VA = "0x2BFA000")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public float defaultSpriteDPI
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x2BFA008", Offset = "0x2BFA008", VA = "0x2BFA008")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x2BFA010", Offset = "0x2BFA010", VA = "0x2BFA010")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public float dynamicPixelsPerUnit
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2BFA040", Offset = "0x2BFA040", VA = "0x2BFA040")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2BFA048", Offset = "0x2BFA048", VA = "0x2BFA048")]
			set
			{
			}
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2BFA050", Offset = "0x2BFA050", VA = "0x2BFA050")]
		protected CanvasScaler()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2BFA098", Offset = "0x2BFA098", VA = "0x2BFA098", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2BFA168", Offset = "0x2BFA168", VA = "0x2BFA168")]
		private void Canvas_preWillRenderCanvases()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2BFA178", Offset = "0x2BFA178", VA = "0x2BFA178", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2BFA300", Offset = "0x2BFA300", VA = "0x2BFA300", Slot = "17")]
		protected virtual void Handle()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2BFA3FC", Offset = "0x2BFA3FC", VA = "0x2BFA3FC", Slot = "18")]
		protected virtual void HandleWorldCanvas()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2BFA474", Offset = "0x2BFA474", VA = "0x2BFA474", Slot = "19")]
		protected virtual void HandleConstantPixelSize()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2BFA4EC", Offset = "0x2BFA4EC", VA = "0x2BFA4EC", Slot = "20")]
		protected virtual void HandleScaleWithScreenSize()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2BFA728", Offset = "0x2BFA728", VA = "0x2BFA728", Slot = "21")]
		protected virtual void HandleConstantPhysicalSize()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2BFA268", Offset = "0x2BFA268", VA = "0x2BFA268")]
		protected void SetScaleFactor(float scaleFactor)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2BFA2B4", Offset = "0x2BFA2B4", VA = "0x2BFA2B4")]
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
		}
	}
}
