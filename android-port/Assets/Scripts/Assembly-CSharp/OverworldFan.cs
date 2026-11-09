using System.Collections.Generic;
using UnityEngine;

public class OverworldFan : MonoBehaviour
{
	public bool isFanning = true;
	public Transform blade;
	public float bladeRotationSpeed = 360f;
	public Vector3 windForce = new Vector3(15f, 0f, 0f);
	public WindArea2D windarea;
	public List<WindArea2D> extraWindAreas;
	public ParticleSystem particles;
	public AudioSource fanAudioSource;

	private void Awake()
	{
		SetState(isFanning);
	}

	public void SetState(bool isStart)
	{
		isFanning = isStart;
		if (windarea != null)
		{
			windarea.WindForce = isFanning ? (Vector2)windForce : Vector2.zero;
			windarea.enabled = isFanning;
		}
		if (extraWindAreas != null)
		{
			foreach (var w in extraWindAreas)
			{
				if (w != null)
				{
					w.WindForce = isFanning ? (Vector2)windForce : Vector2.zero;
					w.enabled = isFanning;
				}
			}
		}
		if (particles != null)
		{
			if (isFanning) particles.Play();
			else particles.Stop();
		}
		if (fanAudioSource != null)
		{
			if (isFanning && !fanAudioSource.isPlaying) fanAudioSource.Play();
			else if (!isFanning && fanAudioSource.isPlaying) fanAudioSource.Stop();
		}
	}

	private void Update()
	{
		if (isFanning && blade != null)
		{
			blade.Rotate(0f, 0f, bladeRotationSpeed * Time.deltaTime);
		}
	}
}
