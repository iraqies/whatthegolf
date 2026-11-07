using UnityEngine;

public class SmartCarAgent : MonoBehaviour
{
	public float Speed;

	public float Gravity;

	public float RotateSpeed;

	public LayerMask IgnoreLayers;

	private Rigidbody rigid;

	private TrafficController.TrafficPoint _currentPath;

	private bool isLocked;

	private Vector3 smoothedNormal;

	private float nonGroundTime;

	private bool hasBeenFlat;

	private Vector3 smoothedFlatForward;

	private void Awake()
	{
	}

	public void Iniitialize(Vector3 position, Vector3 forward)
	{
	}

	private Vector3 GetNormal()
	{
		return default;
	}

	private void Unlock()
	{
	}

	private bool IsGrounded()
	{
		return false;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void FixedUpdate()
	{
	}
}
