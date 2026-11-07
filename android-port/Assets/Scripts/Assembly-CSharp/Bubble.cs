using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class Bubble : MonoBehaviour
{
	[SerializeField]
	private GolfGoal goal;

	[SerializeField]
	private Transform animationRoot;

	[SerializeField]
	private Transform scaleRoot;

	[SerializeField]
	private AudioClipSettings pickupClip;

	[SerializeField]
	private OnCollisionAudioBase collisionSFX_WithoutCharacter;

	[SerializeField]
	private OnCollisionAudioBase collisionSFX_WithCharacter;

	[SerializeField]
	private AudioClip respawnSound;

	[SerializeField]
	private AudioClip burstSound;

	[SerializeField]
	private ShadowProjector2D bubbleShadowProjector;

	private GolfBallController golfBallController;

	private Rigidbody2D rigidbody2D;

	private float respawnDelay;

	private float respawnScaleUpDuration;

	private Vector3 initialPosition;

	private bool isBursting;

	[SerializeField]
	private ParticleSystem burstParticleSystem;

	[SerializeField]
	private int burstParticleAmount;

	private BubbleCharacter pickedUpCharacter;

	public SpriteRenderer CharacterInBubbleRenderer;

	private void Awake()
	{
	}

	public void Burst()
	{
	}

	private IEnumerator Bursting()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
