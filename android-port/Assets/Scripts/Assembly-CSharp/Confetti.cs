using System.Collections.Generic;
using Core;
using UnityEngine;

public class Confetti : MonoBehaviour
{
	public int amount = 2;

	private static Confetti instance;

	public float randomPitch = 0.05f;

	public List<AudioClip> clips;

	public List<ParticleSystem> particles;

	private static Confetti Instance
	{
		get
		{
			if (instance == null)
			{
				GameObject prefab = Resources.Load<GameObject>("Prefabs/ConfettiParticles");
				if (prefab != null)
				{
					GameObject go = Instantiate(prefab);
					if (go != null)
						instance = go.GetComponent<Confetti>();
				}
			}
			return instance;
		}
	}

	private void OnEnable()
	{
		instance = this;
	}

	public static void SpawnConfetti(Transform trans)
	{
		if (Instance != null)
			Instance.SpawnInternal(trans);
	}

	private void SpawnInternal(Transform trans)
	{
		if (particles == null || trans == null) return;
		transform.position = trans.position + Vector3.up * 0.5f;
		int count = Mathf.Clamp(amount, 1, particles.Count);
		List<int> indices = new List<int>();
		for (int i = 0; i < count; i++)
		{
			int idx = Random.Range(0, particles.Count);
			int guard = 0;
			while (indices.Contains(idx) && guard < 20)
			{
				idx = Random.Range(0, particles.Count);
				guard++;
			}
			indices.Add(idx);
			if (particles[idx] != null)
				particles[idx].Play();
		}

		if (clips != null && clips.Count >= 1)
		{
			int clipIdx = Random.Range(0, clips.Count);
			AudioClip clip = clips[clipIdx];
			if (clip != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
			{
				float pitch = Random.Range(-randomPitch, randomPitch) + 1f;
				bool nonSpatial = !Level.HasInstance || Level.Instance == null || !Level.Instance.IsMultiplayer;
				AudioManager.Instance.shortEffects.PlaySimple(clip, 0.7f, pitch, trans.position, 50f, nonSpatial);
			}
		}
	}
}
