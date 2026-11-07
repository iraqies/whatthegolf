using Chronos;
using Core;
using UnityEngine;

public class VelocityAffectsTime : MonoBehaviour
{
	public float MaxVelocity;

	public float MinVelocity;

	public Clock GlobalClock;

	private Rigidbody rigidbodyC;

	private bool gameHasEnded;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void InstanceOnOnLevelComplete(Level.CompletedState state)
	{
	}

	private void Update()
	{
	}
}
