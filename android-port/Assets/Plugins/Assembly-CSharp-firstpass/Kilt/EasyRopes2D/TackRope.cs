using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class TackRope : Rope2D
	{
		[SerializeField]
		private int m_tackAIndex;

		[SerializeField]
		private int m_tackBIndex;

		private bool _tackUpdated;

		public int TackAIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TackBIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override GameObject ObjectA
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override GameObject ObjectB
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void CorrectValues()
		{
		}

		public override void CreateRope(bool p_clearNodes = true)
		{
		}

		protected virtual void UpdateTackObjectsBeforeRopeCreated()
		{
		}
	}
}
