using System.Collections.Generic;
using UnityEngine;

public class EnableOnPortal : MonoBehaviour
{
	public SimplePortal portal;

	public List<GameObject> toDisableWhenPortalIsReady;

	public List<GameObject> toEnableWhenPortalIsReady;

	private void Start()
	{
		UpdateStates();
		portal.OnPortalEnabledIfDidntStartEnabled += Portal_OnPortalEnabledIfDidntStartEnabled;
	}

	private void Portal_OnPortalEnabledIfDidntStartEnabled()
	{
		UpdateStates();
	}

	private void UpdateStates()
	{
		if (!portal.isActiveAndEnabled)
		{
			return;
		}
		int count = toEnableWhenPortalIsReady.Count;
		for (int i = 0; i < count; i++)
		{
			toEnableWhenPortalIsReady[i].SetActive(true);
		}
		int count2 = toDisableWhenPortalIsReady.Count;
		for (int j = 0; j < count2; j++)
		{
			toDisableWhenPortalIsReady[j].SetActive(false);
		}
	}
}
