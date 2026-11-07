using System;
using UnityEngine;

public class EndAreaMusicZone : MonoBehaviour
{
	public uint OnEnterRTPC;

	public Transform StartTarget;

	public Transform EndTarget;

	public float startValue;

	public float endValue;

	public Action<EndAreaMusicZone> OnZoneEntered;

	private OverworldBall2D ball;

	private float m_maxDistance;

	private float m_lastUpdateTime;

	private const float m_updateRate = 0.12f;

	public bool AreaActive { get; private set; }

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	private void Update()
	{
	}

	private void SetByDistance(int ms)
	{
	}
}
