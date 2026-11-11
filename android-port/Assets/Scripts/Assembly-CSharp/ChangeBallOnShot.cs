using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChangeBallOnShot : MonoBehaviour
{
	public List<GameObject> OtherBalls;

	public ParticleSystem ChangeParticles;

	private GameObject currentBall;

	private void Start()
	{
		currentBall = OtherBalls[0];
		currentBall.gameObject.SetActive(true);
		OtherBalls.Remove(currentBall);
		GetComponent<GolfBallController>().OnShoot += OnShoot;
	}

	private void OnShoot(Vector3 boost)
	{
		ChangeBall();
	}

	private void ChangeBall()
	{
		GameObject gameObject = OtherBalls[Random.Range(0, OtherBalls.Count)];
		gameObject.gameObject.SetActive(true);
		gameObject.transform.rotation = Quaternion.identity;
		OtherBalls.Remove(gameObject);
		OtherBalls.Add(currentBall);
		currentBall.gameObject.SetActive(false);
		currentBall = gameObject;
		ChangeParticles.Play();
	}
}
