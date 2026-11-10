using System;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
	public float MinPopForceSqr = 4f;

	public List<string> PopTags;

	public List<AudioClip> PopSounds;

	public Vector3 ForceChangeRange;

	public Vector3 UpForceIfNoConstantForce;

	private ConstantForce upForce;

	private Vector3 startForce;

	private Rigidbody rigid;

	public bool isPopped;

	public Action<Balloon> OnPopped;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		upForce = GetComponent<ConstantForce>();
		if (upForce != null)
			startForce = upForce.force;
		else
			startForce = UpForceIfNoConstantForce;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (isPopped || other == null)
			return;
		bool tagMatch = PopTags == null || PopTags.Count == 0;
		if (!tagMatch && other.gameObject != null)
		{
			for (int i = 0; i < PopTags.Count; i++)
			{
				if (other.gameObject.CompareTag(PopTags[i]))
				{
					tagMatch = true;
					break;
				}
			}
		}
		if (tagMatch && other.relativeVelocity.sqrMagnitude >= MinPopForceSqr)
		{
			PopBalloon(1f);
		}
	}

	public void PopBalloon(float propbabiltity)
	{
		if (isPopped || UnityEngine.Random.value > propbabiltity)
			return;
		isPopped = true;
		if (PopSounds != null && PopSounds.Count > 0 && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(PopSounds);
		}
		OnPopped?.Invoke(this);
		gameObject.SetActive(false);
	}

	private void FixedUpdate()
	{
		if (isPopped)
			return;
		Vector3 delta = new Vector3(
			UnityEngine.Random.Range(-ForceChangeRange.x, ForceChangeRange.x),
			UnityEngine.Random.Range(-ForceChangeRange.y, ForceChangeRange.y),
			UnityEngine.Random.Range(-ForceChangeRange.z, ForceChangeRange.z)
		);
		if (upForce != null)
			upForce.force = startForce + delta;
		else if (rigid != null)
			rigid.AddForce(startForce + delta, ForceMode.Force);
	}
}
