using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeShooter : MonoBehaviour
{
	[SerializeField]
	private bool PlayOnAwake;

	[SerializeField]
	private bool ContinousAim;

	[SerializeField]
	private float ContinousAimTime;

	[SerializeField]
	private Vector3 aimVector;

	[SerializeField]
	private List<AudioClip> clips;

	[SerializeField]
	private float baseVolume;

	[SerializeField]
	private float volumeDeviance;

	[SerializeField]
	private float basePitch;

	[SerializeField]
	private float pitchDeviance;

	[SerializeField]
	private float minDistance;

	[SerializeField]
	private float maxDistance;

	[SerializeField]
	private HotdogGolfer golferForContinousAim;

	private void PlaySound()
	{
	}

	private void Start()
	{
	}

	public void Execute()
	{
	}

	private IEnumerator ExecuteCRAim()
	{
		return null;
	}

	private IEnumerator ExecuteCR()
	{
		return null;
	}
}
