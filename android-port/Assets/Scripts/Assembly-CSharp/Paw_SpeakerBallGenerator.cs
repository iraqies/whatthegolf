using System.Collections;
using Core;
using UnityEngine;

public class Paw_SpeakerBallGenerator : MonoBehaviour
{
	[SerializeField]
	private float BlockShootingAfterSpawning;

	[SerializeField]
	private GameObject speakerToSpawn;

	[SerializeField]
	private Transform speakerSlotOnDog;

	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private PawShooter pawShooter;

	[SerializeField]
	private Animator animator;

	private Rigidbody currentSpeaker;

	private Coroutine PlaceNewSpeakerCR;

	private void Start()
	{
	}

	protected void OnTriggerExit(Collider other)
	{
	}

	private void PutNewSpeaker()
	{
	}

	private void BlockShoot(bool block)
	{
	}

	private IEnumerator PuttingNewSpeaker()
	{
		return null;
	}
}
