using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectBasedOnDoor : MonoBehaviour
{
	public List<GameObject> ObjectsToToggle;

	public bool OnIfDisabled;

	private void OnEnable()
	{
		if (ObjectsToToggle == null)
			return;
		foreach (GameObject go in ObjectsToToggle)
		{
			if (go != null)
				go.SetActive(!OnIfDisabled);
		}
	}

	private void OnDisable()
	{
		if (ObjectsToToggle == null)
			return;
		foreach (GameObject go in ObjectsToToggle)
		{
			if (go != null)
				go.SetActive(OnIfDisabled);
		}
	}
}
