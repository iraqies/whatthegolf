using UnityEngine;

public class ActivateObjects : MonoBehaviour
{
	public GameObject[] objectsToActivate;

	public void ActivateGameObjects()
	{
		if (objectsToActivate == null) return;
		for (int i = 0; i < objectsToActivate.Length; i++)
		{
			if (objectsToActivate[i] != null)
				objectsToActivate[i].SetActive(true);
		}
	}
}
