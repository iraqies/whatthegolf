using Core;
using UnityEngine;

public class OverworldSeaAreaMusic : OverworldMusicChanger
{
	public OverworldMusicData SailingMusic;

	public OverworldMusicData IslandMusic;

	public float BehaviourCooldown;

	public float minimumPierDistance;

	public float minFlagDistance;

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
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	private void Update()
	{
	}

	private void SetByDistance<T>(T[] array, float minDist, MusicData music, float minRTPC, float maxRTPC) where T : Component
	{
	}
}
