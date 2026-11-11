using UnityEngine;

public class SnowmanCluster : MonoBehaviour
{
	public int maxNumberOfSnowmenSpawned = 3;

	public ObjectHiddenInSnow[] snowmen;

	private int currentNumberOfSnowmenSpawned;

	private void Start()
	{
		if (snowmen == null || snowmen.Length == 0)
		{
			snowmen = GetComponentsInChildren<ObjectHiddenInSnow>(true);
		}
	}

	private void Update()
	{
	}

	public void SnowmanActivated()
	{
		currentNumberOfSnowmenSpawned++;
		if (currentNumberOfSnowmenSpawned >= maxNumberOfSnowmenSpawned)
		{
			DeactiveHiddenSnowmen();
		}
	}

	private void DeactiveHiddenSnowmen()
	{
		if (snowmen == null)
		{
			return;
		}
		for (int i = 0; i < snowmen.Length; i++)
		{
			if (snowmen[i] != null && !snowmen[i].m_isVisible)
			{
				snowmen[i].gameObject.SetActive(false);
			}
		}
	}
}
