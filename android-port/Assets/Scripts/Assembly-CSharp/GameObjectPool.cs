using System.Collections.Generic;
using UnityEngine;

public class GameObjectPoolId : MonoBehaviour
{
	public GameObject prefab;
}

public class GameObjectPool : MonoBehaviour
{
	private static GameObjectPool instance;

	private Dictionary<GameObject, List<GameObject>> instances = new Dictionary<GameObject, List<GameObject>>();

	public static GameObjectPool Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<GameObjectPool>();
				if (instance == null)
				{
					var go = new GameObject("GameObjectPool");
					instance = go.AddComponent<GameObjectPool>();
				}
			}
			return instance;
		}
	}

	private List<GameObject> GetGameObjects(GameObject prefab)
	{
		if (!instances.TryGetValue(prefab, out var list) || list == null)
		{
			list = new List<GameObject>();
			instances[prefab] = list;
		}
		return list;
	}

	public GameObject Pop(GameObject prefab)
	{
		if (prefab == null)
			return null;

		var list = GetGameObjects(prefab);
		while (list.Count > 0)
		{
			int lastIdx = list.Count - 1;
			var inst = list[lastIdx];
			list.RemoveAt(lastIdx);
			if (inst != null)
			{
				inst.SetActive(true);
				return inst;
			}
		}

		var created = Instantiate(prefab);
		created.name = prefab.name + "(Pooled)";
		var poolId = created.GetComponent<GameObjectPoolId>();
		if (poolId == null)
			poolId = created.AddComponent<GameObjectPoolId>();
		poolId.prefab = prefab;
		created.SetActive(true);
		return created;
	}

	public void Push(GameObject gameObject)
	{
		if (gameObject == null)
			return;

		var poolId = gameObject.GetComponent<GameObjectPoolId>();
		if (poolId != null && poolId.prefab != null)
		{
			gameObject.SetActive(false);
			var list = GetGameObjects(poolId.prefab);
			if (!list.Contains(gameObject))
				list.Add(gameObject);
		}
		else
		{
			gameObject.SetActive(false);
		}
	}
}
