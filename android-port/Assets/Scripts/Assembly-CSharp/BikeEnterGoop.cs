using System.Collections;
using Audio;
using UnityEngine;

public class BikeEnterGoop : MonoBehaviour
{
	public Transform FrontWheel;

	public Transform BackWheel;

	public float GoopAngularSpeed = -12f;

	private Rigidbody bikeRigid;

	private Coroutine slideCR;

	public float ExtraDistanceSlide;

	public float SpeedModifierOnEnter = 1f;

	public bool inGoop;

	private float enterMagnitude;

	private Vector3 prevBikePos;

	public double MaxDistanceSlide = 10.0;

	public float MaxEnterMagnitude = 12f;

	public bool AllowShootOutOfGoop;

	public ParticleSystem GoopParticleEffect;

	public ClipSettingsCollection EnterGoopSFX;

	public ClipSettingsCollection ExitGoopSFX;

	private AudioSource goopAudioSource;

	private void OnEnable()
	{
		inGoop = false;
		bikeRigid = GetComponent<Rigidbody>();
		if (GoopParticleEffect != null)
		{
			GoopParticleEffect.Stop();
		}
	}

	public void EnterGoop()
	{
		if (slideCR != null)
		{
			StopCoroutine(slideCR);
			if (goopAudioSource != null)
			{
				goopAudioSource.Stop();
			}
		}
		if (!inGoop && bikeRigid != null)
		{
			enterMagnitude = Mathf.Clamp(bikeRigid.velocity.magnitude * SpeedModifierOnEnter, 0f, MaxEnterMagnitude);
			inGoop = true;
			prevBikePos = base.transform.position;
			if (GoopParticleEffect != null)
			{
				GoopParticleEffect.Play();
			}
			if (EnterGoopSFX != null)
			{
				EnterGoopSFX.Play(null, Vector3.zero, 1f, 1f);
				goopAudioSource = EnterGoopSFX.LastAudioSource;
			}
		}
	}

	public void ExitGoop()
	{
		if (inGoop)
		{
			slideCR = StartCoroutine(EndSlideCR());
			if (goopAudioSource != null)
			{
				goopAudioSource.Stop();
			}
			if (ExitGoopSFX != null)
			{
				ExitGoopSFX.Play(null, Vector3.zero, 1f, 1f);
			}
		}
	}

	private void FixedUpdate()
	{
		if (!inGoop)
		{
			return;
		}
		UpdateVelocity(1f);
		if (Vector3.Distance(prevBikePos, base.transform.position) >= MaxDistanceSlide)
		{
			if (!AllowShootOutOfGoop && bikeRigid != null)
			{
				bikeRigid.velocity = Vector3.zero;
				bikeRigid.angularVelocity = Vector3.zero;
			}
			if (goopAudioSource != null)
			{
				goopAudioSource.Stop();
			}
			inGoop = false;
			if (GoopParticleEffect != null)
			{
				GoopParticleEffect.Stop();
			}
		}
	}

	private IEnumerator EndSlideCR()
	{
		Vector3 startSlidePos = base.transform.position;
		while ((double)Vector3.Distance(startSlidePos, base.transform.position) < MaxDistanceSlide)
		{
			UpdateVelocity(0.5f);
			yield return new WaitForFixedUpdate();
		}
		if (!AllowShootOutOfGoop && bikeRigid != null)
		{
			bikeRigid.velocity = Vector3.zero;
			bikeRigid.angularVelocity = Vector3.zero;
		}
		inGoop = false;
		if (GoopParticleEffect != null)
		{
			GoopParticleEffect.Stop();
		}
	}

	private void UpdateVelocity(float mult = 1f)
	{
		if (bikeRigid == null || FrontWheel == null || BackWheel == null)
		{
			return;
		}
		Vector3 normalized = (FrontWheel.position - BackWheel.position).normalized;
		bikeRigid.velocity = normalized * enterMagnitude * mult;
		bikeRigid.angularVelocity = new Vector3(0f, 0f, GoopAngularSpeed * mult);
	}
}
