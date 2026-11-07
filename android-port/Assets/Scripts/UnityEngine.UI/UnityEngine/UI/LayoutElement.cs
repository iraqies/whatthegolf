using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x200003F")]
	[ExecuteAlways]
	[Attribute(Name = "RequireComponent", RVA = "0x1F649C", Offset = "0x1F649C")]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
	{
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IgnoreLayout;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_MinWidth;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MinHeight;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_PreferredWidth;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_PreferredHeight;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_FlexibleWidth;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FlexibleHeight;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_LayoutPriority;

		[Token(Token = "0x170000BA")]
		public virtual bool ignoreLayout
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2C237A0", Offset = "0x2C237A0", VA = "0x2C237A0", Slot = "27")]
			get
			{
				return default;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2C237A8", Offset = "0x2C237A8", VA = "0x2C237A8", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public virtual float minWidth
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x2C238E4", Offset = "0x2C238E4", VA = "0x2C238E4", Slot = "31")]
			get
			{
				return default;
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x2C238EC", Offset = "0x2C238EC", VA = "0x2C238EC", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public virtual float minHeight
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x2C23970", Offset = "0x2C23970", VA = "0x2C23970", Slot = "33")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x2C23978", Offset = "0x2C23978", VA = "0x2C23978", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x2C239FC", Offset = "0x2C239FC", VA = "0x2C239FC", Slot = "35")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x2C23A04", Offset = "0x2C23A04", VA = "0x2C23A04", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x2C23A88", Offset = "0x2C23A88", VA = "0x2C23A88", Slot = "37")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x2C23A90", Offset = "0x2C23A90", VA = "0x2C23A90", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x2C23B14", Offset = "0x2C23B14", VA = "0x2C23B14", Slot = "39")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x2C23B1C", Offset = "0x2C23B1C", VA = "0x2C23B1C", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x2C23BA0", Offset = "0x2C23BA0", VA = "0x2C23BA0", Slot = "41")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2C23BA8", Offset = "0x2C23BA8", VA = "0x2C23BA8", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x2C23C2C", Offset = "0x2C23C2C", VA = "0x2C23C2C", Slot = "43")]
			get
			{
				return default;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2C23C34", Offset = "0x2C23C34", VA = "0x2C23C34", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2C238DC", Offset = "0x2C238DC", VA = "0x2C238DC", Slot = "29")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2C238E0", Offset = "0x2C238E0", VA = "0x2C238E0", Slot = "30")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2C23CAC", Offset = "0x2C23CAC", VA = "0x2C23CAC")]
		protected LayoutElement()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2C23CD0", Offset = "0x2C23CD0", VA = "0x2C23CD0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2C23CF8", Offset = "0x2C23CF8", VA = "0x2C23CF8", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2C23CFC", Offset = "0x2C23CFC", VA = "0x2C23CFC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2C23D24", Offset = "0x2C23D24", VA = "0x2C23D24", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2C23D28", Offset = "0x2C23D28", VA = "0x2C23D28", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2C23820", Offset = "0x2C23820", VA = "0x2C23820")]
		protected void SetDirty()
		{
		}
	}
}
