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
		if (attachToController)
		{
			GolfBallController golfBallController = ((controller != null) ? controller : GetComponent<GolfBallController>());
			if (golfBallController != null)
			{
				golfBallController.OnShoot += SpawnBall;
			}
		}
	}

	public void SpawnBall()
	{
		SpawnBall(Vector3.one);
	}

	public void SpawnBall(Vector3 v)
	{
		if (tennisBall == null || tennisBall.Count == 0 || spawnPosition == null)
		{
			return;
		}
		int index = UnityEngine.Random.Range(0, tennisBall.Count);
		GameObject gameObject = UnityEngine.Object.Instantiate(tennisBall[index]);
		if (gameObject != null)
		{
			gameObject.transform.position = spawnPosition.position;
			gameObject.transform.rotation = spawnPosition.rotation;
			Rigidbody component = gameObject.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.AddForce((base.transform.forward + new Vector3(0f, upModifyer, 0f)) * force * v.magnitude);
			}
			if (clipCollection != null)
			{
				clipCollection.Play(null, gameObject.transform.position);
			}
			OnBallSpawned?.Invoke(component);
		}
	}
}
