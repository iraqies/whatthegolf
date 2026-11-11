using Chronos;
using Core;
using UnityEngine;

public class VelocityAffectsTime : MonoBehaviour
{
	public float MaxVelocity;

	public float MinVelocity = 0.1f;

	public Clock GlobalClock;

	private Rigidbody rigidbodyC;

	private bool gameHasEnded;

	private void Awake()
	{
		rigidbodyC = GetComponent<Rigidbody>();
	}

	private void Start()
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += InstanceOnOnLevelComplete;
		}
	}

	private void InstanceOnOnLevelComplete(Level.CompletedState state)
	{
		gameHasEnded = true;
	}

	private void Update()
	{
		if (GlobalClock == null)
		{
			return;
		}
		if (gameHasEnded)
		{
			GlobalClock.localTimeScale = 0f;
			return;
		}
		if (rigidbodyC != null)
		{
			float ratio = MaxVelocity != 0f ? rigidbodyC.velocity.magnitude / MaxVelocity : 0f;
			float scale = Mathf.Lerp(0f, 1f, Mathf.Max(ratio, MinVelocity));
			GlobalClock.localTimeScale = scale;
		}
	}
}
