using System;
using System.Collections.Generic;
using Audio;
using Chronos;
using UnityEngine;

public class BirdNPC : MonoBehaviour, IAudioEvent
{
	public List<string> ScaredOfTags;

	public Rigidbody scareOnOtherColliderEnter;

	public float MoveSpeed;

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
	}

	private void OnOtherCollision(HitInfo hitinfo)
	{
	}

	private void Update()
	{
	}

	public void SetTriggerRange(float radius)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void CheckIfScared(GameObject obj)
	{
	}

	private void Scare()
	{
	}
}
