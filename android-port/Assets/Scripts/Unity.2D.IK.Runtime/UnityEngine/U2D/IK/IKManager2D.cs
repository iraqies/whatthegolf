using System.Collections.Generic;

namespace UnityEngine.U2D.IK
{
	[ExecuteInEditMode]
	public class IKManager2D : MonoBehaviour
	{
		[SerializeField]
		private List<Solver2D> m_Solvers;

		[SerializeField]
		private float m_Weight;

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

		public List<Solver2D> solvers => null;

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		private void Reset()
		{
		}

		private void FindChildSolvers()
		{
		}

		public void AddSolver(Solver2D solver)
		{
		}

		public void RemoveSolver(Solver2D solver)
		{
		}

		public void UpdateManager()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnEditorDataValidate()
		{
		}

		private void AddSolverEditorData()
		{
		}

		private void RemoveSolverEditorData(Solver2D solver)
		{
		}
	}
}
