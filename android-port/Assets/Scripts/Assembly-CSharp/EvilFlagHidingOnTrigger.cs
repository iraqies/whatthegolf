using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class EvilFlagHidingOnTrigger : MonoBehaviour
{
	[SerializeField]
	private Transform endTarget;

	[SerializeField]
	private bool useTrigger;

	[SerializeField]
	private bool useCollision;

	[SerializeField]
	private List<string> AcceptedTags;

	[SerializeField]
	private List<Collider> Blacklist;

	private bool hasMoved;

	private Vector3 startPosition;

	private Vector3 endPosition;

	public float velocity;

	public float hideYOffset;

	private Rigidbody rigidbody;

	public RandomAudioClips audioClip;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private IEnumerator Move()
	{
		return null;
	}
}
