using System.Collections.Generic;
using Core;
using UnityEngine;

public class ActivateObjectsOnShoot : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private List<GameObject> Objects;

	private int index;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Controller_OnShoot(Vector3 obj)
	{
	}
}
