using System;
using System.Collections.Generic;
using UnityEngine;

public class HoleInOneTransition : MonoBehaviour
{
	public AudioClip sfxWin;

	public AudioClip sfxLost;

	public float volume;

	public Color winColor;

	public Color loseColor;

	public float inScale;

	public float outScale;

	public SpriteRenderer endCoverSprite;

	private List<SpriteRenderer> sprites;

	private Vector3 basePosition;

	public void InstantIn()
	{
	}

	private void Awake()
	{
	}

	public void StarTransition(Vector3 pos, bool isWon, Action onClear)
	{
	}

	public void EndTransition(Vector3 pos, Action onCompleted)
	{
	}
}
