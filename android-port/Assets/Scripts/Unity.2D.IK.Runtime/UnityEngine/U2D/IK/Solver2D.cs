using System.Collections.Generic;

namespace UnityEngine.U2D.IK
{
	public abstract class Solver2D : MonoBehaviour
	{
		[SerializeField]
		private bool m_ConstrainRotation;

		[SerializeField]
		private bool m_SolveFromDefaultPose;

		[SerializeField]
		private float m_Weight;

		private Plane m_Plane;

		private List<Vector3> m_TargetPositions;

		public int chainCount => 0;

		public bool constrainRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool solveFromDefaultPose
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isValid => false;

		public bool allChainsHaveTargets => false;

		public float weight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected virtual void OnValidate()
		{
		}

		private bool Validate()
		{
			return false;
		}

		private bool HasTargets()
		{
			return false;
		}

		public void Initialize()
		{
		}

		private void Prepare()
		{
		}

		private void PrepareEffectorPositions()
		{
		}

		public void UpdateIK(float globalWeight)
		{
		}

		public void UpdateIK(List<Vector3> positions, float globalWeight)
		{
		}

		private void StoreLocalRotations()
		{
		}

		private void BlendFkToIk(float finalWeight)
		{
		}

		public abstract IKChain2D GetChain(int index);

		protected abstract int GetChainCount();

		protected abstract void DoUpdateIK(List<Vector3> effectorPositions);

		protected virtual bool DoValidate()
		{
			return false;
		}

		protected virtual void DoInitialize()
		{
		}

		protected virtual void DoPrepare()
		{
		}

		protected virtual Transform GetPlaneRootTransform()
		{
			return null;
		}

		protected Vector3 GetPointOnSolverPlane(Vector3 worldPosition)
		{
			return default;
		}

		protected Vector3 GetWorldPositionFromSolverPlanePoint(Vector2 planePoint)
		{
			return default;
		}
	}
}
