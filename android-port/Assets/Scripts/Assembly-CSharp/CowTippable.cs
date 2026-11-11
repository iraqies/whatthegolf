using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class CowTippable : MonoBehaviour
{
	public List<string> ActivatorTags = new List<string> { "Ball", "Player" };

	private Animator CowAnimator;

	private bool isTipped;

	public ClipSettingsCollection mooClips;

	public ClipSettingsCollection switchClips;

	public OnCollisionEnter2DHandler cowCollisionHandler;

	private bool isTipping;

	public ShowSpeechbubbleOnHit SpeechStanding;

	public ShowSpeechbubbleOnHit SpeechLying;

	private void Awake()
	{
		CowAnimator = GetComponentInChildren<Animator>();
		if (cowCollisionHandler == null)
			cowCollisionHandler = GetComponentInChildren<OnCollisionEnter2DHandler>(true);
		if (cowCollisionHandler != null)
		{
			cowCollisionHandler.OnCollisionEnter2DEvent -= Handle_OnCollisionEnter2D;
			cowCollisionHandler.OnCollisionEnter2DEvent += Handle_OnCollisionEnter2D;
		}
	}

	private void Handle_OnCollisionEnter2D(Collision2D other)
	{
		if (isTipping || other == null || other.gameObject == null)
			return;
		string otherTag = other.gameObject.tag;
		bool accepted = ActivatorTags == null || ActivatorTags.Count == 0 || ActivatorTags.Contains(otherTag)
			|| (otherTag == "Ball" && ActivatorTags.Contains("Player"))
			|| (otherTag == "Player" && ActivatorTags.Contains("Ball"));
		if (accepted)
		{
			StartCoroutine(TipRoutine());
		}
	}

	private IEnumerator TipRoutine()
	{
		isTipping = true;
		isTipped = !isTipped;
		if (CowAnimator != null)
			CowAnimator.SetBool("Tipped", isTipped);

		if (switchClips != null && AudioManager.Instance != null)
			switchClips.Play(AudioManager.Instance.sfx, transform.position, 0.1f);

		yield return new WaitForSeconds(1f);

		if (mooClips != null && AudioManager.Instance != null)
			mooClips.Play(AudioManager.Instance.sfx, transform.position, 0f);

		isTipping = false;
		if (isTipped)
		{
			if (SpeechStanding != null)
				SpeechStanding.Interrupt();
			if (SpeechLying != null)
				SpeechLying.ForceStartSpeechBubble();
		}
		else
		{
			if (SpeechLying != null)
				SpeechLying.Interrupt();
			if (SpeechStanding != null)
				SpeechStanding.ForceStartSpeechBubble();
		}
	}
}
