using UnityEngine;

public class CameraTest : MonoBehaviour
{
	[SerializeField]
	private Transform testPoint;

	private Plane[] planes;

	private Camera camera;

	private bool[] inside;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
