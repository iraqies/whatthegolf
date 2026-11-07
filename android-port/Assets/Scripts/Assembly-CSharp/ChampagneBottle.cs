using Audio;
using Core;
using UnityEngine;

public class ChampagneBottle : MonoBehaviour
{
	public int BurstInterval;

	public float Burstduration;

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
	}

	private void ControllerOnOnShoot(Vector3 vector3)
	{
	}

	private void Update()
	{
	}
}
