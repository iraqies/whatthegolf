using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTransition : MonoBehaviour
{
	public Transform start;

	public SpriteRenderer circle;

	public SpriteRenderer circleEnd;

	public SpriteRenderer fullCircle;

	public Color dark;

	public Color bright;

	public GameObject fullScreenUIBlocker;

	private List<SpriteRenderer> circles;

	private List<SpriteRenderer> circlesPool;

	private List<SpriteRenderer> allPool;

	private List<float> circleTimes;

	private float timescale;

	private SpriteRenderer endCircle;

	private SpriteRenderer fullCircleEnd;

	private float nextCircleSpawn;

	private int sortingOrder;

	private bool isSpawning;

	private float endTimer;

	private Vector3 endCircleScale;

	private WaitForSeconds shortwait;

	private WaitForSeconds longwait;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public IEnumerator StartHole()
	{
		return null;
	}

	public IEnumerator EndHole(Action onDone = null)
	{
		return null;
	}
}
