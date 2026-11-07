using System.Collections.Generic;
using UnityEngine;

public class GameObjectPool : MonoBehaviour
{
	private static GameObjectPool instance;

	private Dictionary<GameObject, List<GameObject>> instances;

	public static GameObjectPool Instance => null;

	public GameObject Pop(GameObject prefab)
	{
		return null;
	}

	public void Push(GameObject gameObject)
	{
	}

	private List<GameObject> GetGameObjects(GameObject prefab)
	{
		return null;
	}
}
