using System.Collections.Generic;
using UnityEngine;

public class EnableOnPortal : MonoBehaviour
{
	public SimplePortal portal;

	public List<GameObject> toDisableWhenPortalIsReady;

	public List<GameObject> toEnableWhenPortalIsReady;

	private void Start()
	{
	}

	private void Portal_OnPortalEnabledIfDidntStartEnabled()
	{
	}

	private void UpdateStates()
	{
	}
}
