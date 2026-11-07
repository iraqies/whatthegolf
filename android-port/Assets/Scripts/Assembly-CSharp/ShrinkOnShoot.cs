using Core;
using UnityEngine;

public class ShrinkOnShoot : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	public float shrinkFactor;

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
