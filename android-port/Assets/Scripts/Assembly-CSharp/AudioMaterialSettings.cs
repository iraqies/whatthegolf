using System.Collections.Generic;
using UnityEngine;

public class AudioMaterialSettings : MonoBehaviour
{
	public ObjectWeight objectWeight = ObjectWeight.Medium;

	public AudioMaterial material;

	public List<AudioMaterial> secondaryMaterials;

	private List<AudioMaterial> allMaterials;

	public List<AudioMaterial> GetMaterials
	{
		get
		{
			if (allMaterials != null)
				return allMaterials;
			allMaterials = new List<AudioMaterial>();
			if (material != null)
				allMaterials.Add(material);
			if (secondaryMaterials != null && secondaryMaterials.Count >= 1)
				allMaterials.AddRange(secondaryMaterials);
			return allMaterials;
		}
	}
}
