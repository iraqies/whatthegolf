using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeggleBob : MonoBehaviour
{
	public Color OffColor;

	public float BounceForce;

	public SpriteRenderer InnerSprite;

	public AudioSource HitSource;

	public float PitchMod;

	public List<AudioClip> RemoveClips;

	public float hitTime;

	public bool HasBeenHit { get; private set; }

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	public void Remove()
	{
	}

	private IEnumerator RemoveRoutine()
	{
		return null;
	}

	private void Update()
	{
	}
}
