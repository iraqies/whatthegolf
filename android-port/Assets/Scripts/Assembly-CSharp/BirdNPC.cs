using System;
using System.Collections.Generic;
using Audio;
using Chronos;
using UnityEngine;

public class BirdNPC : MonoBehaviour, IAudioEvent
{
	public List<string> ScaredOfTags;

	public Rigidbody scareOnOtherColliderEnter;

	public float MoveSpeed = 10f;

	public List<AudioClip> birdFlapClips;

	private Vector3? posTarget;

	private Animator birdAnimator;

	private Timeline _timeline;

	private Vector3 startPos;

	private Vector3 startScale;

	private bool wasScared;

	private RigidbodyCollisionInfo otherColInfo;

	public Action<BirdNPC> OnBirdScared;

	private int birdAnimatorFlyingID;

	public Action<Vector3> OnAudioEvent { get; set; }

	private void Start()
	{
		birdAnimator = GetComponent<Animator>();
		_timeline = GetComponent<Timeline>();
		startPos = base.transform.position;
		startScale = base.transform.localScale;
		MoveSpeed *= UnityEngine.Random.Range(0.8f, 1.2f);
		birdAnimatorFlyingID = Animator.StringToHash("isFlying");
		if (scareOnOtherColliderEnter != null)
		{
			otherColInfo = RigidbodyCollisionInfo.GetOrAdd(scareOnOtherColliderEnter.gameObject);
			if (otherColInfo != null)
			{
				otherColInfo.onCollision += OnOtherCollision;
			}
		}
	}

	private void OnOtherCollision(HitInfo hitinfo)
	{
		if (hitinfo.incomingVelocity.magnitude > 1f)
		{
			Scare();
		}
	}

	private void Update()
	{
		if (!posTarget.HasValue)
		{
			return;
		}
		float dt = ((_timeline != null) ? _timeline.deltaTime : Time.deltaTime);
		base.transform.position = Vector3.MoveTowards(base.transform.position, posTarget.Value, dt * MoveSpeed);
		float dist = Vector3.Distance(base.transform.position, posTarget.Value);
		if (dist > 0.1f)
		{
			Vector3 dir = (posTarget.Value - base.transform.position).normalized;
			if (dir != Vector3.zero)
			{
				base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.LookRotation(dir, Vector3.up), dt * 1000f);
			}
			float totalDist = Vector3.Distance(startPos, posTarget.Value);
			float t = ((totalDist > 0.0001f) ? Mathf.Clamp01(1f - dist / totalDist) : 1f);
			base.transform.localScale = Vector3.Lerp(startScale, Vector3.zero, t);
		}
		else if (birdAnimator != null && birdAnimator.GetBool(birdAnimatorFlyingID))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	public void SetTriggerRange(float radius)
	{
		SphereCollider col = GetComponent<SphereCollider>();
		if (col != null)
		{
			col.radius = radius;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null)
		{
			CheckIfScared(other.gameObject);
		}
	}

	private void CheckIfScared(GameObject obj)
	{
		if (ScaredOfTags == null || obj == null)
		{
			return;
		}
		for (int i = 0; i < ScaredOfTags.Count; i++)
		{
			if (obj.CompareTag(ScaredOfTags[i]))
			{
				Scare();
				break;
			}
		}
	}

	private void Scare()
	{
		if (!wasScared)
		{
			Vector3 pos = base.transform.position;
			wasScared = true;
			OnAudioEvent?.Invoke(pos);
			posTarget = new Vector3(pos.x + UnityEngine.Random.value * 20f, pos.y + 100f, pos.z + UnityEngine.Random.value * 20f);
			if (birdAnimator != null)
			{
				birdAnimator.SetBool(birdAnimatorFlyingID, true);
			}
			OnBirdScared?.Invoke(this);
		}
	}
}
