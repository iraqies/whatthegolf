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

	private float respawnDelay = 1f;

	private float respawnScaleUpDuration = 0.25f;

	private Vector3 initialPosition;

	private bool isBursting;

	[SerializeField]
	private ParticleSystem burstParticleSystem;

	[SerializeField]
	private int burstParticleAmount = 30;

	private BubbleCharacter pickedUpCharacter;

	public SpriteRenderer CharacterInBubbleRenderer;

	private void Awake()
	{
		golfBallController = GetComponent<GolfBallController>();
		rigidbody2D = GetComponent<Rigidbody2D>();
		initialPosition = transform.position;
		if (bubbleShadowProjector != null)
		{
			bubbleShadowProjector.transform.SetParent(transform.parent, true);
		}
	}

	public void Burst()
	{
		if (!isBursting)
		{
			StartCoroutine(Bursting());
		}
	}

	private IEnumerator Bursting()
	{
		isBursting = true;
		if (burstSound != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(burstSound);
		}
		if (burstParticleSystem != null)
		{
			burstParticleSystem.transform.SetParent(null);
			burstParticleSystem.transform.position = transform.position;
			burstParticleSystem.Emit(burstParticleAmount);
		}
		if (golfBallController != null)
		{
			golfBallController.CancelShooting();
			golfBallController.enabled = false;
		}
		if (CharacterInBubbleRenderer != null)
		{
			CharacterInBubbleRenderer.enabled = false;
		}
		if (pickedUpCharacter != null)
		{
			pickedUpCharacter.gameObject.SetActive(true);
			pickedUpCharacter.gameObject.transform.SetParent(null);
			pickedUpCharacter.gameObject.transform.localScale = Vector3.one;
			pickedUpCharacter.Release();
			pickedUpCharacter = null;
		}
		if (scaleRoot != null)
		{
			scaleRoot.localScale = Vector3.zero;
		}
		if (rigidbody2D != null)
		{
			rigidbody2D.velocity = Vector2.zero;
		}
		transform.position = initialPosition;
		if (bubbleShadowProjector != null)
		{
			bubbleShadowProjector.SizeMod = 0f;
		}
		yield return new WaitForSeconds(respawnDelay);
		if (burstParticleSystem != null)
		{
			burstParticleSystem.Stop();
		}
		if (golfBallController != null)
		{
			golfBallController.enabled = true;
		}
		if (respawnSound != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(respawnSound);
		}
		yield return StartCoroutine(pTween.To(respawnScaleUpDuration, t =>
		{
			if (scaleRoot != null)
			{
				scaleRoot.localScale = Vector3.one * t;
			}
			if (bubbleShadowProjector != null)
			{
				bubbleShadowProjector.SizeMod = t;
			}
		}));
		isBursting = false;
	}

	private void Start()
	{
		if (collisionSFX_WithoutCharacter != null)
		{
			collisionSFX_WithoutCharacter.enabled = true;
		}
		if (collisionSFX_WithCharacter != null)
		{
			collisionSFX_WithCharacter.enabled = false;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null)
		{
			return;
		}
		if (pickedUpCharacter == null && collision.rigidbody != null)
		{
			BubbleCharacter bc = collision.rigidbody.GetComponent<BubbleCharacter>();
			if (bc != null)
			{
				bc.Pickup();
				bc.gameObject.transform.SetParent(animationRoot);
				bc.gameObject.transform.localPosition = Vector3.zero;
				if (pickupClip != null)
				{
					pickupClip.Play(transform.position);
				}
				if (collisionSFX_WithCharacter != null)
				{
					collisionSFX_WithCharacter.enabled = true;
				}
				if (collisionSFX_WithoutCharacter != null)
				{
					collisionSFX_WithoutCharacter.enabled = false;
				}
				pickedUpCharacter = bc;
				bc.gameObject.SetActive(false);
				if (CharacterInBubbleRenderer != null)
				{
					CharacterInBubbleRenderer.enabled = true;
				}
				return;
			}
		}
		if (pickedUpCharacter != null && goal != null && collision.gameObject != null)
		{
			GolfGoal hitGoal = collision.gameObject.GetComponent<GolfGoal>();
			if (hitGoal == goal)
			{
				goal.TriggerGoal("BubbleWin");
			}
		}
	}
}
