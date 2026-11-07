using System.Collections.Generic;

namespace UnityEngine.U2D.IK
{
	public class LimbSolver2D : Solver2D
	{
		[SerializeField]
		private IKChain2D m_Chain;

		[SerializeField]
		private bool m_Flip;

		private Vector3[] m_Positions;

		private float[] m_Lengths;

		private float[] m_Angles;

		public bool flip
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void DoInitialize()
		{
		}

		protected override int GetChainCount()
		{
			return 0;
		}

		public override IKChain2D GetChain(int index)
		{
			return null;
		}

		protected override void DoPrepare()
		{
		}

		protected override void DoUpdateIK(List<Vector3> effectorPositions)
		{
		}
	}
}
