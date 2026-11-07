using UnityEngine;

public class SpotlightFollow : MonoBehaviour
{
	public Transform targetTransform;

	public bool followOnY;

	public Vector3 offset;

	public float followSpeed;

	private Vector3 posWithoutY;

	private void Update()
	{
	}
}
