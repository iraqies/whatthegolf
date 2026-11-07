using UnityEngine;

public class CinemachineComparisonTest : MonoBehaviour
{
	public Transform oldCamera;

	public Transform newCamera;

	public Transform ball;

	public bool isActive;

	public float maxError;

	public float avgError;

	public float avgErrorWhileMouseDown;

	public float currentError;

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
