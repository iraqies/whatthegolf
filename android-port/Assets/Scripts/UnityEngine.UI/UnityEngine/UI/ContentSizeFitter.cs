using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F6414", Offset = "0x1F6414")]
	[ExecuteAlways]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		[Token(Token = "0x2000033")]
		public enum FitMode
		{
			[Token(Token = "0x4000126")]
			Unconstrained = 0,
			[Token(Token = "0x4000127")]
			MinSize = 1,
			[Token(Token = "0x4000128")]
			PreferredSize = 2
		}

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected FitMode m_HorizontalFit;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected FitMode m_VerticalFit;

		[NonSerialized]
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_Rect;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x28")]
		private DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x170000A1")]
		public FitMode horizontalFit
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2BFD070", Offset = "0x2BFD070", VA = "0x2BFD070")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x2BFD078", Offset = "0x2BFD078", VA = "0x2BFD078")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public FitMode verticalFit
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x2BFD1EC", Offset = "0x2BFD1EC", VA = "0x2BFD1EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x2BFD1F4", Offset = "0x2BFD1F4", VA = "0x2BFD1F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x2BFD2D4", Offset = "0x2BFD2D4", VA = "0x2BFD2D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2BFD380", Offset = "0x2BFD380", VA = "0x2BFD380")]
		protected ContentSizeFitter()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2BFD388", Offset = "0x2BFD388", VA = "0x2BFD388", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2BFD424", Offset = "0x2BFD424", VA = "0x2BFD424", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2BFD4B8", Offset = "0x2BFD4B8", VA = "0x2BFD4B8", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2BFD54C", Offset = "0x2BFD54C", VA = "0x2BFD54C")]
		private void HandleSelfFittingAlongAxis(int axis)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2BFD618", Offset = "0x2BFD618", VA = "0x2BFD618", Slot = "19")]
		public virtual void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2BFD648", Offset = "0x2BFD648", VA = "0x2BFD648", Slot = "20")]
		public virtual void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2BFD158", Offset = "0x2BFD158", VA = "0x2BFD158")]
		protected void SetDirty()
		{
		}
	}
}
