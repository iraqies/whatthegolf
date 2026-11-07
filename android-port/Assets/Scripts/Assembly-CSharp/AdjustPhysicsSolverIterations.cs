using UnityEngine;

public class AdjustPhysicsSolverIterations : MonoBehaviour
{
	public int DefaultSolverVelocityIterations;

	public int DefaultSolverIterations;

	private int originalSolverVelocityIterations;

	private int originalSolverIterations;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
