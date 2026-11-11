using Audio;
using RootMotion.Dynamics;
using UnityEngine;

public class BoomerangMovement : MonoBehaviour
{
	public Transform ReturnPoint;

	public float RotateSpeed = 90f;

	public float ModelRotateSpeed = 720f;

	public float FlySpeed = 20f;

	public HammerThrowingCamera HammerCamera;

	public Transform Model;

	public float MaxVelocity = 25f;

	public float VelocityDampen = 0.9f;

	public Transform Center;

	public float ReturnThreshold = 1.5f;

	public PuppetMaster Puppet;

	public TrailRenderer trail;

	public AnimationCurve RotationCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

	public DropPropOnShoot PropDropper;

	public float TrailVelocityThreshold = 5f;

	public Collider Collider;

	public ClipSettingsCollection sfxOnShoot;

	public ClipSettingsCollection sfxOnPickup;

	public AudioSource whooshSource;

	public MinMax velocityForAudioModulation = new MinMax(0f, 20f);

	public MinMax volumeRange = new MinMax(0.1f, 1f);

	public MinMax pitchRange = new MinMax(0.8f, 1.4f);

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
		prop = GetComponent<PuppetMasterProp>();
		rigid = GetComponent<Rigidbody>();
		if (Model != null)
		{
			origRot = Model.localRotation;
		}
		if (PropDropper != null)
		{
			PropDropper.OnPropDropped += PropDropped;
		}
		timeAtAwake = Time.time;
	}

	private void PropDropped(Vector3 boost)
	{
		propBoost = boost.normalized;
	}

	private void FixedUpdate()
	{
		if (prop == null)
		{
			return;
		}
		if (prop.isPickedUp)
		{
			if (pickedUpRigid == null)
			{
				pickedUpRigid = prop.GetRigidbody();
			}
			throwTimer = 0f;
			if (Model != null)
			{
				Model.localRotation = origRot;
			}
			resetting = false;
			if (pickedUpRigid != null && trail != null)
			{
				trail.enabled = pickedUpRigid.velocity.magnitude > TrailVelocityThreshold;
			}
			if (whooshSource != null && whooshSource.isPlaying)
			{
				whooshSource.volume = Mathf.MoveTowards(whooshSource.volume, 0f, Time.deltaTime * 4f);
				if (whooshSource.volume <= 0.01f)
				{
					whooshSource.Stop();
				}
			}
			return;
		}
		if (throwTimer == 0f && Time.time - timeAtAwake > 0.2f && sfxOnShoot != null)
		{
			sfxOnShoot.Play(null, transform.position, 1f, 1f);
		}
		throwTimer += Time.deltaTime;
		if (rigid == null)
		{
			rigid = prop.GetRigidbody();
		}
		if (rigid == null)
		{
			return;
		}
		HandleAudioWhileFlying();
		if (ReturnPoint != null && Center != null)
		{
			Vector3 toReturn = (ReturnPoint.position - Center.position).normalized;
			Vector3 dir = throwTimer < 0.3f && propBoost.sqrMagnitude > 0.01f ? propBoost : toReturn;
			if (dir.sqrMagnitude > 0.0001f)
			{
				float curveEval = RotationCurve != null && RotationCurve.length > 0 ? RotationCurve.Evaluate(throwTimer) : 1f;
				Quaternion targetRot = Quaternion.LookRotation(dir, Vector3.up);
				rigid.MoveRotation(Quaternion.RotateTowards(rigid.rotation, targetRot, RotateSpeed * curveEval * Time.deltaTime));
			}
		}
		rigid.AddForce(rigid.transform.forward * FlySpeed);
		if (Model != null)
		{
			Model.Rotate(Vector3.up, ModelRotateSpeed * Time.deltaTime, Space.Self);
		}
		if (rigid.velocity.magnitude > MaxVelocity)
		{
			rigid.velocity *= VelocityDampen;
		}
		if (!resetting && throwTimer > 0.5f && ReturnPoint != null && Vector3.Distance(rigid.position, ReturnPoint.position) < ReturnThreshold)
		{
			if (sfxOnPickup != null)
			{
				sfxOnPickup.Play(null, transform.position, 1f, 1f);
			}
			if (Puppet != null && Puppet.propMuscles != null && Puppet.propMuscles.Length > 0 && Puppet.propMuscles[0] != null)
			{
				Puppet.propMuscles[0].currentProp = prop;
			}
			if (HammerCamera != null)
			{
				HammerCamera.ForceReset(false);
			}
			resetting = true;
		}
	}

	private void HandleAudioWhileFlying()
	{
		if (whooshSource == null || rigid == null)
		{
			return;
		}
		if (!whooshSource.isPlaying && Time.time - timeAtAwake > 0.2f)
		{
			whooshSource.Play();
		}
		float norm = velocityForAudioModulation != null ? AudioUtility.NormalizeMinMax(rigid.velocity.magnitude, velocityForAudioModulation) : 0.5f;
		if (volumeRange != null)
		{
			whooshSource.volume = Mathf.Lerp(volumeRange.min, volumeRange.max, norm);
		}
		if (pitchRange != null)
		{
			whooshSource.pitch = Mathf.Lerp(pitchRange.min, pitchRange.max, norm);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!resetting && prop != null && !prop.isPickedUp && HammerCamera != null)
		{
			HammerCamera.ForceReset(false);
			resetting = true;
		}
		if (other != null && other.rigidbody != null && other.contacts != null && other.contacts.Length > 0)
		{
			other.rigidbody.AddExplosionForce(15f, other.contacts[0].point, 3f, 1f, ForceMode.Impulse);
		}
	}
}
