using System.Collections;
using Core;
using UnityEngine;

public class BeachPartyManager : MonoBehaviour
{
	public float StartDelay;

	public float EndDelay;

	public ParticleSystem HintParticleSystem;

	private GolfBallController controller;

	private QuestState[] allStates;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator PartyRoutine()
	{
		return null;
	}
}
