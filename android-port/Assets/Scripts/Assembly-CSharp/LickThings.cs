using System.Collections.Generic;
using UnityEngine;

public class LickThings : MonoBehaviour
{
	public List<AudioClip> LickSFX;

	public float SpringForcePerKilo;

	public Collider StartLickedObject;

	public List<string> BlacklistTag;

	public Renderer TongueRenderer;

	private LineRope rope;

	private SpringJoint joint;

	private Rigidbody currentlyLicked;

	private GameObject tongueLineEnd;

	private void Awake()
	{
	}

	private void LickThings_OnReset()
	{
	}

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
