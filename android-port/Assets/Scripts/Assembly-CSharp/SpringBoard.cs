using System.Collections.Generic;
using UnityEngine;

public class SpringBoard : MonoBehaviour
{
	public Rigidbody Spring;

	public List<string> AffectTags;

	public float SpringDelay;

	public float SpringDuration;

	public float SpringHeight;

	public float RetractionTime;

	public float SpringAngle;

	public List<AudioClip> SpringClips;

	private bool hasSprung;

	private Vector3 startPos;

	private Quaternion startRot;

	private Quaternion targetRot;

	[SerializeField]
	private float ForceMultiplier;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
