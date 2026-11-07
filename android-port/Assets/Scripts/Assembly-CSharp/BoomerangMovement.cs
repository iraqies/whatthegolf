using Audio;
using RootMotion.Dynamics;
using UnityEngine;

public class BoomerangMovement : MonoBehaviour
{
	public Transform ReturnPoint;

	public float RotateSpeed;

	public float ModelRotateSpeed;

	public float FlySpeed;

	public HammerThrowingCamera HammerCamera;

	public Transform Model;

	public float MaxVelocity;

	public float VelocityDampen;

	public Transform Center;

	public float ReturnThreshold;

	public PuppetMaster Puppet;

	public TrailRenderer trail;

	public AnimationCurve RotationCurve;

	public DropPropOnShoot PropDropper;

	public float TrailVelocityThreshold;

	public Collider Collider;

	public ClipSettingsCollection sfxOnShoot;

	public ClipSettingsCollection sfxOnPickup;

	public AudioSource whooshSource;

	public MinMax velocityForAudioModulation;

	public MinMax volumeRange;

	public MinMax pitchRange;

	private Rigidbody rigid;

	private PuppetMasterProp prop;

	private Quaternion origRot;

	private float throwTimer;

	private bool resetting;

	private Vector3 propBoost;

	private Rigidbody pickedUpRigid;

	private float timeAtAwake;

	private void Awake()
	{
	}

	private void PropDropped(Vector3 boost)
	{
	}

	private void FixedUpdate()
	{
	}

	private void HandleAudioWhileFlying()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
