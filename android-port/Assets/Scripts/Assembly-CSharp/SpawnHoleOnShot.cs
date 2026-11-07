using System.Collections.Generic;
using Core;
using UnityEngine;

public class SpawnHoleOnShot : MonoBehaviour
{
	public List<GameObject> sequence;

	public GolfBallController ball;

	private int currentIndex;

	private void Start()
	{
	}

	private void Ball_OnShoot(Vector3 aim)
	{
	}
}
