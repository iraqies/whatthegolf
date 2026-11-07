using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x200002C")]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F6304", Offset = "0x1F6304")]
	[DisallowMultipleComponent]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		[Token(Token = "0x200002D")]
		public enum AspectMode
		{
			[Token(Token = "0x40000FF")]
			None = 0,
			[Token(Token = "0x4000100")]
			WidthControlsHeight = 1,
			[Token(Token = "0x4000101")]
			HeightControlsWidth = 2,
			[Token(Token = "0x4000102")]
			FitInParent = 3,
			[Token(Token = "0x4000103")]
			EnvelopeParent = 4
		}

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AspectMode m_AspectMode;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_AspectRatio;

		[NonSerialized]
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_Rect;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x28")]
		private bool m_DelayedSetDirty;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x29")]
		private bool m_DoesParentExist;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x2A")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x17000094")]
		public AspectMode aspectMode
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x2BF731C", Offset = "0x2BF731C", VA = "0x2BF731C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x2BF7324", Offset = "0x2BF7324", VA = "0x2BF7324")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public float aspectRatio
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x2BF73A0", Offset = "0x2BF73A0", VA = "0x2BF73A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x2BF73A8", Offset = "0x2BF73A8", VA = "0x2BF73A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x2BF742C", Offset = "0x2BF742C", VA = "0x2BF742C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2BF74D8", Offset = "0x2BF74D8", VA = "0x2BF74D8")]
		protected AspectRatioFitter()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2BF74E8", Offset = "0x2BF74E8", VA = "0x2BF74E8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2BF7588", Offset = "0x2BF7588", VA = "0x2BF7588", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2BF76E8", Offset = "0x2BF76E8", VA = "0x2BF76E8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2BF777C", Offset = "0x2BF777C", VA = "0x2BF777C", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2BF781C", Offset = "0x2BF781C", VA = "0x2BF781C", Slot = "19")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2BF7834", Offset = "0x2BF7834", VA = "0x2BF7834", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2BF7838", Offset = "0x2BF7838", VA = "0x2BF7838")]
		private void UpdateRect()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2BF7BDC", Offset = "0x2BF7BDC", VA = "0x2BF7BDC")]
		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			return default;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2BF7AE0", Offset = "0x2BF7AE0", VA = "0x2BF7AE0")]
		private Vector2 GetParentSize()
		{
			return default;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2BF7C9C", Offset = "0x2BF7C9C", VA = "0x2BF7C9C", Slot = "20")]
		public virtual void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2BF7CA0", Offset = "0x2BF7CA0", VA = "0x2BF7CA0", Slot = "21")]
		public virtual void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2BF739C", Offset = "0x2BF739C", VA = "0x2BF739C")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2BF75E8", Offset = "0x2BF75E8", VA = "0x2BF75E8")]
		public bool IsComponentValidOnObject()
		{
			return default;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2BF76C0", Offset = "0x2BF76C0", VA = "0x2BF76C0")]
		public bool IsAspectModeValid()
		{
			return default;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2BF7CA4", Offset = "0x2BF7CA4", VA = "0x2BF7CA4")]
		private bool DoesParentExists()
		{
			return default;
		}
	}
}
