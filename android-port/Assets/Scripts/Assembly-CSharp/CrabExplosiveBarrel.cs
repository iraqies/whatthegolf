using System.Collections.Generic;
using UnityEngine;

public class CrabExplosiveBarrel : MonoBehaviour
{
	public bool HasExploded;

	public MeshRenderer Renderer;

	public List<GameObject> Particles;

	public void Reset()
	{
		HasExploded = false;
		if (Renderer != null)
		{
			Renderer.enabled = true;
		}
		if (Particles != null)
		{
			for (int i = 0; i < Particles.Count; i++)
			{
				if (Particles[i] != null)
				{
					Particles[i].SetActive(false);
				}
			}
		}
	}

	public void Explode()
	{
		if (HasExploded)
		{
			return;
		}
		HasExploded = true;
		if (Renderer != null)
		{
			Renderer.enabled = false;
		}
		if (Particles != null)
		{
			for (int i = 0; i < Particles.Count; i++)
			{
				if (Particles[i] != null)
				{
					Particles[i].SetActive(true);
					ParticleSystem ps = Particles[i].GetComponent<ParticleSystem>();
					if (ps != null)
					{
						ps.Play();
					}
				}
			}
		}
	}
}
