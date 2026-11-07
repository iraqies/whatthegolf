using UnityEngine;

public class OrbitTargetController : MonoBehaviour
{
	public OrbitTargetAreaPair[] areas;

	public Transform cameraOrbitTarget;

	public float velocity;

	private OrbitTargetAreaPair current;

	private void Update()
	{
	}

	public void CheckAreaChange(Collider other)
	{
	}
}
