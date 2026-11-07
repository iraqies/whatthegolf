using System.Collections;
using Audio;
using UnityEngine;

public class JumpObstacle : MonoBehaviour
{
	[SerializeField]
	private OnTriggerEnterListener trampolineTrigger;

	[SerializeField]
	private float jumpHeight;

	[SerializeField]
	private Transform pullPosition;

	[SerializeField]
	private float pullDuration;

	[SerializeField]
	private float pullForce;

	[SerializeField]
	private float reactionDelay;

	[SerializeField]
	private ClipSettingsCollection reactionClips;

	[SerializeField]
	private ClipSettingsCollection bounceClips;

	[SerializeField]
	private Transform effectTransform;

	[SerializeField]
	private AnimationCurve effectScale;

	[SerializeField]
	private float effectDuration;

	private bool isPulling;

	private void Awake()
	{
	}

	private void HandleTrigger(Collider other)
	{
	}

	private IEnumerator BounceAndPull(Rigidbody rigidbody)
	{
		return null;
	}
}
