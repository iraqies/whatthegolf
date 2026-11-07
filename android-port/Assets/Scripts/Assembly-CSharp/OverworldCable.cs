using System;
using System.Collections;
using UnityEngine;

public class OverworldCable : MonoBehaviour
{
	public LineRenderer line;

	public LineRenderer lineFill;

	public Material OffMaterial;

	public Material OnMaterial;

	public float Speed;

	public float LineOnMoveSpeed;

	public ParticleSystem Particles;

	public Action<float> OnMoveNormalized;

	private bool isOn;

	private float offsetTimer;

	private float offsetStartDamper;

	private const float zOffset = -0.1f;

	private void Awake()
	{
	}

	public void Toggle(bool state)
	{
	}

	public IEnumerator SetEnableColorRoutine(Action<Vector3> OnMove = null, bool instant = false)
	{
		return null;
	}

	private void Update()
	{
	}
}
