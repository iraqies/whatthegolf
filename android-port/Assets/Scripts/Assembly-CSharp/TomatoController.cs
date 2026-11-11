using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class TomatoController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem SplatSystem;

	[SerializeField]
	private ClipSettingsCollection SplatClip;

	[SerializeField]
	private List<MeshRenderer> renders;

	[SerializeField]
	private bool CanFail = true;

	[SerializeField]
	private bool CanWin;

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		if (other.gameObject.CompareTag("Obstacle"))
		{
			Fail();
		}
		else if (other.gameObject.CompareTag("Player"))
		{
			Splat();
		}
	}

	private void Win()
	{
	}

	private void Fail()
	{
		if (CanFail && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "TomatoSplat");
		}
		Splat();
	}

	private void Splat()
	{
		if (SplatClip != null)
		{
			SplatClip.Play(null, transform.position, 1f, 1f);
		}
		if (SplatSystem != null)
		{
			SplatSystem.Play();
		}
		if (CanFail)
		{
			CMFreezePos freeze = Object.FindObjectOfType<CMFreezePos>();
			if (freeze != null)
			{
				freeze.Lock(true);
			}
			GolfBallController ctrl = Object.FindObjectOfType<GolfBallController>();
			if (ctrl != null)
			{
				if (ctrl.ShootArrow != null)
				{
					ctrl.ShootArrow.gameObject.SetActive(false);
				}
				ctrl.enabled = false;
			}
		}
		Rigidbody rb = GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.constraints = RigidbodyConstraints.FreezeAll;
		}
		if (renders != null)
		{
			for (int i = 0; i < renders.Count; i++)
			{
				if (renders[i] != null)
				{
					renders[i].enabled = false;
				}
			}
		}
		StartCoroutine(Die());
	}

	private IEnumerator Die()
	{
		yield return new WaitForSeconds(2f);
		Object.Destroy(gameObject);
	}
}
