using System.Collections.Generic;
using UnityEngine;

public class OverworldFan : MonoBehaviour
{
	public bool isFanning;

	public Transform blade;

	public float bladeRotationSpeed;

	public Vector3 windForce;

	public WindArea2D windarea;

	public List<WindArea2D> extraWindAreas;

	public ParticleSystem particles;

	public AudioSource fanAudioSource;

	private void Awake()
	{
	}

	public void SetState(bool isStart)
	{
	}

	private void Update()
	{
	}
}
