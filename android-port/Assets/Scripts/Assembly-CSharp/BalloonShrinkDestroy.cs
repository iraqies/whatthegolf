using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonShrinkDestroy : MonoBehaviour
{
	public float MinPopForceSqr;

	public List<string> PopTags;

	public List<AudioClip> PopSounds;

	public Vector3 ForceChangeRange;

	public Vector3 UpForceIfNoConstantForce;

	private ConstantForce upForce;

	private Vector3 startForce;

	private Rigidbody rigid;

	public float probabilityToPop;

	private bool canPop;

	private TreeCounter treeCountScript;

	public AnimationCurve ShrinkCurve;

	public float shrinkDuration;

	public bool isPopped;

	public Action<BalloonShrinkDestroy> OnPopped;

	private void Awake()
	{
		upForce = GetComponent<ConstantForce>();
		if (upForce != null && upForce.enabled)
		{
			startForce = upForce.force;
		}
		else
		{
			rigid = GetComponent<Rigidbody>();
			startForce = UpForceIfNoConstantForce;
		}
		treeCountScript = GetComponent<TreeCounter>();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!isPopped && other != null && PopTags != null && PopTags.Contains(other.transform.tag) && other.impulse.sqrMagnitude > MinPopForceSqr)
		{
			PopBalloon(probabilityToPop);
		}
	}

	public void PopBalloon(float probability)
	{
		if (UnityEngine.Random.value <= probability)
		{
			isPopped = true;
			if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
			{
				AudioManager.Instance.shortEffects.Play(PopSounds, delegate(AudioSource t)
				{
					if (t != null)
					{
						t.transform.position = base.transform.position;
					}
				}, true);
			}
			StartCoroutine(Shrink());
			OnPopped?.Invoke(this);
		}
	}

	private void FixedUpdate()
	{
		if (upForce != null && upForce.enabled)
		{
			if (ForceChangeRange != Vector3.zero)
			{
				upForce.force = startForce + ForceChangeRange * Mathf.Sin(Time.time);
			}
		}
		else if (rigid != null)
		{
			rigid.AddForce(startForce + ForceChangeRange * Mathf.Sin(Time.time), ForceMode.Acceleration);
		}
	}

	private void Update()
	{
		if (canPop && isPopped && treeCountScript != null)
		{
			treeCountScript.AddOneCount();
			canPop = false;
		}
	}

	public void StartShrink()
	{
		StartCoroutine(Shrink());
	}

	public IEnumerator Shrink()
	{
		float timer = shrinkDuration;
		Vector3 startScale = base.transform.localScale;
		while (timer > 0f)
		{
			float t = ((ShrinkCurve != null && shrinkDuration > 0f) ? Mathf.Clamp01(ShrinkCurve.Evaluate(1f - timer / shrinkDuration)) : 1f);
			base.transform.localScale = Vector3.LerpUnclamped(startScale, Vector3.zero, t);
			yield return null;
			timer -= Time.deltaTime;
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	public BalloonShrinkDestroy()
	{
		MinPopForceSqr = 10f;
		probabilityToPop = 2f;
		canPop = true;
		ShrinkCurve = new AnimationCurve(new Keyframe(1f, 0f), new Keyframe(0f, 1f));
		shrinkDuration = 1f;
	}
}
