using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class Egg : MonoBehaviour
{
	public float smashSpeed = 1f;

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
	private bool RotateSmashedEgg = true;

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
		rigidbody = GetComponent<Rigidbody>();
	}

	private IEnumerator Start()
	{
		controller = GetComponent<GolfBallController>();
		if (startWaitBeforeDisable > 0f)
		{
			yield return new WaitForSecondsRealtime(startWaitBeforeDisable);
		}
		if (crackedEgg != null)
		{
			crackedEgg.gameObject.SetActive(false);
		}
		if (smashedEgg != null)
		{
			smashedEgg.gameObject.SetActive(false);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null)
		{
			return;
		}
		if (collision.gameObject.GetComponent<GolfGoal>() != null)
		{
			didHitGoal = true;
			return;
		}
		int mask = blacklistLayers;
		if (mask == (mask | (1 << collision.gameObject.layer)))
		{
			return;
		}
		if (collision.impulse.magnitude <= smashSpeed || collision.contacts == null || collision.contacts.Length == 0)
		{
			return;
		}
		if (smashedEgg != null)
		{
			smashedEgg.position = collision.contacts[0].point + SmashedPositionOffset;
			if (RotateSmashedEgg)
			{
				smashedEgg.rotation = Quaternion.FromToRotation(Vector3.up, collision.contacts[0].normal);
				smashedEgg.Rotate(smashedEgg.right, SmashedRotationOffset);
			}
			smashedEgg.gameObject.SetActive(true);
		}
		Renderer[] renderers = base.gameObject.transform.GetComponentsInChildren<Renderer>();
		for (int i = 0; i < renderers.Length; i++)
		{
			if (renderers[i] != null)
			{
				renderers[i].enabled = false;
			}
		}
		Collider[] colliders = base.gameObject.transform.GetComponentsInChildren<Collider>();
		for (int j = 0; j < colliders.Length; j++)
		{
			if (colliders[j] != null)
			{
				colliders[j].enabled = false;
			}
		}
		if (controller != null)
		{
			controller.StopAiming();
			controller.enabled = false;
		}
		Rigidbody rb = GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.isKinematic = true;
		}
		if (crackedEgg != null)
		{
			crackedEgg.position = base.transform.position;
			crackedEgg.rotation = base.transform.rotation;
			crackedEgg.gameObject.SetActive(true);
		}
		if (smashClips != null)
		{
			smashClips.PlayRandomClip(base.transform.position);
		}
		if (smashSFX != null)
		{
			smashSFX.Play(base.transform.position, 1f, 1f);
		}
		if (ReloadWhenSmashed && !didHitGoal && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, controller, 1f, true, "");
		}
	}
}
