using UnityEngine;

public class AddForce : MonoBehaviour
{
	public bool onAwake;

	public bool useTransformAsTarget;

	public Transform target;

	public Vector3 forceDir;

	public float forceMagnitude;

	public Vector3 rotationDir;

	public float rotationForce;

	public float delay;

	public ForceMode mode;

	private Rigidbody rigid;

	private void Awake()
	{
	}

	public void Execute()
	{
	}

	public void OnDrawGizmos()
	{
	}

	private void SetForceDirAndRot()
	{
	}
}
