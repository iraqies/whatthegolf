using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindObjectsInOverworld
{
	public static void Find<T>(List<T> list)
	{
		if (list == null)
		{
			return;
		}
		list.Clear();
		GameObject[] rootGameObjects = SceneManager.GetActiveScene().GetRootGameObjects();
		for (int i = 0; i < rootGameObjects.Length; i++)
		{
			if (rootGameObjects[i] != null)
			{
				list.AddRange(rootGameObjects[i].GetComponentsInChildren<T>(true));
			}
		}
	}
}
