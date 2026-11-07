using System;
using System.Collections;
using UnityEngine;

public class LeaderboardServer : MonoBehaviour
{
	private static LeaderboardServer _instance;

	private DateTime serverTime;

	private float waitShort;

	private float waitLong;

	public static LeaderboardServer Instance => null;

	public DateTime GetDateTime()
	{
		return default;
	}

	private IEnumerator Start()
	{
		return null;
	}

	private IEnumerator UpdateServerTime()
	{
		return null;
	}

	private void Update()
	{
	}
}
