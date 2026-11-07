using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObjectOnHit : MonoBehaviour
{
	public GameObject daObject;

	public List<string> ActivatorTags;

	public List<AudioClip> OnHitClip;

	public float delay;

	public float bounceFactor;

	public bool ignoreActivatorTags;

	private bool isHandlingHit;

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	public IEnumerator HandleHit()
	{
		return null;
	}
}
