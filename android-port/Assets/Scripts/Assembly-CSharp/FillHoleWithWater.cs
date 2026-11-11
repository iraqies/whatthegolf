using Core;
using UnityEngine;

public class FillHoleWithWater : MonoBehaviour
{
	public Transform endposition;

	private Vector3 startPos;

	public float waterSpeed = 0.1f;

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
		startPos = base.transform.position;
		boatController = boat.GetComponent<GolfBallController>();
		cannonController = cannon.GetComponent<GolfBallController>();
	}

	public void OnParticleCollided()
	{
		waterCount += waterSpeed;
		if (waterCount >= 1f && !hasSwapped)
		{
			hasSwapped = true;
			waterCount = 1f;
			SwitchControllers();
		}
	}

	private void Update()
	{
		base.transform.position = Vector3.Lerp(startPos, endposition.position, Mathf.Clamp01(waterCount));
	}

	private void SwitchControllers()
	{
		boatController.enabled = true;
		cannonController.shootArrow.gameObject.SetActive(false);
		cannonController.enabled = false;
		flagToEnable.SetActive(true);
		waterParticles.Stop();
		controllerSwitchParticle.Play();
		controllerSwitchAudio.Play();
		boat.GetComponent<Rigidbody>().isKinematic = false;
		ColliderToDisable.enabled = false;
	}
}
