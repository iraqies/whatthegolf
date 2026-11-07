using Core;
using UnityEngine;

public class FillHoleWithWater : MonoBehaviour
{
	public Transform endposition;

	private Vector3 startPos;

	public float waterSpeed;

	private float waterCount;

	public GameObject boat;

	public GameObject cannon;

	private GolfBallController boatController;

	private GolfBallController cannonController;

	public Collider ColliderToDisable;

	public GameObject flagToEnable;

	public ParticleSystem waterParticles;

	public ParticleSystem controllerSwitchParticle;

	public AudioSource controllerSwitchAudio;

	private bool hasSwapped;

	private void Start()
	{
	}

	public void OnParticleCollided()
	{
	}

	private void Update()
	{
	}

	private void SwitchControllers()
	{
	}
}
