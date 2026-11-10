using System.Collections.Generic;
using UnityEngine;

public class DeactivateObjectOnAwake : MonoBehaviour
{
	public List<GameObject> ObjectsToDeactivate;

	private void Awake()
	{
		if (ObjectsToDeactivate == null)
			return;
		foreach (GameObject go in ObjectsToDeactivate)
		{
			if (go != null)
				go.SetActive(false);
		}
	}
}
