using Audio;
using Cinemachine;
using RootMotion.Dynamics;
using UnityEngine;

public class HammerThrowingCamera : MonoBehaviour
{
	public Animator CamAnimator;

	public PuppetMaster Puppet;

	public PuppetMasterProp Prop;

	public float ResetTime = 2f;

	public bool ShowParticlesWhenReequipping = true;

	public ClipSettingsCollection particleSfx;

	public ParticleSystem Particles;

	private float resetTimer;

	private const string followingPlayerName = "FollowingPlayer";

	private bool propThrown;

	private CinemachineStateDrivenCamera camera;

	private bool waitForBlend;

	private bool showParticles;

	private void Start()
	{
		camera = GetComponent<CinemachineStateDrivenCamera>();
	}

	private void OnDropProp(PuppetMasterProp prop)
	{
		propThrown = true;
		resetTimer = ResetTime;
		if (CamAnimator != null)
		{
			CamAnimator.SetBool(followingPlayerName, false);
		}
	}

	private void Update()
	{
		if (propThrown)
		{
			resetTimer -= Time.deltaTime;
			if (resetTimer <= 0f)
			{
				ForceReset(ShowParticlesWhenReequipping);
			}
		}
	}

	public void ForceReset(bool showParticles)
	{
		propThrown = false;
		this.showParticles = showParticles;
		if (CamAnimator != null)
		{
			CamAnimator.SetBool(followingPlayerName, true);
		}
		if (showParticles)
		{
			if (Particles != null)
			{
				Particles.Play();
			}
			if (particleSfx != null)
			{
				particleSfx.Play(null, transform.position, 1f, 1f);
			}
		}
	}
}
