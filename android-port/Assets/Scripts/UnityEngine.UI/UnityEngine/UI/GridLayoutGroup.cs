namespace UnityEngine.UI
{
	public class GridLayoutGroup : LayoutGroup
	{
		public enum Corner
		{
			UpperLeft = 0,
			UpperRight = 1,
			LowerLeft = 2,
			LowerRight = 3
		}

		public enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		public enum Constraint
		{
			Flexible = 0,
			FixedColumnCount = 1,
			FixedRowCount = 2
		}

		[SerializeField]
		protected Corner m_StartCorner;

		[SerializeField]
		protected Axis m_StartAxis;

		[SerializeField]
		protected Vector2 m_CellSize;

		[SerializeField]
		protected Vector2 m_Spacing;

		[SerializeField]
		protected Constraint m_Constraint;

		[SerializeField]
		protected int m_ConstraintCount;

		public Corner startCorner
		{
			get
			{
				return Corner.UpperLeft;
			}
			set
			{
			}
		}

		public Axis startAxis
		{
			get
			{
				return Axis.Horizontal;
			}
			set
			{
			}
		}

		public Vector2 cellSize
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector2 spacing
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Constraint constraint
		{
			get
			{
				return Constraint.Flexible;
			}
			set
			{
			}
		}

		public int constraintCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected GridLayoutGroup()
		{
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		private void SetCellsAlongAxis(int axis)
		{
		}
	}
}
