using System;
using System.Collections.Generic;
using UnityEngine;

public class HoleInOneTransition : MonoBehaviour
{
	public AudioClip sfxWin;
	public AudioClip sfxLost;
	public float volume = 1f;
	public Color winColor = Color.green;
	public Color loseColor = Color.red;
	public float inScale = 1f;
	public float outScale = 0.01f;
	public SpriteRenderer endCoverSprite;
	private List<SpriteRenderer> sprites = new List<SpriteRenderer>();
	private Vector3 basePosition;

	public void InstantIn() { }

	private void Awake()
	{
		basePosition = transform.position;
	}

	public void StarTransition(Vector3 pos, bool isWon, Action onClear)
	{
		onClear?.Invoke();
	}

	public void EndTransition(Vector3 pos, Action onCompleted)
	{
		onCompleted?.Invoke();
	}
}
