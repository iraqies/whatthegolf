using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
	[SerializeField]
	private Rigidbody2D rigidbody;

	[SerializeField]
	private Renderer renderer;

	[SerializeField]
	private List<Material> materials;

	[SerializeField]
	private float lifeTime;

	[SerializeField]
	private Vector2 shootForceRange;

	[SerializeField]
	private float minVelocity;

	private float spawnTime;

	private float startDrag;

	private int preventionzoneDepth;

	private ConfettiPrevention lastPrevention;

	private float lifeTimeLeft;

	private Vector3 startScale;

	private float originalDrag;

	private void Awake()
	{
	}

	public void Initiate()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	private void Kill()
	{
	}

	private void FixedUpdate()
	{
	}
}
