using Audio;
using Core;
using UnityEngine;

public class ChampagneBottle : MonoBehaviour
{
	public int BurstInterval = 2;

	public float Burstduration = 3f;

	public GolfBallController Controller;

	public RandomAudioClips BurstClip;

	public AudioEnvelopeSettings FlowEnvelope;

	public SimpleEnvelope simpleEnvelope;

	public AudioSource FlowSource;

	private ParticleSystem particles;

	private ConstantForce force;

	private int strokeCounter;

	private bool hasBurst;

	private float burstTimer;

	private void Start()
	{
		particles = GetComponentInChildren<ParticleSystem>();
		force = GetComponent<ConstantForce>();
		Controller.OnShoot += ControllerOnOnShoot;
		if (FlowEnvelope != null)
		{
			FlowEnvelope.envelope.sustainTime = Burstduration - 0.2f;
		}
	}

	private void ControllerOnOnShoot(Vector3 vector3)
	{
		strokeCounter++;
		if (strokeCounter % BurstInterval != 0)
		{
			return;
		}
		burstTimer = Burstduration;
		if (!particles.isPlaying)
		{
			particles.Play();
		}
		if (FlowEnvelope != null)
		{
			FlowSource.Stop();
			FlowEnvelope.Trigger(AudioSettings.dspTime + (double)Time.deltaTime, true);
			FlowSource.time = Random.Range(0f, FlowSource.clip.length);
			FlowSource.Play();
		}
		else if (!FlowSource.isPlaying)
		{
			FlowSource.Play();
		}
		if (simpleEnvelope != null)
		{
			simpleEnvelope.Trigger();
		}
		force.enabled = true;
		BurstClip.PlayRandomClip(base.transform);
	}

	private void Update()
	{
		if (burstTimer > 0f)
		{
			burstTimer -= Time.deltaTime;
			return;
		}
		if (particles.isPlaying)
		{
			particles.Stop();
		}
		if (FlowSource.isPlaying && FlowEnvelope == null && simpleEnvelope == null)
		{
			FlowSource.Stop();
		}
		force.enabled = false;
	}
}
