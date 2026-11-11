using Audio;
using UnityEngine;

public class Swing : MonoBehaviour
{
	public bool DoSwing = true;

	public bool UsePhysics;

	public Vector3 Axis;

	public AnimationCurve AngleCurve;

	public float timeOffset;

	public AudioClip swooshClip;

	public float speedFactor = 1f;

	public bool useTimeTime = true;

	private float timeIn;

	private float timeOut;

	private float soundCooldown;

	private float nextSoundAt;

	private Rigidbody rigidbody;

	private float timeValueUsed;

	private Quaternion initialRotation;

	[SerializeField]
	private bool useLocalRotation = true;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		if (UsePhysics)
		{
			if (rigidbody != null)
			{
				initialRotation = useLocalRotation ? rigidbody.transform.localRotation : rigidbody.transform.rotation;
			}
		}
		else
		{
			initialRotation = useLocalRotation ? transform.localRotation : transform.rotation;
		}
		if (AngleCurve != null && AngleCurve.keys != null && AngleCurve.keys.Length > 0)
		{
			timeIn = AngleCurve.keys[0].time;
			timeOut = AngleCurve.keys[AngleCurve.length - 1].time;
			soundCooldown = timeOut - 0.2f;
			nextSoundAt = 0.3f;
		}
	}

	public void ReturnToDefaultRotation()
	{
		if (rigidbody != null)
		{
			rigidbody.transform.localRotation = initialRotation;
		}
	}

	public void StartSwinging()
	{
		DoSwing = true;
		if (rigidbody != null)
		{
			rigidbody.isKinematic = false;
		}
	}

	public void StopSwinging(bool returnToDefaultRotation)
	{
		if (returnToDefaultRotation && rigidbody != null)
		{
			rigidbody.transform.localRotation = initialRotation;
		}
		if (rigidbody != null)
		{
			rigidbody.isKinematic = true;
		}
		DoSwing = false;
	}

	private void Update()
	{
		timeValueUsed = useTimeTime ? Time.time : Time.timeSinceLevelLoad;
		if (!UsePhysics && DoSwing && AngleCurve != null)
		{
			float angle = AngleCurve.Evaluate(timeOffset + speedFactor * timeValueUsed);
			transform.localRotation = initialRotation * Quaternion.AngleAxis(angle, Axis);
		}
	}

	private void FixedUpdate()
	{
		if (UsePhysics && rigidbody != null && DoSwing && AngleCurve != null)
		{
			float angle = AngleCurve.Evaluate(timeOffset + speedFactor * timeValueUsed);
			rigidbody.MoveRotation(initialRotation * Quaternion.AngleAxis(angle, Axis));
			if (timeValueUsed >= nextSoundAt)
			{
				Quaternion rotIn = initialRotation * Quaternion.AngleAxis(AngleCurve.Evaluate(timeIn), Axis);
				if (rigidbody.rotation == rotIn)
				{
					PlaySound();
					nextSoundAt = timeValueUsed + soundCooldown;
				}
				Quaternion rotOut = initialRotation * Quaternion.AngleAxis(AngleCurve.Evaluate(timeOut), Axis);
				if (rigidbody.rotation == rotOut)
				{
					PlaySound();
					nextSoundAt = timeValueUsed + soundCooldown;
				}
			}
		}
	}

	private void PlaySound()
	{
		if (swooshClip == null || AudioManager.Instance == null || AudioManager.Instance.sfx == null)
		{
			return;
		}
		float delay = Random.Range(0.15f, 0.2f);
		float pitch = Random.Range(0.25f, 0.37f);
		float vol = Random.Range(0.45f, 0.55f);
		AudioManager.Instance.sfx.Play(swooshClip, s =>
		{
			if (s != null)
			{
				s.transform.position = transform.position;
				s.volume = vol;
				s.pitch = pitch;
			}
		}, delay, false);
	}
}
