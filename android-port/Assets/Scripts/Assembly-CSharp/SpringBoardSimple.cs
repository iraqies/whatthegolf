using System.Collections.Generic;
using Audio;
using UnityEngine;

public class SpringBoardSimple : MonoBehaviour
{
	public Vector3 ForceDirection;

	public float SpeedBoost;

	public ForceMode Mode;

	public ClipSettingsCollection sfxOnBounce;

	private List<Rigidbody> affectedRigidbodies;

	private float lastSfxTime;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
