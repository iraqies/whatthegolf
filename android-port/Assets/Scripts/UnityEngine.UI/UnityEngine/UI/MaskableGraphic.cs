using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000049")]
	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
	{
		[Serializable]
		[Token(Token = "0x200004A")]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2C467DC", Offset = "0x2C467DC", VA = "0x2C467DC")]
			public CullStateChangedEvent()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x99")]
		protected bool m_ShouldRecalculateStencil;

		[NonSerialized]
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0xA0")]
		protected Material m_MaskMaterial;

		[NonSerialized]
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0xA8")]
		private RectMask2D m_ParentMask;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool m_Maskable;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_IsMaskingGraphic;

		[NonSerialized]
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0xB2")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F7CE0", Offset = "0x1F7CE0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1F7CE0", Offset = "0x1F7CE0")]
		protected bool m_IncludeForMasking;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CullStateChangedEvent m_OnCullStateChanged;

		[NonSerialized]
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1F7D44", Offset = "0x1F7D44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1F7D44", Offset = "0x1F7D44")]
		protected bool m_ShouldRecalculate;

		[NonSerialized]
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0xC4")]
		protected int m_StencilValue;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0xC8")]
		private readonly Vector3[] m_Corners;

		[Token(Token = "0x170000D4")]
		public CullStateChangedEvent onCullStateChanged
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2C29790", Offset = "0x2C29790", VA = "0x2C29790")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x2C29798", Offset = "0x2C29798", VA = "0x2C29798")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public bool maskable
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2C297A0", Offset = "0x2C297A0", VA = "0x2C297A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2C297A8", Offset = "0x2C297A8", VA = "0x2C297A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public bool isMaskingGraphic
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2C297D4", Offset = "0x2C297D4", VA = "0x2C297D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2C27A80", Offset = "0x2C27A80", VA = "0x2C27A80")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x2C29948", Offset = "0x2C29948", VA = "0x2C29948")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2C297DC", Offset = "0x2C297DC", VA = "0x2C297DC", Slot = "55")]
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2C298EC", Offset = "0x2C298EC", VA = "0x2C298EC", Slot = "56")]
		public virtual void Cull(Rect clipRect, bool validRect)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2C29BC0", Offset = "0x2C29BC0", VA = "0x2C29BC0")]
		private void UpdateCull(bool cull)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2C29CA8", Offset = "0x2C29CA8", VA = "0x2C29CA8", Slot = "57")]
		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2C29D28", Offset = "0x2C29D28", VA = "0x2C29D28", Slot = "58")]
		public virtual void SetClipSoftness(Vector2 clipSoftness)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2C29D64", Offset = "0x2C29D64", VA = "0x2C29D64", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2C29F40", Offset = "0x2C29F40", VA = "0x2C29F40", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2C2A010", Offset = "0x2C2A010", VA = "0x2C2A010", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2C2A070", Offset = "0x2C2A070", VA = "0x2C2A070", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2C29DC8", Offset = "0x2C29DC8", VA = "0x2C29DC8")]
		private void UpdateClipParent()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2C2A3B8", Offset = "0x2C2A3B8", VA = "0x2C2A3B8", Slot = "59")]
		public virtual void RecalculateClipping()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2C2A3BC", Offset = "0x2C2A3BC", VA = "0x2C2A3BC", Slot = "60")]
		public virtual void RecalculateMasking()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2C2A454", Offset = "0x2C2A454", VA = "0x2C2A454")]
		protected MaskableGraphic()
		{
		}

		[SpecialName]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2C2A528", Offset = "0x2C2A528", VA = "0x2C2A528", Slot = "49")]
		private GameObject UnityEngine_002EUI_002EIClippable_002Eget_gameObject()
		{
			return null;
		}
	}
}
