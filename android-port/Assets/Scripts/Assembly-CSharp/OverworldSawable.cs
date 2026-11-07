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
	}

	public bool Saw()
	{
		return false;
	}
}
