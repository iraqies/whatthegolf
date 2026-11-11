using System.Collections;
using Core;
using UnityEngine;

public class Paw_SpeakerBallGenerator : MonoBehaviour
{
	[SerializeField]
	private float BlockShootingAfterSpawning = 0.5f;

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
		if (PlaceNewSpeakerCR == null)
		{
			PlaceNewSpeakerCR = StartCoroutine(PuttingNewSpeaker());
		}
	}

	protected void OnTriggerExit(Collider other)
	{
		if (other != null && other.CompareTag("GolfBall") && PlaceNewSpeakerCR == null)
		{
			PlaceNewSpeakerCR = StartCoroutine(PuttingNewSpeaker());
		}
	}

	private void PutNewSpeaker()
	{
		if (PlaceNewSpeakerCR == null)
		{
			PlaceNewSpeakerCR = StartCoroutine(PuttingNewSpeaker());
		}
	}

	private void BlockShoot(bool block)
	{
		if (controller != null)
		{
			controller.BlockShooting = block;
		}
		if (pawShooter != null)
		{
			pawShooter.isPlacingSpeaker = block;
		}
	}

	private IEnumerator PuttingNewSpeaker()
	{
		BlockShoot(true);
		if (animator != null)
		{
			animator.SetTrigger("NewSpeaker");
		}
		if (speakerToSpawn != null && speakerSlotOnDog != null)
		{
			GameObject spk = Object.Instantiate(speakerToSpawn, speakerSlotOnDog);
			currentSpeaker = spk.GetComponent<Rigidbody>();
			if (currentSpeaker != null)
			{
				currentSpeaker.useGravity = false;
			}
		}
		yield return new WaitForSeconds(0.4f);
		if (currentSpeaker != null)
		{
			Collider col = currentSpeaker.GetComponent<Collider>();
			if (col != null)
			{
				col.enabled = true;
			}
			currentSpeaker.transform.SetParent(null);
			currentSpeaker.useGravity = true;
			currentSpeaker.isKinematic = false;
		}
		yield return new WaitForSeconds(BlockShootingAfterSpawning);
		BlockShoot(false);
		PlaceNewSpeakerCR = null;
	}
}
