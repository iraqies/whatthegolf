using UnityEngine;

public class ChangeSolverIteration : MonoBehaviour
{
	public int newIterationCount;

	private int defaultCount;

	private void Awake()
	{
		defaultCount = Physics.defaultSolverIterations;
		Physics.defaultSolverIterations = newIterationCount;
	}

	private void OnDestroy()
	{
		Physics.defaultSolverIterations = defaultCount;
	}

	private void BackToDefault()
	{
		Physics.defaultSolverIterations = defaultCount;
	}
}
