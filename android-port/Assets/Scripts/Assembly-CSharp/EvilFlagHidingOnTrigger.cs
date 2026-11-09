using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class EvilFlagHidingOnTrigger : MonoBehaviour
{
	[SerializeField]
	private Transform endTarget;

	[SerializeField]
	private bool useTrigger = true;

	[SerializeField]
	private bool useCollision;

	[SerializeField]
	private List<string> AcceptedTags;

	[SerializeField]
	private List<Collider> Blacklist;

	private bool hasMoved;

	private Vector3 startPosition;

	private Vector3 endPosition;

	public float velocity = 10f;

	public float hideYOffset = 5f;

	private Rigidbody rigidbody;

	public RandomAudioClips audioClip;

	private void Start()
	{
		startPosition = transform.position;
		if (endTarget != null)
			endPosition = endTarget.position;
		rigidbody = GetComponent<Rigidbody>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (hasMoved || !useTrigger || other == null) return;
		if (AcceptedTags != null && AcceptedTags.Count > 0 && !AcceptedTags.Contains(other.gameObject.tag))
			return;
		if (Blacklist != null && Blacklist.Contains(other))
			return;
		if (!enabled) return;
		hasMoved = true;
		StartCoroutine(Move());
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (hasMoved || !useCollision || collision == null) return;
		if (AcceptedTags != null && AcceptedTags.Count > 0 && !AcceptedTags.Contains(collision.gameObject.tag))
			return;
		if (Blacklist != null && Blacklist.Contains(collision.collider))
			return;
		if (!enabled) return;
		hasMoved = true;
		StartCoroutine(Move());
	}

	private IEnumerator Move()
	{
		if (audioClip != null)
			audioClip.PlayRandomClip(transform.position);
		float spd = Mathf.Max(1f, velocity);
		Vector3 hiddenStart = startPosition - Vector3.up * hideYOffset;
		while (Vector3.Distance(transform.position, hiddenStart) > 0.05f)
		{
			Vector3 next = Vector3.MoveTowards(transform.position, hiddenStart, spd * Time.fixedDeltaTime);
			if (rigidbody != null) rigidbody.MovePosition(next);
			else transform.position = next;
			yield return new WaitForFixedUpdate();
		}

		Vector3 hiddenEnd = endPosition - Vector3.up * hideYOffset;
		if (rigidbody != null) rigidbody.MovePosition(hiddenEnd);
		else transform.position = hiddenEnd;
		yield return new WaitForFixedUpdate();

		if (audioClip != null)
			audioClip.PlayRandomClip(endPosition);
		while (Vector3.Distance(transform.position, endPosition) > 0.05f)
		{
			Vector3 next = Vector3.MoveTowards(transform.position, endPosition, spd * Time.fixedDeltaTime);
			if (rigidbody != null) rigidbody.MovePosition(next);
			else transform.position = next;
			yield return new WaitForFixedUpdate();
		}
		if (rigidbody != null) rigidbody.MovePosition(endPosition);
		else transform.position = endPosition;
	}
}
