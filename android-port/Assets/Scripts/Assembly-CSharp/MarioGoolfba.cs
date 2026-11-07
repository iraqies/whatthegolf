using UnityEngine;

public class MarioGoolfba : MonoBehaviour
{
	[SerializeField]
	private float activateDistance;

	[SerializeField]
	private float rotateDistance;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float deathForce;

	[SerializeField]
	private Transform lookTransform;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private LayerMask RotateLayers;

	[SerializeField]
	private AudioClip deathClip;

	private Rigidbody rigidbody;

	private Transform playerTransform;

	private Vector3 startPos;

	private Quaternion startRot;

	private Collider[] playerColliders;

	private Collider ownCollider;

	private Vector3 currentDirection;

	private MarioLevelController controller;

	private bool dead;

	private void Start()
	{
	}

	private void OnLevelReset()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Kill()
	{
	}

	public bool IsDead()
	{
		return false;
	}
}
