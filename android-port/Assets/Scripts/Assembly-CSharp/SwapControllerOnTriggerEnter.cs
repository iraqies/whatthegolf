using System.Collections.Generic;
using Cinemachine;
using Core;
using UnityEngine;

public class SwapControllerOnTriggerEnter : MonoBehaviour
{
	[SerializeField]
	private GameObject NewControllerGO;

	[SerializeField]
	private GolfBallController NewController;

	[SerializeField]
	private Transform NewCamFollow;

	[SerializeField]
	private float NewDollySpeed = 30f;

	[SerializeField]
	private ParticleSystem ParticleEffect;

	[SerializeField]
	private DollyCartSpeedManager DollySpeedManager;

	[SerializeField]
	private CinemachineVirtualCamera VCam;

	[SerializeField]
	private CinemachineVirtualCamera NewVCam;

	[SerializeField]
	private bool DebugStartFromHere;

	[SerializeField]
	private List<GameObject> GameObjectsToActivate;

	[SerializeField]
	private List<GameObject> GameObjectsToDeactivate;

	private bool HasSwapped;

	private void OnTriggerEnter(Collider other)
	{
		if (HasSwapped)
		{
			return;
		}
		GolfBallController componentInChildren = other.transform.root.GetComponentInChildren<GolfBallController>();
		if (componentInChildren != null && componentInChildren.name != NewController.name)
		{
			componentInChildren.gameObject.SetActive(false);
			componentInChildren.CurrentArrow.gameObject.SetActive(false);
			EnableThisController();
		}
	}

	private void Start()
	{
		if (NewController == null)
		{
			NewController = NewControllerGO.GetComponent<GolfBallController>();
		}
		if (DollySpeedManager == null)
		{
			DollySpeedManager = Object.FindObjectOfType<DollyCartSpeedManager>();
		}
		NewController.enabled = false;
		GameObjectsToActivate.ForEach(delegate(GameObject g)
		{
			g.SetActive(false);
		});
		if (DebugStartFromHere)
		{
			EnableThisController();
		}
	}

	private void EnableThisController()
	{
		ParticleEffect.Play();
		VCam.LookAt = NewCamFollow;
		VCam.Follow = NewCamFollow;
		if (NewVCam != null)
		{
			NewVCam.Priority = VCam.Priority + 1;
		}
		NewControllerGO.SetActive(true);
		NewController.enabled = true;
		HasSwapped = true;
		GameObjectsToActivate.ForEach(delegate(GameObject g)
		{
			g.SetActive(true);
		});
		GameObjectsToDeactivate.ForEach(delegate(GameObject g)
		{
			g.SetActive(false);
		});
		DollySpeedManager.SetNewFollower(NewCamFollow);
		DollySpeedManager.SetNewSpeed(NewDollySpeed);
	}
}
