using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class DogToTruck : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private List<GameObject> Objects;

	[SerializeField]
	private int shotsBeforeWheels;

	[SerializeField]
	private ClipSettingsCollection mySfx;

	private int numShots;

	private int index;

	[SerializeField]
	private GameObject truck;

	[SerializeField]
	private Vector3 ForceOnWheelsAdded;

	[SerializeField]
	private CBFollow FollowCam;

	[SerializeField]
	private CBFollow FollowCamDesktop;

	[SerializeField]
	private ParticleSystem poofParticles;

	[SerializeField]
	private bool AddWheelsOnShoot;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Next()
	{
	}

	private void Controller_OnShoot(Vector3 obj)
	{
	}

	private IEnumerator AddTwoWheels(int i)
	{
		return null;
	}

	private IEnumerator ToTruck(Vector3 obj)
	{
		return null;
	}

	private void AddWheel(int i)
	{
	}
}
