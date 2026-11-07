using Core;
using UnityEngine;

public class BreakJointOnShoot : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private Joint joint;

	private void Start()
	{
	}

	private void Controller_OnShoot(Vector3 boost)
	{
	}
}
