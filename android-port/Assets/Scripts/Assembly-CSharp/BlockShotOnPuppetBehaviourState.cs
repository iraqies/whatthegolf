using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class BlockShotOnPuppetBehaviourState : MonoBehaviour
{
	[SerializeField]
	private BehaviourPuppet puppet;

	[SerializeField]
	private BehaviourPuppet.State[] blockOnStates;

	private GolfBallController controller;

	private void Awake()
	{
	}

	public bool IsBlocking()
	{
		return false;
	}
}
