using System;
using UnityEngine;

public class MarioGoolfba : MonoBehaviour
{
	[SerializeField]
	private float activateDistance = 20f;

	[SerializeField]
	private float rotateDistance = 1f;

	[SerializeField]
	private float speed = 1f;

	[SerializeField]
	private float deathForce = 15f;

	[SerializeField]
	private Transform lookTransform;

	[SerializeField]
	private float rotateSpeed = 1000f;

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

	public bool isDead => dead;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
		if (gameObject == null)
		{
			return;
		}
		playerTransform = gameObject.transform;
		playerColliders = playerTransform.GetComponentsInChildren<Collider>();
		ownCollider = GetComponent<Collider>();
		controller = UnityEngine.Object.FindObjectOfType<MarioLevelController>();
		if (controller != null)
		{
			controller.OnLevelReset = (Action)Delegate.Combine(controller.OnLevelReset, new Action(OnLevelReset));
		}
		startPos = base.transform.position;
		startRot = base.transform.rotation;
		currentDirection = -base.transform.right;
	}

	private void OnLevelReset()
	{
		base.transform.position = startPos;
		base.transform.rotation = startRot;
		if (rigidbody != null)
		{
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
			rigidbody.constraints = (RigidbodyConstraints)88;
		}
		if (playerColliders != null && ownCollider != null)
		{
			for (int i = 0; i < playerColliders.Length; i++)
			{
				if (playerColliders[i] != null)
				{
					Physics.IgnoreCollision(playerColliders[i], ownCollider, false);
				}
			}
		}
		dead = false;
	}

	private void FixedUpdate()
	{
		if (playerTransform == null || Vector3.Distance(base.transform.position, playerTransform.position) > activateDistance || dead)
		{
			return;
		}
		if (rigidbody != null)
		{
			rigidbody.velocity = currentDirection * speed * Time.fixedDeltaTime;
		}
		if (Physics.Raycast(base.transform.position, currentDirection, rotateDistance, RotateLayers))
		{
			currentDirection = -currentDirection;
		}
		if (lookTransform != null)
		{
			Quaternion to = Quaternion.Euler(0f, Mathf.Sign(0f - currentDirection.x) * 90f, 0f);
			lookTransform.rotation = Quaternion.RotateTowards(lookTransform.rotation, to, Time.deltaTime * rotateSpeed);
		}
	}

	public void Kill()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.Play(deathClip, delegate(AudioSource s)
			{
				s.volume = 0.6f;
				s.pitch = UnityEngine.Random.Range(0.95f, 1.05f);
			});
		}
		dead = true;
		if (playerColliders != null && ownCollider != null)
		{
			for (int i = 0; i < playerColliders.Length; i++)
			{
				if (playerColliders[i] != null)
				{
					Physics.IgnoreCollision(playerColliders[i], ownCollider, true);
				}
			}
		}
		if (rigidbody != null)
		{
			rigidbody.constraints = RigidbodyConstraints.None;
			rigidbody.AddForce(Vector3.up * deathForce + Vector3.back * deathForce, ForceMode.Impulse);
		}
	}

	public bool IsDead()
	{
		return dead;
	}
}
