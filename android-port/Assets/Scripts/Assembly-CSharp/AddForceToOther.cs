using UnityEngine;

public class AddForceToOther : MonoBehaviour
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

	public void Execute()
	{
	}

	public void OnDrawGizmos()
	{
	}

	private void SetForceDirAndRot()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
