using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000040")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F6514", Offset = "0x1F6514")]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
	{
		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F659C", Offset = "0x1F659C")]
		private sealed class _003CDelayedSetDirty_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000153")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000154")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000155")]
			[FieldOffset(Offset = "0x20")]
			public RectTransform rectTransform;

			[Token(Token = "0x170000CE")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60002CA")]
				[Address(RVA = "0x2C45D1C", Offset = "0x2C45D1C", VA = "0x2C45D1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000CF")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x2C45D64", Offset = "0x2C45D64", VA = "0x2C45D64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x2C45C48", Offset = "0x2C45C48", VA = "0x2C45C48")]
			[DebuggerHidden]
			public _003CDelayedSetDirty_003Ed__56(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x2C45C74", Offset = "0x2C45C74", VA = "0x2C45C74", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2C45C78", Offset = "0x2C45C78", VA = "0x2C45C78", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x2C45D1C", Offset = "0x2C45D1C", VA = "0x2C45D1C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2C45D24", Offset = "0x2C45D24", VA = "0x2C45D24", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x2C45D64", Offset = "0x2C45D64", VA = "0x2C45D64", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected RectOffset m_Padding;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextAnchor m_ChildAlignment;

		[NonSerialized]
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_Rect;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x30")]
		protected DrivenRectTransformTracker m_Tracker;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 m_TotalMinSize;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 m_TotalPreferredSize;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_TotalFlexibleSize;

		[NonSerialized]
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x50")]
		private List<RectTransform> m_RectChildren;

		[Token(Token = "0x170000C2")]
		public RectOffset padding
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x2C2418C", Offset = "0x2C2418C", VA = "0x2C2418C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x2C24194", Offset = "0x2C24194", VA = "0x2C24194")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public TextAnchor childAlignment
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x2C241F8", Offset = "0x2C241F8", VA = "0x2C241F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x2C24200", Offset = "0x2C24200", VA = "0x2C24200")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x2C24264", Offset = "0x2C24264", VA = "0x2C24264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		protected List<RectTransform> rectChildren
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x2C24310", Offset = "0x2C24310", VA = "0x2C24310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public virtual float minWidth
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x2C246AC", Offset = "0x2C246AC", VA = "0x2C246AC", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C7")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x2C246C8", Offset = "0x2C246C8", VA = "0x2C246C8", Slot = "31")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C8")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x2C246E4", Offset = "0x2C246E4", VA = "0x2C246E4", Slot = "32")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C9")]
		public virtual float minHeight
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2C24700", Offset = "0x2C24700", VA = "0x2C24700", Slot = "33")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CA")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2C24710", Offset = "0x2C24710", VA = "0x2C24710", Slot = "34")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CB")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2C24720", Offset = "0x2C24720", VA = "0x2C24720", Slot = "35")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CC")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x2C24730", Offset = "0x2C24730", VA = "0x2C24730", Slot = "36")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CD")]
		private bool isRootLayoutGroup
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2C250D8", Offset = "0x2C250D8", VA = "0x2C250D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2C24318", Offset = "0x2C24318", VA = "0x2C24318", Slot = "28")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60002A9")]
		public abstract void CalculateLayoutInputVertical();

		[Token(Token = "0x60002B1")]
		public abstract void SetLayoutHorizontal();

		[Token(Token = "0x60002B2")]
		public abstract void SetLayoutVertical();

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2C24738", Offset = "0x2C24738", VA = "0x2C24738")]
		protected LayoutGroup()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2C24834", Offset = "0x2C24834", VA = "0x2C24834", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2C24998", Offset = "0x2C24998", VA = "0x2C24998", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2C24A28", Offset = "0x2C24A28", VA = "0x2C24A28", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2C246BC", Offset = "0x2C246BC", VA = "0x2C246BC")]
		protected float GetTotalMinSize(int axis)
		{
			return default;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2C246D8", Offset = "0x2C246D8", VA = "0x2C246D8")]
		protected float GetTotalPreferredSize(int axis)
		{
			return default;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2C246F4", Offset = "0x2C246F4", VA = "0x2C246F4")]
		protected float GetTotalFlexibleSize(int axis)
		{
			return default;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2C24A2C", Offset = "0x2C24A2C", VA = "0x2C24A2C")]
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			return default;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2C24B60", Offset = "0x2C24B60", VA = "0x2C24B60")]
		protected float GetAlignmentOnAxis(int axis)
		{
			return default;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2C24B98", Offset = "0x2C24B98", VA = "0x2C24B98")]
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2C24BF8", Offset = "0x2C24BF8", VA = "0x2C24BF8")]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2C24CB8", Offset = "0x2C24CB8", VA = "0x2C24CB8")]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2C24E58", Offset = "0x2C24E58", VA = "0x2C24E58")]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2C24F20", Offset = "0x2C24F20", VA = "0x2C24F20")]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2C2523C", Offset = "0x2C2523C", VA = "0x2C2523C", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2C2527C", Offset = "0x2C2527C", VA = "0x2C2527C", Slot = "39")]
		protected virtual void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x60002C4")]
		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2C2485C", Offset = "0x2C2485C", VA = "0x2C2485C")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2C25280", Offset = "0x2C25280", VA = "0x2C25280")]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			return null;
		}
	}
}
