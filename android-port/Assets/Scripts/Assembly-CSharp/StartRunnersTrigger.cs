using System.Collections.Generic;
using UnityEngine;

public class StartRunnersTrigger : MonoBehaviour
{
	[SerializeField]
	private List<Runner> runners;

	[SerializeField]
	private Transform runnerContainer;

	[SerializeField]
	private LayerMask acceptLayers;

	[SerializeField]
	private bool stopOnAwake;

	private bool startedRunners;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
