using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class CowTippable : MonoBehaviour
{
	public List<string> ActivatorTags;

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
	}

	private void Handle_OnCollisionEnter2D(Collision2D other)
	{
	}

	private IEnumerator TipRoutine()
	{
		return null;
	}
}
