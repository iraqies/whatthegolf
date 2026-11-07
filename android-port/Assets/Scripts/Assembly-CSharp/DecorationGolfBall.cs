using System.Collections.Generic;
using UnityEngine;

public class DecorationGolfBall : MonoBehaviour
{
	[SerializeField]
	private List<AudioClip> clips;

	[SerializeField]
	private float baseVolume;

	[SerializeField]
	private float volumeDeviance;

	[SerializeField]
	private float basePitch;

	[SerializeField]
	private float pitchDeviance;

	[SerializeField]
	private float force;

	public bool useLocalY;

	[SerializeField]
	private Vector2 upwardsForceRange;

	[SerializeField]
	private List<string> otherTags;

	[SerializeField]
	private LayerMask otherLayers;

	[SerializeField]
	private float minForce;

	[SerializeField]
	private float useImpactVelocity;

	private Rigidbody rigid;

	private Rigidbody2D rigid2D;

	private float nextPush;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void TryKick(Vector3 magnitude, Vector3 point, Vector3 normal)
	{
	}

	private void PlaySfx()
	{
	}
}
