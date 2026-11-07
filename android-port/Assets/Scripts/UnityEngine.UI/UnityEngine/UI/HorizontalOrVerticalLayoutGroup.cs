using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000039")]
	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float m_Spacing;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected bool m_ChildForceExpandWidth;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x5D")]
		[SerializeField]
		protected bool m_ChildForceExpandHeight;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x5E")]
		[SerializeField]
		protected bool m_ChildControlWidth;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x5F")]
		[SerializeField]
		protected bool m_ChildControlHeight;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected bool m_ChildScaleWidth;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		protected bool m_ChildScaleHeight;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x62")]
		[SerializeField]
		protected bool m_ReverseArrangement;

		[Token(Token = "0x170000AA")]
		public float spacing
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2C0C5E0", Offset = "0x2C0C5E0", VA = "0x2C0C5E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2C0C5E8", Offset = "0x2C0C5E8", VA = "0x2C0C5E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool childForceExpandWidth
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2C0C654", Offset = "0x2C0C654", VA = "0x2C0C654")]
			get
			{
				return default;
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2C0C65C", Offset = "0x2C0C65C", VA = "0x2C0C65C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool childForceExpandHeight
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2C0C6C0", Offset = "0x2C0C6C0", VA = "0x2C0C6C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2C0C6C8", Offset = "0x2C0C6C8", VA = "0x2C0C6C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool childControlWidth
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2C0C72C", Offset = "0x2C0C72C", VA = "0x2C0C72C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x2C0C734", Offset = "0x2C0C734", VA = "0x2C0C734")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool childControlHeight
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x2C0C798", Offset = "0x2C0C798", VA = "0x2C0C798")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x2C0C7A0", Offset = "0x2C0C7A0", VA = "0x2C0C7A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool childScaleWidth
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x2C0C804", Offset = "0x2C0C804", VA = "0x2C0C804")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2C0C80C", Offset = "0x2C0C80C", VA = "0x2C0C80C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool childScaleHeight
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x2C0C870", Offset = "0x2C0C870", VA = "0x2C0C870")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x2C0C878", Offset = "0x2C0C878", VA = "0x2C0C878")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool reverseArrangement
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x2C0C8DC", Offset = "0x2C0C8DC", VA = "0x2C0C8DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x2C0C8E4", Offset = "0x2C0C8E4", VA = "0x2C0C8E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2C0BD7C", Offset = "0x2C0BD7C", VA = "0x2C0BD7C")]
		protected void CalcAlongAxis(int axis, bool isVertical)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2C0C014", Offset = "0x2C0C014", VA = "0x2C0C014")]
		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2C0C948", Offset = "0x2C0C948", VA = "0x2C0C948")]
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2C0BD3C", Offset = "0x2C0BD3C", VA = "0x2C0BD3C")]
		protected HorizontalOrVerticalLayoutGroup()
		{
		}
	}
}
