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
		controller.OnShoot += Controller_OnShoot;
	}

	private void OnDisable()
	{
		controller.OnShoot -= Controller_OnShoot;
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		if (index < Objects.Count)
		{
			Objects[index].SetActive(true);
			index++;
		}
	}
}
