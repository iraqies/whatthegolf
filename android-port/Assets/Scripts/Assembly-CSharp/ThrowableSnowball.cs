using System.Collections;
using CameraStack;
using UnityEngine;

public class ThrowableSnowball : MonoBehaviour
{
	public ParticleSystem HitParticles;

	public ParticleSystem FlyParticles;

	public TrailRenderer Trail;

	public float ShrinkTime = 4f;

	private Rigidbody rigid;

	private float baseDrag;

	public float HitShakeDuration;

	public float HitShakeSpeed;

	public float HitShakeMagnitude;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		if (rigid != null)
		{
			baseDrag = rigid.drag;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null || other.gameObject.CompareTag("Player"))
		{
			return;
		}
		if (HitParticles != null && other.contacts != null && other.contacts.Length != 0)
		{
			HitParticles.transform.position = other.contacts[0].point;
			HitParticles.Play();
		}
		SnowBallTargetBehaviour componentInParent = other.gameObject.GetComponentInParent<SnowBallTargetBehaviour>();
		if (componentInParent != null && other.contacts != null && other.contacts.Length != 0 && other.contacts[0].otherCollider != null)
		{
			if (componentInParent.Collapse(other, other.contacts[0].otherCollider.attachedRigidbody))
			{
				if (CameraManager.Instance != null)
				{
					CameraManager.Instance.Shake(HitShakeDuration, HitShakeSpeed, HitShakeMagnitude);
				}
				StartCoroutine(FreezeFrame());
			}
		}
		StartCoroutine(Shrink());
	}

	private void OnCollisionStay(Collision other)
	{
		if (rigid != null)
		{
			rigid.drag = 4f;
		}
	}

	private void OnCollisionExit(Collision other)
	{
		if (rigid != null)
		{
			rigid.drag = baseDrag;
		}
	}

	private IEnumerator Shrink()
	{
		Vector3 startScale = base.transform.localScale;
		if (HitParticles != null)
		{
			HitParticles.transform.parent = null;
			Object.Destroy(HitParticles.gameObject, 5f);
		}
		if (FlyParticles != null)
		{
			FlyParticles.transform.parent = null;
			Object.Destroy(FlyParticles.gameObject, 5f);
		}
		if (Trail != null)
		{
			Trail.transform.SetParent(null);
			Object.Destroy(Trail.gameObject, 5f);
		}
		yield return StartCoroutine(pTween.To(ShrinkTime, delegate(float t)
		{
			base.transform.localScale = Vector3.Lerp(startScale, Vector3.zero, Mathf.Clamp01(t));
		}));
		Object.Destroy(base.gameObject);
	}

	private IEnumerator FreezeFrame()
	{
		TimeControl timeControl = Object.FindObjectOfType<TimeControl>();
		if (timeControl != null)
		{
			timeControl.TogglePause(true);
			yield return new WaitForSecondsRealtime(0.025f);
			timeControl.TogglePause(false);
		}
	}
}
