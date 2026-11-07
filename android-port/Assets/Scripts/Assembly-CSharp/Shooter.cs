using System.Collections.Generic;
using Core;
using UnityEngine;
using Utility;

public class Shooter : MonoBehaviour
{
	public SpriteRenderer splatter;

	public float DistSplatter;

	public float HeightCheck;

	public float NormalMod;

	public LayerMask SplatterLayer;

	public List<Sprite> Sprites;

	public float GroundSplatterRotation;

	public float WallSplatterRotation;

	public float SplatterLifeTime;

	public float SplatterFadeTime;

	public LayerMask KillLayer;

	public ParticleSystem KillParticles;

	private Rigidbody rigidbody;

	private Vector3 lastPosition;

	private GameObject splatterContainer;

	private ObjectPool<SpriteRenderer> splatterPool;

	private Dictionary<SpriteRenderer, float> activeSplatters;

	private GolfBallController controller;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionStay(Collision other)
	{
	}

	private void SplatterAt(ContactPoint contact, GameObject objectHit)
	{
	}
}
