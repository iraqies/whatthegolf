using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HotdogTargetManager : MonoBehaviour
{
	private List<HotdogTargetBehaviour> Targets;

	public UnityEvent OnAllTargetsHit;

	private void Start()
	{
	}

	private void CheckTargets(HotdogTargetBehaviour target)
	{
	}
}
