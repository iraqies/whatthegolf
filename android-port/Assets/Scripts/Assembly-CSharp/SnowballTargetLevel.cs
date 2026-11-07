using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SnowballTargetLevel : MonoBehaviour
{
	public List<SnowBallTargetBehaviour> Targets;

	[SerializeField]
	private UnityEvent OnTargetsDown;

	[SerializeField]
	private bool WinOnTargetsHit;

	private void Start()
	{
	}

	private void OnCollapsed(SnowBallTargetBehaviour snowBallTargetBehaviour)
	{
	}
}
