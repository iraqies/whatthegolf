using System.Collections;
using Audio;
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

	public float minDistance = 10f;

	public float MaxDistance = 200f;

	public bool IncrementNormalRTPC_ByTime;

	public float incrementOverTime = 25f;

	private const float slowUpdateDelay = 0.1f;

	private BossPlayerEgg hatchingEgg;

	private float m_maxDistance;

	public void StartStageMusic()
	{
		hatchingEgg = GetComponentInChildren<BossPlayerEgg>(true);
		if (hatchingEgg != null)
		{
			hatchingEgg.OnHatchEvent.AddListener(OnCanMove);
		}
		if (musicStartTimeMode == MusicStartTime.WhenPreviousFlagHit)
		{
			AudioManager.Instance.music.SetState(wwiseStateID, false, null, false);
		}
	}

	public void OnCanMove()
	{
		if (musicStartTimeMode == MusicStartTime.WhenHatched)
		{
			AudioManager.Instance.music.SetState(wwiseStateID, false, null, false);
		}
		AudioManager.Instance.music.setRTCPRaw(rtpcID, startValue, 500);
		m_maxDistance = (SetMaxDistanceByInitialDistance ? Vector3.Distance(player.position, flag.position) : MaxDistance);
		StartCoroutine(SlowFixedUpdate());
	}

	public void EndMusic()
	{
		AudioManager.Instance.music.setRTCPRaw(AK.GAME_PARAMETERS.BOSSDISTANCERTPC, 0f, 3000);
		StopAllCoroutines();
	}

	private IEnumerator SlowFixedUpdate()
	{
		WaitForSecondsRealtime wait = new WaitForSecondsRealtime(0.1f);
		int ms = Mathf.CeilToInt(100f);
		float timer = 0f;
		while (true)
		{
			yield return wait;
			timer += 0.1f;
			float value = Vector3.Distance(player.transform.position, flag.position);
			float num = 1f - AudioUtility.NormalizeMinMax01(value, minDistance, m_maxDistance);
			float rtcpValue = Mathf.Lerp(startValue, endValue, num);
			if (IncrementDistanceRTPC)
			{
				AudioManager.Instance.music.setRTCPRaw(AK.GAME_PARAMETERS.BOSSDISTANCERTPC, Mathf.Lerp(0f, 100f, num), ms);
			}
			if (IncrementNormalRTPC_ByDistance)
			{
				AudioManager.Instance.music.setRTCPRaw(rtpcID, rtcpValue, ms);
			}
			else if (IncrementNormalRTPC_ByTime)
			{
				rtcpValue = Mathf.Lerp(startValue, endValue, Mathf.Clamp01(timer / incrementOverTime));
				AudioManager.Instance.music.setRTCPRaw(rtpcID, rtcpValue, ms);
			}
		}
	}
}
