using System.Collections.Generic;
using UnityEngine;

public class AudioMaterialSettings : MonoBehaviour
{
	public ObjectWeight objectWeight;

	public AudioMaterial material;

	public List<AudioMaterial> secondaryMaterials;

	private List<AudioMaterial> allMaterials;

	public List<AudioMaterial> GetMaterials => null;
}
