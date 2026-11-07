using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	public AudioClip sfxShot;

	public AudioClip sfxShotSoftener;

	public BallShooter shooter;

	private SpriteRenderer sprite;

	private Camera cam;

	[NonSerialized]
	public Vector3 aimDir;

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}
}
