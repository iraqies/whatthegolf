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

	[SerializeField] private List<Store> stores;
	[SerializeField] private PlatformCondition applyWhenCurrentPlatform;
	[SerializeField] private List<GameObject> m_objectsToShow;
	[SerializeField] private List<GameObject> m_objectsToHide;

	private void Start()
	{
		HideAndShow();
	}

	public void HideAndShow()
	{
		Store currentStore = RuntimeStoreData.instance != null ? RuntimeStoreData.instance.storeType : Store.Arcade;
		bool contained = stores != null && stores.Contains(currentStore);
		bool apply = (applyWhenCurrentPlatform == PlatformCondition.IsContainedInList) ? contained : !contained;
		if (apply)
		{
			if (m_objectsToShow != null)
			{
				foreach (var go in m_objectsToShow)
					if (go != null) go.SetActive(true);
			}
			if (m_objectsToHide != null)
			{
				foreach (var go in m_objectsToHide)
					if (go != null) go.SetActive(false);
			}
		}
	}
}
