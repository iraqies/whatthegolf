using Core;
using UnityEngine;

public class CameraShakeOnShoot : MonoBehaviour
{
	public float Duration;

	public float Speed;

	public float MaxMagnitude;

	private GolfBallController controller;

	private void Awake()
	{
	}

	private void Controller_OnShoot(Vector3 boost)
	{
	}
}
