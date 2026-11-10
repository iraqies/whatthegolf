using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
	public class ObjectPool<T> : IEnumerable<T>, IEnumerable
	{
		public List<GameObject> avalable;

		private List<GameObject> prefabs;

		private Transform poolTransform;

		public List<GameObject> inUse { get; private set; }

		public ObjectPool(GameObject prefab, int size = 0, Action<GameObject> doOnObject = null)
		{
			prefabs = new List<GameObject> { prefab };
			avalable = new List<GameObject>();
			inUse = new List<GameObject>();
			if (prefab != null)
			{
				GameObject gameObject = new GameObject("Pool_" + prefab.name);
				poolTransform = gameObject.transform;
			}
			for (int i = 0; i < size; i++)
			{
				GameObject obj = Retrieve(Vector3.zero, Quaternion.identity, null);
				doOnObject?.Invoke(obj);
			}
			if (size >= 1)
			{
				ReleaseAll();
			}
		}

		public void SetPoolTransformParent(Transform parent)
		{
			if (poolTransform != null)
			{
				poolTransform.SetParent(parent);
			}
		}

		public ObjectPool(List<GameObject> prefabs, int size = 0, Action<GameObject> doOnObject = null)
		{
			if (prefabs == null || prefabs.Count == 0)
			{
				return;
			}
			this.prefabs = prefabs;
			avalable = new List<GameObject>();
			inUse = new List<GameObject>();
			if (prefabs[0] != null)
			{
				GameObject gameObject = new GameObject("Pool_" + prefabs[0].name);
				poolTransform = gameObject.transform;
			}
			for (int i = 0; i < size; i++)
			{
				GameObject obj = Retrieve(Vector3.zero, Quaternion.identity, null);
				doOnObject?.Invoke(obj);
			}
			if (size >= 1)
			{
				ReleaseAll();
			}
		}

		public GameObject Retrieve(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Transform parent = null)
		{
			GameObject gameObject;
			if (avalable != null && avalable.Count > 0)
			{
				int index = avalable.Count - 1;
				gameObject = avalable[index];
				avalable.RemoveAt(index);
				if (gameObject != null)
				{
					gameObject.transform.position = position;
					gameObject.transform.rotation = rotation;
					gameObject.transform.parent = parent;
					gameObject.SetActive(true);
				}
			}
			else
			{
				int index2 = UnityEngine.Random.Range(0, prefabs.Count);
				GameObject gameObject2 = prefabs[index2];
				gameObject = UnityEngine.Object.Instantiate(gameObject2, position, rotation, parent);
				gameObject.name = gameObject2.name;
			}
			inUse.Add(gameObject);
			return gameObject;
		}

		public void Release(GameObject obj, bool setParentToPool = true)
		{
			if (obj != null)
			{
				if (setParentToPool)
				{
					obj.transform.parent = poolTransform;
				}
				obj.SetActive(false);
				inUse.Remove(obj);
				avalable.Add(obj);
			}
		}

		public GameObject Get(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Transform parent = null, bool setActive = true)
		{
			GameObject go = Retrieve(position, rotation, parent);
			if (go != null && !setActive)
			{
				go.SetActive(false);
			}
			return go;
		}

		public void Return(GameObject obj, bool setParentToPool = true)
		{
			Release(obj, setParentToPool);
		}

		public void ReleaseAll()
		{
			while (inUse != null && inUse.Count > 0)
			{
				int index = inUse.Count - 1;
				Release(inUse[index], true);
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			if (avalable != null)
			{
				foreach (GameObject item in avalable)
				{
					if (item != null)
					{
						T component = item.GetComponent<T>();
						if (component != null)
						{
							yield return component;
						}
					}
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
