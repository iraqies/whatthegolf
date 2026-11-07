using System.Collections;
using UnityEngine;

public class RigidbodyThrower : MonoBehaviour
{
	[SerializeField]
	private Rigidbody rigidbody;

	[SerializeField]
	private float throwVelocity;

	[SerializeField]
	private Vector3 throwAngularVelocity;

	[SerializeField]
	private float debugGravity;

	[SerializeField]
	private float intervalOffset;

	[SerializeField]
	private float interval;

	private float y;

	private float nextThrowTime;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
