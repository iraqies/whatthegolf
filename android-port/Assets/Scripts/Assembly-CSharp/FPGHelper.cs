using CameraStack;
using Core;
using UnityEngine;

public class FPGHelper : MonoBehaviour
{
	[SerializeField]
	private string downHelp;

	[SerializeField]
	private float threshold;

	private CBPerspecitveGyroscope gyro;

	private GolfBallController controller;

	private bool levelWon;

	private float warmup;

	public void Init(CBPerspecitveGyroscope camBehaviour, GolfBallController controller)
	{
	}

	private void Update()
	{
	}
}
