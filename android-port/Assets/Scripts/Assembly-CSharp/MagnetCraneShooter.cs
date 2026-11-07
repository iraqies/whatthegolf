using System.Collections.Generic;
using Core;
using UnityEngine;

public class MagnetCraneShooter : MonoBehaviour
{
	public GolfBallController Controller;

	public BoxCollider Magnet;

	public LayerMask AffectMask;

	public float MagnetDistance;

	public float MagnetForce;

	public ForceMode MagnetForceMode;

	public MeshRenderer MagnetRenderer;

	public Material CraneMaterial;

	public Color OnColor;

	public Color OffColor;

	private List<FixedJoint> stuckRigidbodies;

	private Rigidbody rigid;

	private AudioSource magnetSource;

	private bool attractingAny;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
