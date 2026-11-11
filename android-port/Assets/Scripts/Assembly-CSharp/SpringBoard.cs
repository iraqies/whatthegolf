using System.Collections.Generic;
using UnityEngine;

public class SpringBoard : MonoBehaviour
{
	public Rigidbody Spring;

	public List<string> AffectTags;

	public float SpringDelay = 0.5f;

	public float SpringDuration = 0.5f;

	public float SpringHeight = 6f;

	public float RetractionTime = 6f;

	public float SpringAngle = 45f;

	public List<AudioClip> SpringClips;

	private bool hasSprung;

	private Vector3 startPos;

	private Quaternion startRot;

	private Quaternion targetRot;

	[SerializeField]
	private float ForceMultiplier = 5f;

	private void Awake()
	{
		startPos = base.transform.position;
		startRot = base.transform.rotation;
		targetRot = Quaternion.Euler(SpringAngle, base.transform.localRotation.eulerAngles.y, base.transform.localRotation.eulerAngles.z);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (hasSprung || !AffectTags.Contains(other.tag))
		{
			return;
		}
		StartCoroutine(pTween.To(SpringDelay, delegate
		{
		}).Then(delegate
		{
			AudioManager.Instance.sfx.Play(SpringClips);
			if (other.attachedRigidbody != null)
			{
				other.attachedRigidbody.AddForce(targetRot * base.transform.up * ForceMultiplier, ForceMode.Impulse);
			}
		}).Then(pTween.To(SpringDuration, delegate(float t)
		{
			Spring.MovePosition(Vector3.Lerp(startPos, startPos + base.transform.up * SpringHeight, t));
			Spring.MoveRotation(Quaternion.Lerp(startRot, targetRot, t));
		})).Then(pTween.To(RetractionTime, delegate(float t)
		{
			Spring.MovePosition(Vector3.Lerp(startPos + base.transform.up * SpringHeight, startPos, t));
			Spring.MoveRotation(Quaternion.Lerp(targetRot, startRot, t));
		}).Then(delegate
		{
			hasSprung = false;
		})));
		hasSprung = true;
	}

	private void OnDrawGizmos()
	{
		targetRot = Quaternion.Euler(SpringAngle, base.transform.localRotation.eulerAngles.y, base.transform.localRotation.eulerAngles.z);
		Gizmos.DrawLine(base.transform.position, base.transform.position + targetRot * base.transform.up * 10f);
	}
}
