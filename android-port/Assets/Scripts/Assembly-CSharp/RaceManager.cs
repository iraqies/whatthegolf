using Core;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
	public TrafficLight[] trafficLights;

	public CarDriver[] opponents;

	public GolfBallController player;

	public GolfGoal goal;

	public AudioClip sound1;

	public AudioClip sound2;

	private AudioSource source;

	private bool done;

	private void Start()
	{
	}

	private void Player_OnAimStart()
	{
	}

	private void Player_OnShoot(Vector3 obj)
	{
	}

	private void Player_OnCancel()
	{
	}

	public void OpponentTouchedFlag(CarDriver opponent)
	{
	}

	private void Goal_OnGoal(string obj)
	{
	}
}
