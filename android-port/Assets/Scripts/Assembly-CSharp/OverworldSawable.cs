using UnityEngine;

public class OverworldSawable : MonoBehaviour
{
	public SpriteRenderer normal;

	public SpriteRenderer sawed;

	public Collider2D col;

	private bool didGetSawed;

	public GameObject[] ObjectsRoots;

	public ParticleSystem CutSystem;

	public PlantParticles PlantParticles;

	private void Start()
	{
		if (ObjectsRoots != null && ObjectsRoots.Length > 0)
		{
			int idx = Random.Range(0, ObjectsRoots.Length);
			if (ObjectsRoots[idx] != null)
				ObjectsRoots[idx].SetActive(true);
		}
	}

	public bool Saw()
	{
		if (didGetSawed)
			return false;
		didGetSawed = true;
		if (col != null)
			col.enabled = false;
		if (PlantParticles != null)
			PlantParticles.Emit(50);
		if (normal != null)
			normal.enabled = false;
		if (sawed != null)
			sawed.enabled = true;
		return true;
	}
}
