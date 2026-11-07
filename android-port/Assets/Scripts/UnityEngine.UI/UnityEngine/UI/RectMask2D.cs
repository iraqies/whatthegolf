using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000051")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F66CC", Offset = "0x1F66CC")]
	[DisallowMultipleComponent]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
	{
		[NonSerialized]
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x18")]
		private readonly RectangularVertexClipper m_VertexClipper;

		[NonSerialized]
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_RectTransform;

		[NonSerialized]
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<MaskableGraphic> m_MaskableTargets;

		[NonSerialized]
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<IClippable> m_ClipTargets;

		[NonSerialized]
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x38")]
		private bool m_ShouldRecalculateClipRects;

		[NonSerialized]
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x40")]
		private List<RectMask2D> m_Clippers;

		[NonSerialized]
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x48")]
		private Rect m_LastClipRectCanvasSpace;

		[NonSerialized]
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_ForceClip;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Vector4 m_Padding;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector2Int m_Softness;

		[NonSerialized]
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x78")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x80")]
		private Vector3[] m_Corners;

		[Token(Token = "0x170000E2")]
		public Vector4 padding
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x2C2F148", Offset = "0x2C2F148", VA = "0x2C2F148")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x2C2F154", Offset = "0x2C2F154", VA = "0x2C2F154")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public Vector2Int softness
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x2C2F160", Offset = "0x2C2F160", VA = "0x2C2F160")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x2C2F168", Offset = "0x2C2F168", VA = "0x2C2F168")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		internal Canvas Canvas
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x2C2F1B0", Offset = "0x2C2F1B0", VA = "0x2C2F1B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public Rect canvasRect
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x2C2F334", Offset = "0x2C2F334", VA = "0x2C2F334")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E6")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x2C2F3C0", Offset = "0x2C2F3C0", VA = "0x2C2F3C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x2C2F7E4", Offset = "0x2C2F7E4", VA = "0x2C2F7E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2C2F41C", Offset = "0x2C2F41C", VA = "0x2C2F41C")]
		protected RectMask2D()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2C2F584", Offset = "0x2C2F584", VA = "0x2C2F584", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2C2F5C0", Offset = "0x2C2F5C0", VA = "0x2C2F5C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2C2F67C", Offset = "0x2C2F67C", VA = "0x2C2F67C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2C2F6A8", Offset = "0x2C2F6A8", VA = "0x2C2F6A8", Slot = "19")]
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2C2F960", Offset = "0x2C2F960", VA = "0x2C2F960", Slot = "20")]
		public virtual void PerformClipping()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2C30134", Offset = "0x2C30134", VA = "0x2C30134", Slot = "21")]
		public virtual void UpdateClipSoftness()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2C2A28C", Offset = "0x2C2A28C", VA = "0x2C2A28C")]
		public void AddClippable(IClippable clippable)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2C2A0D0", Offset = "0x2C2A0D0", VA = "0x2C2A0D0")]
		public void RemoveClippable(IClippable clippable)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2C30478", Offset = "0x2C30478", VA = "0x2C30478", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x2C304A8", Offset = "0x2C304A8", VA = "0x2C304A8", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}
	}
}
