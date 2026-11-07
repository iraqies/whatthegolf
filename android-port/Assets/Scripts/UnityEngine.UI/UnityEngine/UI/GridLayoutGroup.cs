using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000034")]
	public class GridLayoutGroup : LayoutGroup
	{
		[Token(Token = "0x2000035")]
		public enum Corner
		{
			[Token(Token = "0x4000130")]
			UpperLeft = 0,
			[Token(Token = "0x4000131")]
			UpperRight = 1,
			[Token(Token = "0x4000132")]
			LowerLeft = 2,
			[Token(Token = "0x4000133")]
			LowerRight = 3
		}

		[Token(Token = "0x2000036")]
		public enum Axis
		{
			[Token(Token = "0x4000135")]
			Horizontal = 0,
			[Token(Token = "0x4000136")]
			Vertical = 1
		}

		[Token(Token = "0x2000037")]
		public enum Constraint
		{
			[Token(Token = "0x4000138")]
			Flexible = 0,
			[Token(Token = "0x4000139")]
			FixedColumnCount = 1,
			[Token(Token = "0x400013A")]
			FixedRowCount = 2
		}

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Corner m_StartCorner;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected Axis m_StartAxis;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Vector2 m_CellSize;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Vector2 m_Spacing;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Constraint m_Constraint;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected int m_ConstraintCount;

		[Token(Token = "0x170000A4")]
		public Corner startCorner
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2C0B1B8", Offset = "0x2C0B1B8", VA = "0x2C0B1B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2C0B1C0", Offset = "0x2C0B1C0", VA = "0x2C0B1C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public Axis startAxis
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2C0B224", Offset = "0x2C0B224", VA = "0x2C0B224")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2C0B22C", Offset = "0x2C0B22C", VA = "0x2C0B22C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public Vector2 cellSize
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x2C0B290", Offset = "0x2C0B290", VA = "0x2C0B290")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x2C0B298", Offset = "0x2C0B298", VA = "0x2C0B298")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public Vector2 spacing
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x2C0B30C", Offset = "0x2C0B30C", VA = "0x2C0B30C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2C0B314", Offset = "0x2C0B314", VA = "0x2C0B314")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public Constraint constraint
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x2C0B388", Offset = "0x2C0B388", VA = "0x2C0B388")]
			get
			{
				return default;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2C0B390", Offset = "0x2C0B390", VA = "0x2C0B390")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public int constraintCount
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2C0B3F4", Offset = "0x2C0B3F4", VA = "0x2C0B3F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2C0B3FC", Offset = "0x2C0B3FC", VA = "0x2C0B3FC")]
			set
			{
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2C0B46C", Offset = "0x2C0B46C", VA = "0x2C0B46C")]
		protected GridLayoutGroup()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2C0B4B0", Offset = "0x2C0B4B0", VA = "0x2C0B4B0", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2C0B604", Offset = "0x2C0B604", VA = "0x2C0B604", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2C0B794", Offset = "0x2C0B794", VA = "0x2C0B794", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2C0BD24", Offset = "0x2C0BD24", VA = "0x2C0BD24", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2C0B79C", Offset = "0x2C0B79C", VA = "0x2C0B79C")]
		private void SetCellsAlongAxis(int axis)
		{
		}
	}
}
