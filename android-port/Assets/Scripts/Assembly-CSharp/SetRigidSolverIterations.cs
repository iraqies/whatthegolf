using UnityEngine;

public class SetRigidSolverIterations : MonoBehaviour
{
	public bool setOnAwake = true;
	public int solverIterationCount = 12;

	private void Awake()
	{
		if (!setOnAwake) return;
		var rb = GetComponent<Rigidbody>();
		if (rb != null && solverIterationCount > 0)
			rb.solverIterations = solverIterationCount;
	}
}
