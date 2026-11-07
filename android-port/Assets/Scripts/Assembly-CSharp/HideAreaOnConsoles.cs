using System.Collections.Generic;
using Core;
using UnityEngine;

public class HideAreaOnConsoles : MonoBehaviour
{
	private enum PlatformCondition
	{
		IsContainedInList = 0,
		IsNotContainedInList = 1
	}

	[SerializeField]
	private List<Store> stores;

	[SerializeField]
	private PlatformCondition applyWhenCurrentPlatform;

	[SerializeField]
	private List<GameObject> m_objectsToShow;

	[SerializeField]
	private List<GameObject> m_objectsToHide;

	private void Start()
	{
	}

	public void HideAndShow()
	{
	}
}
