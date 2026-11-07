using System;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeMaterial : MonoBehaviour
{
	[Serializable]
	public struct RandomizableMaterialInfo
	{
		public List<Material> materials;

		public int materialIndex;
	}

	public List<RandomizableMaterialInfo> randMaterialGroups;

	private void Start()
	{
	}
}
