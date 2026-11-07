using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseSpringAction : MonoBehaviour
{
	public SpringJoint2D joint;

	public UnityEvent OnFullPull;

	public float InvokeThreshold;

	public List<AudioClip> ReleaseSounds;

	private float origDistance;

	private float delay;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}
}
