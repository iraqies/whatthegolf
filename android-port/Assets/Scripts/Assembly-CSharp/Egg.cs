using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class Egg : MonoBehaviour
{
	public float smashSpeed;

	[SerializeField]
	private Transform crackedEgg;

	[SerializeField]
	private Transform smashedEgg;

	[SerializeField]
	private ClipSettingsCollection smashSFX;

	[SerializeField]
	private RandomAudioClips smashClips;

	[SerializeField]
	private LayerMask blacklistLayers;

	[SerializeField]
	private bool ReloadWhenSmashed;

	[SerializeField]
	private bool RotateSmashedEgg;

	[SerializeField]
	private float SmashedRotationOffset;

	[SerializeField]
	private Vector3 SmashedPositionOffset;

	[SerializeField]
	private float startWaitBeforeDisable;

	private GolfBallController controller;

	private Rigidbody rigidbody;

	private bool didHitGoal;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
