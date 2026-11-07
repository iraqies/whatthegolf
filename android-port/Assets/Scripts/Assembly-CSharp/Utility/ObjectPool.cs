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
		}

		public void SetPoolTransformParent(Transform parent)
		{
		}

		public ObjectPool(List<GameObject> prefabs, int size = 0, Action<GameObject> doOnObject = null)
		{
		}

		public GameObject Retrieve(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Transform parent = null)
		{
			return null;
		}

		public void Release(GameObject obj, bool setParentToPool = true)
		{
		}

		public void ReleaseAll()
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
