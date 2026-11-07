using System;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class TennisCannon : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> tennisBall;

	[SerializeField]
	private Transform spawnPosition;

	[SerializeField]
	private float force;

	[SerializeField]
	private float upModifyer;

	[SerializeField]
	private ClipSettingsCollection clipCollection;

	public Action<Rigidbody> OnBallSpawned;

	[SerializeField]
	private bool attachToController;

	[SerializeField]
	private GolfBallController controller;

	private void Awake()
	{
	}

	public void SpawnBall()
	{
	}

	public void SpawnBall(Vector3 v)
	{
	}
}
