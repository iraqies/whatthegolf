using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeggleBob : MonoBehaviour
{
	public Color OffColor;

	public float BounceForce = 10f;

	public SpriteRenderer InnerSprite;

	public AudioSource HitSource;

	public float PitchMod = 1.01f;

	public List<AudioClip> RemoveClips;

	public float hitTime;

	public bool HasBeenHit { get; private set; }

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (!HasBeenHit)
		{
			if (col != null && col.rigidbody != null)
			{
				col.rigidbody.velocity = Vector2.zero;
				if (col.contacts != null && col.contacts.Length > 0)
				{
					Vector2 normal = col.contacts[0].normal;
					col.rigidbody.AddForce(-normal * BounceForce, ForceMode2D.Impulse);
				}
			}
			if (HitSource != null)
			{
				HitSource.Play();
				HitSource.pitch *= PitchMod;
			}
			if (InnerSprite != null)
			{
				InnerSprite.color = OffColor;
			}
			hitTime = Time.time;
		}
		HasBeenHit = true;
	}

	public void Remove()
	{
		StartCoroutine(RemoveRoutine());
	}

	private IEnumerator RemoveRoutine()
	{
		Vector3 origScale = transform.localScale;
		if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && RemoveClips != null)
		{
			AudioManager.Instance.shortEffects.Play(RemoveClips);
		}
		yield return StartCoroutine(pTween.To(0.3f, t =>
		{
			transform.localScale = Vector3.Lerp(origScale, Vector3.zero, Mathf.Clamp01(t));
		}));
		gameObject.SetActive(false);
	}

	private void Update()
	{
		if (gameObject.activeInHierarchy && HasBeenHit && Time.time > hitTime + 4f)
		{
			Collider2D col = GetComponent<Collider2D>();
			if (col != null)
				col.enabled = false;
		}
	}
}
