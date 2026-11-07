using UnityEngine;

public class FlyingAppearingPlatform : MonoBehaviour
{
	private Vector3 origPosition;

	private Quaternion origRotation;

	private Vector3 awayPosition;

	private Quaternion awayRotation;

	private Vector3 targetPos;

	private Quaternion targetRot;

	private Rigidbody rigid;

	private Collider col;

	private bool isAway;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
