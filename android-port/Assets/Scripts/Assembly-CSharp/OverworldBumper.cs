using System.Collections;
using Audio;
using UnityEngine;

public class OverworldBumper : MonoBehaviour
{
	public Transform scaleTransform;
	public SpriteRenderer sprite;
	public Transform pupil;
	public float pupilMoveDist = 0.15f;
	public Color hitColor = Color.white;
	public Color baseColor = Color.white;
	public float pushForce = 15f;
	public float scaleOnHit = 1.2f;
	public ClipSettingsCollection bumperSFX;
	private float nextPush;
	private float pushCooldown = 0.05f;
	public float BlinkCooldownMin = 1f;
	public float BlinkCooldownMax = 4f;
	private float currentPupilDist;
	private float yScale = 1f;
	private bool hasBlinked;
	private bool DontBlink;
	private bool isBlinking;
	private bool isAwake;
	private Vector3 baseScale = Vector3.one;

	private void Awake()
	{
		isAwake = true;
		if (scaleTransform == null)
			scaleTransform = transform;
		baseScale = scaleTransform.localScale;
		yScale = baseScale.y;
		if (sprite != null)
			sprite.color = baseColor;
	}

	private void OnEnable()
	{
		if (isAwake && !DontBlink)
			StartCoroutine(BlinkRoutine());
	}

	public void EnableEye()
	{
		DontBlink = false;
		if (gameObject.activeInHierarchy)
			StartCoroutine(BlinkRoutine());
	}

	private void OnDisable()
	{
		StopAllCoroutines();
		if (scaleTransform != null)
			scaleTransform.localScale = baseScale;
	}

	private IEnumerator BlinkRoutine()
	{
		while (!DontBlink)
		{
			yield return new WaitForSeconds(Random.Range(Mathf.Max(0.5f, BlinkCooldownMin), Mathf.Max(1f, BlinkCooldownMax)));
			isBlinking = true;
			yield return pTween.To(0.08f, 0f, 1f, t =>
			{
				Vector3 s = transform.localScale;
				s.y = Mathf.Lerp(yScale, 0.05f, t);
				transform.localScale = s;
			});
			yield return pTween.To(0.08f, 0f, 1f, t =>
			{
				Vector3 s = transform.localScale;
				s.y = Mathf.Lerp(0.05f, yScale, t);
				transform.localScale = s;
			});
			isBlinking = false;
		}
	}

	private void Update()
	{
		if (pupil != null && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			Vector3 dir = (OverworldBallManager.Instance.Ball.transform.position - transform.position).normalized;
			currentPupilDist = Mathf.MoveTowards(currentPupilDist, pupilMoveDist, Time.deltaTime * 2f);
			pupil.localPosition = dir * currentPupilDist;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.collider == null) return;
		if (Time.time < nextPush) return;
		nextPush = Time.time + pushCooldown;

		var rb = collision.collider.attachedRigidbody;
		if (rb != null && collision.contacts != null && collision.contacts.Length > 0)
		{
			rb.AddForce(-collision.contacts[0].normal * pushForce, ForceMode2D.Impulse);
		}
		if (bumperSFX != null && AudioManager.Instance != null)
		{
			bumperSFX.Play(AudioManager.Instance.sfx, transform.position, 0f);
		}
		Bump();
	}

	public void Bump()
	{
		if (scaleTransform != null)
		{
			StartCoroutine(pTween.To(0.2f, 0f, 1f, t =>
			{
				float s = 1f + Mathf.Sin(t * Mathf.PI) * (scaleOnHit - 1f);
				scaleTransform.localScale = baseScale * s;
			}));
		}
		if (sprite != null)
		{
			sprite.color = hitColor;
			StartCoroutine(pTween.To(0.2f, 0f, 1f, t =>
			{
				if (sprite != null)
					sprite.color = Color.Lerp(hitColor, baseColor, t);
			}));
		}
	}
}
