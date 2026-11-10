using System;
using UnityEngine;

public class EasterEggPackstarter : MonoBehaviour
{
	[SerializeField]
	private int StartMonth;

	[SerializeField]
	private int StartDay;

	[SerializeField]
	private int EndMonth;

	[SerializeField]
	private int EndDay;

	[SerializeField]
	private bool debug;

	[SerializeField]
	private string url;

	private void Start()
	{
		if (CheckTime() && ProcessDeepLink.Instance != null && !ProcessDeepLink.Instance.HasEvent)
		{
			ProcessDeepLink.Instance.OnDeepLinkActivated(url);
		}
	}

	public void StartPack()
	{
		if (ProcessDeepLink.Instance != null)
		{
			ProcessDeepLink.Instance.OnDeepLinkActivated(url);
		}
	}

	private bool CheckTime()
	{
		if (debug) return true;
		try
		{
			DateTime now = DateTime.Now;
			DateTime start = new DateTime(now.Year, StartMonth, StartDay);
			DateTime end = new DateTime(now.Year, EndMonth, EndDay);
			if (now < start) return false;
			return !(now > end);
		}
		catch
		{
			return false;
		}
	}
}
