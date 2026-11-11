using System.Collections.Generic;
using Core;
using UnityEngine;

public class OverworldSeaAreaMusic : OverworldMusicChanger
{
	public OverworldMusicData SailingMusic;

	public OverworldMusicData IslandMusic;

	public float BehaviourCooldown;

	public float minimumPierDistance;

	public float minFlagDistance = 15f;

	public Transform[] dockingPoints;

	public Transform IslandFlagContainer;

	private Transmogriffable m_transmogriffable;

	private Transmogrif.BALLSHAPES m_lastShape;

	private bool DoSailBehaviour;

	private bool DoIslandBehaviour;

	private OverworldGoal[] goals;

	private float m_lastRTPC_Time;

	public override void Init()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Transmogriffable component = collision.GetComponent<Transmogriffable>();
		if (!(component != null))
		{
			return;
		}
		m_transmogriffable = component;
		DoSailBehaviour = false;
		DoIslandBehaviour = false;
		if (goals == null && IslandFlagContainer != null)
		{
			goals = IslandFlagContainer.GetComponentsInChildren<OverworldGoal>();
		}
		if (component.shape == Transmogrif.BALLSHAPES.boat || component.shape == Transmogrif.BALLSHAPES.speedboat)
		{
			DoSailBehaviour = true;
			if (SailingMusic != null)
			{
				OverworldManager2d.Instance.m_music = SailingMusic;
				TriggerMusic(SailingMusic, new List<OverworldGoal>());
			}
		}
		else if (component.shape == Transmogrif.BALLSHAPES.islandBall)
		{
			DoIslandBehaviour = true;
			if (SailingMusic != null)
			{
				OverworldManager2d.Instance.m_music = IslandMusic;
				TriggerMusic(IslandMusic, new List<OverworldGoal>());
			}
		}
		else
		{
			DoSailBehaviour = false;
			DoIslandBehaviour = false;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.GetComponent<Transmogriffable>() != null)
		{
			DoSailBehaviour = false;
			DoIslandBehaviour = false;
		}
	}

	private void Update()
	{
		if (!(m_transmogriffable == null))
		{
			if (DoIslandBehaviour && Time.time > m_lastRTPC_Time)
			{
				SetByDistance(goals, minFlagDistance, IslandMusic.withTransition.baseMusicData, 1f, 0f);
				m_lastRTPC_Time = Time.time + BehaviourCooldown;
			}
			if (DoSailBehaviour && Time.time > m_lastRTPC_Time)
			{
				SetByDistance(dockingPoints, minimumPierDistance, SailingMusic.withTransition.baseMusicData, 1f, 3f);
				m_lastRTPC_Time = Time.time + BehaviourCooldown;
			}
		}
	}

	private void SetByDistance<T>(T[] array, float minDist, MusicData music, float minRTPC, float maxRTPC) where T : Component
	{
		float num = minDist;
		for (int i = 0; i < array.Length; i++)
		{
			if (!(array[i] == null))
			{
				float num2 = Vector2.Distance(array[i].transform.position, m_transmogriffable.transform.position);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		float rtcpValue = Mathf.Lerp(minRTPC, maxRTPC, num / minDist);
		AudioManager.Instance.music.SetOverwroldRTCP(music.rtcp, rtcpValue);
	}
}
