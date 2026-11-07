using Audio;
using Cinemachine;
using RootMotion.Dynamics;
using UnityEngine;

public class HammerThrowingCamera : MonoBehaviour
{
	public Animator CamAnimator;

	public PuppetMaster Puppet;

	public PuppetMasterProp Prop;

	public float ResetTime;

	public bool ShowParticlesWhenReequipping;

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
	}

	private void OnDropProp(PuppetMasterProp prop)
	{
	}

	private void Update()
	{
	}

	public void ForceReset(bool showParticles)
	{
	}
}
