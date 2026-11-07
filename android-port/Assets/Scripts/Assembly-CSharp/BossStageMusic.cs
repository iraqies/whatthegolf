using System.Collections;
using UnityEngine;

public class BossStageMusic : MonoBehaviour
{
	public enum MusicStartTime
	{
		WhenPreviousFlagHit = 0,
		WhenHatched = 1
	}

	public Transform player;

	public Transform flag;

	public MusicStartTime musicStartTimeMode;

	public uint wwiseStateID;

	public uint rtpcID;

	public float startValue;

	public float endValue;

	public bool IncrementDistanceRTPC;

	public bool IncrementNormalRTPC_ByDistance;

	public bool SetMaxDistanceByInitialDistance;

	public float minDistance;

	public float MaxDistance;

	public bool IncrementNormalRTPC_ByTime;

	public float incrementOverTime;

	private const float slowUpdateDelay = 0.1f;

	private BossPlayerEgg hatchingEgg;

	private float m_maxDistance;

	public void StartStageMusic()
	{
	}

	public void OnCanMove()
	{
	}

	public void EndMusic()
	{
	}

	private IEnumerator SlowFixedUpdate()
	{
		return null;
	}
}
