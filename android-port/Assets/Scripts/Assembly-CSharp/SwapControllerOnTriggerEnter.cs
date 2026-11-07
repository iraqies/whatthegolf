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
	private float NewDollySpeed;

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
	}

	private void Start()
	{
	}

	private void EnableThisController()
	{
	}
}
