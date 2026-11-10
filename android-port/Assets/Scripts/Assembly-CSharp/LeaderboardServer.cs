using System;
using System.Collections;
using Core;
using UnityEngine;

public class LeaderboardServer : MonoBehaviour
{
	private static LeaderboardServer _instance;

	private DateTime serverTime;

	private float waitShort;

	private float waitLong;

	public static LeaderboardServer Instance
	{
		get
		{
			if (_instance == null)
			{
				GameObject obj = new GameObject("LeaderboardServer");
				UnityEngine.Object.DontDestroyOnLoad(obj);
				_instance = obj.AddComponent<LeaderboardServer>();
			}
			return _instance;
		}
	}

	public DateTime GetDateTime()
	{
		if (RuntimeStoreData.instance != null && RuntimeStoreData.instance.onlineLeaderboardType != PlatformSettings.OnlineLeaderboardType.None)
		{
			return serverTime;
		}
		return DateTime.Now;
	}

	private IEnumerator Start()
	{
		serverTime = DateTime.Now;
		if (LeaderboardManager.Instance != null && LeaderboardManager.Instance.CanRequestServerTime())
		{
			yield return new WaitForSeconds(0.1f);
			StartCoroutine(UpdateServerTime());
		}
	}

	private IEnumerator UpdateServerTime()
	{
		while (true)
		{
			bool hasResponse = false;
			bool wasSuccess = false;
			if (LeaderboardManager.Instance != null && LeaderboardManager.Instance.IsLoggedIn())
			{
				LeaderboardManager.Instance.RequestServerTime(delegate(bool success, DateTime time)
				{
					hasResponse = true;
					wasSuccess = success;
					if (success)
					{
						serverTime = time;
					}
				});
			}
			if (hasResponse)
			{
				yield return new WaitForSeconds(wasSuccess ? waitLong : waitShort);
			}
			else
			{
				yield return new WaitForSeconds(5f);
			}
		}
	}

	private void Update()
	{
		serverTime = serverTime.AddSeconds(Time.deltaTime);
	}

	public LeaderboardServer()
	{
		serverTime = DateTime.Now;
		waitShort = 300f;
		waitLong = 3600f;
	}
}
