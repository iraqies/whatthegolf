using System;
using Audio;
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
		OverworldBall2D component = collision.GetComponent<OverworldBall2D>();
		if (component != null)
		{
			OnZoneEntered?.Invoke(this);
			ball = component;
			m_maxDistance = Vector2.Distance(StartTarget.position, EndTarget.position);
			AreaActive = true;
			m_lastUpdateTime = -2f;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.GetComponent<OverworldBall2D>() != null)
		{
			AreaActive = false;
		}
	}

	private void Update()
	{
		if (AreaActive && ball != null && Time.time > m_lastUpdateTime + 0.12f)
		{
			SetByDistance(120);
		}
	}

	private void SetByDistance(int ms)
	{
		float num = Mathf.Clamp01(Vector2.Distance(ball.transform.position, EndTarget.position) / m_maxDistance);
		float rtcpValue = Mathf.Lerp(startValue, endValue, 1f - num);
		AudioManager.Instance.music.setRTCPRaw(OnEnterRTPC, rtcpValue, ms);
	}
}
